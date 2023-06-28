using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BezierCurve
{
	public partial class Form1 : Form
	{

		#region Init


		bool picB_relocate = false;
		bool p_relocate = false;
		int mXdif = 0;
		int mYdif = 0;
		int mXmult = 0;
		int mYmult = 0;

		int bX = 0;
		int bY = 0;

		int pIndRel = 0;

		int bXdif = 0;
		int bYdif = 0;
		int pXdif = 0;
		int pYdif = 0;


		Pen bl = new Pen(Color.Black);
		Pen red = new Pen(Color.Red);
		Pen blue = new Pen(Color.Blue);
		Pen green = new Pen(Color.Green,5);
		Font font = new Font("Arial",18);
		Brush brush_bl = new SolidBrush(Color.Black);
		

		//Starterliste
		List<Point> p = new List<Point> { new Point(100, 100), new Point(200, 300), new Point(400, 300), new Point(500, 100), new Point(100, 500) };

		public Form1()
		{
			InitializeComponent();
			red.Width = 2f;
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			Render_BC();
			Refresh_Lists();
			LB_Points.SelectedIndex = 0;
		}

		#endregion


		#region Render


		private void Render_BC()
		{
			
			Bitmap DrawArea = new Bitmap(picB.Size.Width, picB.Size.Height);
			Graphics g = Graphics.FromImage(DrawArea);

			if (cB_Antialising.Checked == true)
			{
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
			}

			if (cB_Bezier.Checked)
			{
				DrawNBezier(g, red, p);
			}
			
			if (cB_Points.Checked)
			{
				foreach (Point point in p)
					g.DrawRectangle(bl, point.X * Zoom_SB.Value * 0.1f - 3 + bX, point.Y * Zoom_SB.Value * 0.1f - 3 + bY, 4, 4);
			}
			

			if (cB_PName.Checked)
			{
				g.DrawString("pA", font, brush_bl, new Point((int)(p[0].X * Zoom_SB.Value * 0.1f  + bX),  (int)(p[0].Y * Zoom_SB.Value * 0.1f + bY)));
				for (int i = 1; i < p.Count - 1; i++)
				{
					g.DrawString($"p{i}", font, brush_bl, new Point((int)(p[i].X * Zoom_SB.Value * 0.1f + bX), (int)(p[i].Y * Zoom_SB.Value * 0.1f + bY)));
				}
				g.DrawString("pE", font, brush_bl, new Point((int)(p[p.Count - 1].X * Zoom_SB.Value * 0.1f + bX), (int)(p[p.Count - 1].Y * Zoom_SB.Value * 0.1f + bY)));
			}
			
			if (cB_Lines.Checked)
			{
				for(int i = 0; i < p.Count - 1; i++)
				{
					g.DrawLine(blue, p[i].X * Zoom_SB.Value * 0.1f - 1 + bX, p[i].Y * Zoom_SB.Value * 0.1f - 1 + bY, p[i + 1].X * Zoom_SB.Value * 0.1f - 1 + bX, p[i + 1].Y * Zoom_SB.Value * 0.1f - 1 + bY);
				}
				
			}

			if (cB_tP.Checked)
			{
				List<Point> fixed_points = new List<Point>();
				for (int i = 0; i < p.Count; i++)
				{
					fixed_points.Add(new Point((int)(p[i].X * Zoom_SB.Value * 0.1f), (int)(p[i].Y * Zoom_SB.Value * 0.1f)));
				}
				g.DrawRectangle(green, Calc_BezierPoint((float)(tB_tP.Value) / 100f, fixed_points).X - 3, Calc_BezierPoint((float)(tB_tP.Value) / 100f, fixed_points).Y - 3, 4, 4);
			}

			picB.Image = DrawArea;

		}
		private void Refresh_Timer_Tick(object sender, EventArgs e)
		{
			Render_BC();
			BC_Refresh_Timer.Stop();
		}
		private void Refresh_Timer_Tick_1(object sender, EventArgs e)
		{
			Coord_label.Text = $"( {(int)((picB.PointToClient(MousePosition).X - bX) / (Zoom_SB.Value * 0.1))} ; {(int)((picB.PointToClient(MousePosition).Y - bY) / (Zoom_SB.Value * 0.1))} )";
		}

		#endregion

		#region Bezier Curve Generation


		/// <summary>
		///  Calculates and draws one N Bezier Curve with given points.
		/// </summary>
		private void DrawNBezier(Graphics g, Pen pen, List<Point> points)
		{
			List<Point> fixed_points = new List<Point> ();
			for (int i = 0; i < points.Count; i++)
			{
				fixed_points.Add( new Point((int)(points[i].X * Zoom_SB.Value * 0.1f), (int)(points[i].Y * Zoom_SB.Value * 0.1f)));
			}

			List<Point> bezier_points = new List<Point>();
			for (float t = 0f; t <= 1f; t += (float)(1f/Res_TB.Value))
			{

				bezier_points.Add(Calc_BezierPoint(t, fixed_points));

			}
			bezier_points.Add(Calc_BezierPoint(1, fixed_points));

			for (int i = 0; i < bezier_points.Count - 1; i++)
			{
				g.DrawLine(pen, bezier_points[i], bezier_points[i + 1]);
			}

		}

		/// <summary>
		/// Diese Methode Rechnet Rekursiv einen Punkt auf einer N-Bezier Kurve aus.
		/// </summary>
		/// <param name="t"></param>
		/// <param name="points"></param>
		/// <returns></returns>
		private Point Calc_BezierPoint(float t, List<Point> points)

		{
			List<Point> new_points = new List<Point>();
			for (int i = 0; i < points.Count - 1; i++)
			{
				new_points.Add(Point_lerp(points[i], points[i + 1], t));
			}

			if (new_points.Count == 1)
			{
				//return new Point((int)(new_points[0].X * Zoom_SB.Value * 0.1f) + bX, (int)(new_points[0].Y * Zoom_SB.Value * 0.1f) + bY);
				return new Point((int)(new_points[0].X ) + bX, (int)(new_points[0].Y ) + bY);
			}
			return Calc_BezierPoint(t, new_points);

		}

		/// <summary>
		/// Lerp method between two Points a and b, calculating by t value t.
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <param name="t"></param>
		/// <returns></returns>
		private Point Point_lerp(Point a, Point b, float t)
		{
			float x = (1 - t) * a.X + t * b.X;
			float y = (1 - t) * a.Y + t * b.Y;

			return new Point((int)x, (int)y);
		}

		#endregion

		#region Point_List


		private void Refresh_Lists()
		{
			LB_Points.Items.Clear();
			L_N.Text = $"n = {p.Count.ToString()}";
			LB_Points.Items.Add($"PA   {p[0]}");
			for (int i = 1; i < p.Count - 1; i++)
			{
				LB_Points.Items.Add($"P{i}  {p[i]}");
			}
			LB_Points.Items.Add($"PE   {p[p.Count - 1]}");
			
		}

		private void B_AddP_Click(object sender, EventArgs e)
		{
			int i;

			if (LB_Points.SelectedIndex != -1 & LB_Points.SelectedIndex != p.Count - 1)
			{
				i = LB_Points.SelectedIndex;
				p.Insert(i + 1, new Point(p[i].X + 40, p[i].Y + 10));
			}

			else
			{
				i = p.Count - 1 ;
				p.Insert(i + 1, new Point(p[i].X + 40, p[i].Y + 10));
			}
			Console.WriteLine(p[i + 1]);

			Refresh_Lists();
			Render_BC();

			LB_Points.SelectedIndex = i + 1 ;
		}

		private void B_DelP_Click(object sender, EventArgs e)
		{
			if (p.Count > 2)
			{
				int i;
				if (LB_Points.SelectedIndex != -1 & LB_Points.SelectedIndex != p.Count - 1)
				{
					i = LB_Points.SelectedIndex;
					p.RemoveAt(LB_Points.SelectedIndex);
				}

				else
				{
					i = p.Count - 2;
					p.RemoveAt(p.Count - 1);
				}
				Refresh_Lists();
				Render_BC();

				LB_Points.SelectedIndex = i;
			}
		}

		private void LB_Points_SelectedIndexChanged(object sender, EventArgs e)
		{
			Point_label.Text = $"P{LB_Points.SelectedIndex}";
			PX_in.Text = p[LB_Points.SelectedIndex].X.ToString();
			PY_in.Text = p[LB_Points.SelectedIndex].Y.ToString();
			
		}
		
		private void PX_in_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				
				p[LB_Points.SelectedIndex] = new Point(int.Parse(PX_in.Text), p[LB_Points.SelectedIndex].Y);
				int Pind = LB_Points.SelectedIndex;
				Refresh_Lists() ;
				LB_Points.SelectedIndex = Pind;

				Render_BC();
			}

		}

		private void PY_in_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				p[LB_Points.SelectedIndex] = new Point(p[LB_Points.SelectedIndex].X, int.Parse(PY_in.Text));
				Render_BC();
			}
		}

		#endregion

		#region UI_Changes

		private void Form1_ResizeEnd(object sender, EventArgs e)
		{
			Render_BC();
		}


		private void Res_TB_Scroll(object sender, EventArgs e)
		{
			
			BC_Refresh_Timer.Start();
			Res_in.Text = $"{Res_TB.Value}";
		}

		private void Zoom_SB_Scroll(object sender, ScrollEventArgs e)
		{
			Zoom_label.Text = $"Zoom = {Zoom_SB.Value * 0.1f}";
			BC_Refresh_Timer.Start();
		}

		private void Res_in_TextChanged(object sender, EventArgs e)
		{
			if(int.Parse(Res_in.Text) < 1 || int.Parse(Res_in.Text) > Res_TB.Maximum) 
			{
				Res_in.Text = "25";
			}


			Res_TB.Value = int.Parse(Res_in.Text);
			BC_Refresh_Timer.Start();
		}

		private void picB_MouseDown(object sender, MouseEventArgs e)
		{
			var Coords = picB.PointToClient(MousePosition);
			pIndRel = -1;
			//foreach (Point point in p) if (MousePosition = (point.X * Zoom_SB.Value * 0.1f - 1 + bX))
			if( cB_Lines.Checked || cB_Points.Checked)
			{
				for (int PInd = 0; PInd < p.Count; PInd++)
				{
					if (p[PInd].X * Zoom_SB.Value * 0.1 + bX <= Coords.X + 10 & p[PInd].X * Zoom_SB.Value * 0.1 + bX >= Coords.X - 10 & p[PInd].Y * Zoom_SB.Value * 0.1 + bY <= Coords.Y + 10 & p[PInd].Y * Zoom_SB.Value * 0.1 + bY>= Coords.Y  - 10)
					{
						pIndRel = PInd; 
						break;
					}
				}
			}

			if (pIndRel == -1)
			{
				picB_relocate = true;
				bXdif = bX;
				bYdif = bY;
			}
			else
			{
				p_relocate = true;
				pXdif = p[pIndRel].X;
				pYdif = p[pIndRel].Y;
			}

			BC_Refresh_Timer.Start();
			mXdif = MousePosition.X;
			mYdif = MousePosition.Y;


		}

		private void picB_MouseUp(object sender, MouseEventArgs e)
		{
			picB_relocate = false;
			p_relocate = false;
			BC_Refresh_Timer.Stop();
			Render_BC();
			mXmult = 0;
			mYmult = 0;
		}

		private void picB_MouseMove(object sender, MouseEventArgs e)
		{
			if (BC_Refresh_Timer.Enabled == false & picB_relocate == true)
			{
				#region mouse_fixing
				if (MousePosition.Y >= Screen.PrimaryScreen.Bounds.Height - 1)
				{
					Cursor.Position = new Point(MousePosition.X, 1);
					mYmult++;
				}

				if (MousePosition.Y <= 0)
				{
					Cursor.Position = new Point(MousePosition.X, Screen.PrimaryScreen.Bounds.Height - 2);
					mYmult--;
				}

				if (MousePosition.X >= Screen.PrimaryScreen.Bounds.Width - 1)
				{
					Cursor.Position = new Point(1, MousePosition.Y);
					mXmult++;
				}

				if (MousePosition.X <= 0)
				{
					Cursor.Position = new Point(Screen.PrimaryScreen.Bounds.Width - 2, MousePosition.Y);
					mXmult--;
				}
				#endregion

				bX = (bXdif + MousePosition.X + Screen.PrimaryScreen.Bounds.Width * mXmult - mXdif);
				bY = (bYdif + MousePosition.Y + Screen.PrimaryScreen.Bounds.Height * mYmult - mYdif);
				BC_Refresh_Timer.Start();
			}

			if (BC_Refresh_Timer.Enabled == false & p_relocate == true)
			{
				#region mouse_fixing
				if (MousePosition.Y >= Screen.PrimaryScreen.Bounds.Height - 1)
				{
					Cursor.Position = new Point(MousePosition.X, 1);
					mYmult++;
				}

				if (MousePosition.Y <= 0)
				{
					Cursor.Position = new Point(MousePosition.X, Screen.PrimaryScreen.Bounds.Height - 2);
					mYmult--;
				}

				if (MousePosition.X >= Screen.PrimaryScreen.Bounds.Width - 1)
				{
					Cursor.Position = new Point(1, MousePosition.Y);
					mXmult++;
				}

				if (MousePosition.X <= 0)
				{
					Cursor.Position = new Point(Screen.PrimaryScreen.Bounds.Width - 2, MousePosition.Y);
					mXmult--;
				}
				#endregion
				p[pIndRel] = new Point(

					(int)(pXdif + (MousePosition.X + Screen.PrimaryScreen.Bounds.Width * mXmult - mXdif) / (Zoom_SB.Value *0.1))   , 
					(int)(pYdif + (MousePosition.Y + Screen.PrimaryScreen.Bounds.Height * mYmult - mYdif) / (Zoom_SB.Value * 0.1)) 

					);

				Refresh_Lists();
				BC_Refresh_Timer.Start();
			}
		}
		
		private void B_RelocateNullP_Click(object sender, EventArgs e)
		{
			bX = 0;
			bY = 0;
			Zoom_SB.Value = 10;
			Render_BC();
		}





		#endregion

		#region Settings
		private void cB_Experimental_CheckedChanged(object sender, EventArgs e)
		{
			if (cB_Experimental.Checked)
			{
				cB_Antialising.Visible = true;
				Intervall_label.Visible = true;
				teB_Intervall.Visible = true;
			}
			else 
			{
				cB_Antialising.Visible = false;
				Intervall_label.Visible = false;
				teB_Intervall.Visible = false;
			}
		}

		private void cB_Antialising_CheckedChanged(object sender, EventArgs e)
		{
			Render_BC();
		}

		private void teB_Intervall_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				if (teB_Intervall.Text == "" || !teB_Intervall.Text.All(char.IsDigit) || int.Parse(teB_Intervall.Text) < 1 )
				{
					teB_Intervall.Text = "1";
				}
				BC_Refresh_Timer.Interval = int.Parse(teB_Intervall.Text);
			}
		}

		private void cB_Points_CheckedChanged(object sender, EventArgs e)
		{
			Render_BC();
		}

		private void cB_PName_CheckedChanged(object sender, EventArgs e)
		{
			Render_BC();
		}

		private void cB_Bezier_CheckedChanged(object sender, EventArgs e)
		{
			Render_BC();
		}

		private void cB_Lines_CheckedChanged(object sender, EventArgs e)
		{
			Render_BC();
		}
		private void cB_tP_CheckedChanged(object sender, EventArgs e)
		{
			Render_BC();
		}

		private void tB_tP_Scroll(object sender, EventArgs e)
		{
			BC_Refresh_Timer.Start();
			teB_tP.Text = $"{(float)tB_tP.Value / 100f}";
		}

		private void teB_tP_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (teB_tP.Text != "" & teB_tP.Text.All(char.IsPunctuation) & float.Parse(teB_tP.Text) <= 1 & float.Parse(teB_tP.Text) >= 0)
				{
					tB_tP.Value = (int)(float.Parse(teB_tP.Text) * 100f);
					Render_BC();
				}
				
			}
		}


		#endregion

		#region FileDialog
		private void But_OpenFile_Click(object sender, EventArgs e)
		{
			openFileDialog.Filter = "(*.txt, *.bezn)|*.txt;*.bezn";

			if(openFileDialog.ShowDialog() == DialogResult.OK)
			{
				var data = new StreamReader(openFileDialog.FileName);
				string line = "start";
				string[] splitline;
				p.Clear();
				if(data.ReadLine() == "start")
				{
					while (true)
					{
						line = data.ReadLine();
						splitline = line.Split(' ');
						if (line == "end")
						{
							break;
						}
						p.Add(new Point(int.Parse(splitline[0]), int.Parse(splitline[1])));
					
					}
					Refresh_Lists();
					Render_BC();
				}
				else
				{
					MessageBox.Show("Error, file is either corrupted or not meant to be opened.");
				}
				


			}

		}

		private void but_save_Click(object sender, EventArgs e)
		{
			saveFileDialog.Filter = "*.bezn|*.bezn";
			if(saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if(saveFileDialog.FileName != "")
				{
					var sw = new StreamWriter(File.Create(saveFileDialog.FileName));
					sw.WriteLine("start");
					foreach(Point point in p) sw.WriteLine($"{point.X} {point.Y}");
					sw.WriteLine("end");
					sw.Close();
				}
				else
				{
					MessageBox.Show("Error, couldn't save file because of a missing filename");
				}
				

			}
		}



		#endregion

	}
}
