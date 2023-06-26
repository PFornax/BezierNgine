namespace BezierCurve
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.picB = new System.Windows.Forms.PictureBox();
			this.GB_Properties = new System.Windows.Forms.GroupBox();
			this.PY_label = new System.Windows.Forms.Label();
			this.PX_label = new System.Windows.Forms.Label();
			this.PY_in = new System.Windows.Forms.TextBox();
			this.PX_in = new System.Windows.Forms.TextBox();
			this.Point_label = new System.Windows.Forms.Label();
			this.Points_label = new System.Windows.Forms.Label();
			this.B_DelP = new System.Windows.Forms.Button();
			this.B_AddP = new System.Windows.Forms.Button();
			this.L_N = new System.Windows.Forms.Label();
			this.LB_Points = new System.Windows.Forms.ListBox();
			this.Res_in = new System.Windows.Forms.TextBox();
			this.Res_label = new System.Windows.Forms.Label();
			this.Res_TB = new System.Windows.Forms.TrackBar();
			this.Zoom_SB = new System.Windows.Forms.HScrollBar();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.Zoom_label = new System.Windows.Forms.Label();
			this.BC_Refresh_Timer = new System.Windows.Forms.Timer(this.components);
			this.B_RelocateNullP = new System.Windows.Forms.Button();
			this.cB_Points = new System.Windows.Forms.CheckBox();
			this.cB_PName = new System.Windows.Forms.CheckBox();
			this.cB_Lines = new System.Windows.Forms.CheckBox();
			this.cB_Bezier = new System.Windows.Forms.CheckBox();
			this.Settings_label = new System.Windows.Forms.Label();
			this.cB_Experimental = new System.Windows.Forms.CheckBox();
			this.teB_Intervall = new System.Windows.Forms.TextBox();
			this.Intervall_label = new System.Windows.Forms.Label();
			this.cB_Antialising = new System.Windows.Forms.CheckBox();
			this.Refresh_Timer = new System.Windows.Forms.Timer(this.components);
			this.Coord_label = new System.Windows.Forms.Label();
			this.But_OpenFile = new System.Windows.Forms.Button();
			this.but_save = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.cB_tP = new System.Windows.Forms.CheckBox();
			this.tB_tP = new System.Windows.Forms.TrackBar();
			this.teB_tP = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.picB)).BeginInit();
			this.GB_Properties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Res_TB)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tB_tP)).BeginInit();
			this.SuspendLayout();
			// 
			// picB
			// 
			this.picB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.picB.Location = new System.Drawing.Point(12, 12);
			this.picB.Name = "picB";
			this.picB.Size = new System.Drawing.Size(798, 641);
			this.picB.TabIndex = 0;
			this.picB.TabStop = false;
			this.picB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picB_MouseDown);
			this.picB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picB_MouseMove);
			this.picB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picB_MouseUp);
			// 
			// GB_Properties
			// 
			this.GB_Properties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.GB_Properties.Controls.Add(this.PY_label);
			this.GB_Properties.Controls.Add(this.PX_label);
			this.GB_Properties.Controls.Add(this.PY_in);
			this.GB_Properties.Controls.Add(this.PX_in);
			this.GB_Properties.Controls.Add(this.Point_label);
			this.GB_Properties.Controls.Add(this.Points_label);
			this.GB_Properties.Controls.Add(this.B_DelP);
			this.GB_Properties.Controls.Add(this.B_AddP);
			this.GB_Properties.Controls.Add(this.L_N);
			this.GB_Properties.Controls.Add(this.LB_Points);
			this.GB_Properties.Controls.Add(this.Res_in);
			this.GB_Properties.Controls.Add(this.Res_label);
			this.GB_Properties.Controls.Add(this.Res_TB);
			this.GB_Properties.Location = new System.Drawing.Point(816, 56);
			this.GB_Properties.Name = "GB_Properties";
			this.GB_Properties.Size = new System.Drawing.Size(288, 689);
			this.GB_Properties.TabIndex = 1;
			this.GB_Properties.TabStop = false;
			this.GB_Properties.Text = "Properties";
			// 
			// PY_label
			// 
			this.PY_label.AutoSize = true;
			this.PY_label.Location = new System.Drawing.Point(8, 296);
			this.PY_label.Name = "PY_label";
			this.PY_label.Size = new System.Drawing.Size(14, 13);
			this.PY_label.TabIndex = 14;
			this.PY_label.Text = "Y";
			// 
			// PX_label
			// 
			this.PX_label.AutoSize = true;
			this.PX_label.Location = new System.Drawing.Point(8, 266);
			this.PX_label.Name = "PX_label";
			this.PX_label.Size = new System.Drawing.Size(14, 13);
			this.PX_label.TabIndex = 13;
			this.PX_label.Text = "X";
			// 
			// PY_in
			// 
			this.PY_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PY_in.Location = new System.Drawing.Point(37, 289);
			this.PY_in.Name = "PY_in";
			this.PY_in.Size = new System.Drawing.Size(63, 20);
			this.PY_in.TabIndex = 12;
			this.PY_in.Text = "PY";
			this.PY_in.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PY_in_PreviewKeyDown);
			// 
			// PX_in
			// 
			this.PX_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PX_in.Location = new System.Drawing.Point(37, 263);
			this.PX_in.Name = "PX_in";
			this.PX_in.Size = new System.Drawing.Size(63, 20);
			this.PX_in.TabIndex = 11;
			this.PX_in.Text = "PX";
			this.PX_in.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PX_in_PreviewKeyDown);
			// 
			// Point_label
			// 
			this.Point_label.AutoSize = true;
			this.Point_label.Location = new System.Drawing.Point(7, 248);
			this.Point_label.Name = "Point_label";
			this.Point_label.Size = new System.Drawing.Size(14, 13);
			this.Point_label.TabIndex = 10;
			this.Point_label.Text = "P";
			// 
			// Points_label
			// 
			this.Points_label.AutoSize = true;
			this.Points_label.Location = new System.Drawing.Point(7, 97);
			this.Points_label.Name = "Points_label";
			this.Points_label.Size = new System.Drawing.Size(36, 13);
			this.Points_label.TabIndex = 9;
			this.Points_label.Text = "Points";
			// 
			// B_DelP
			// 
			this.B_DelP.Location = new System.Drawing.Point(151, 142);
			this.B_DelP.Name = "B_DelP";
			this.B_DelP.Size = new System.Drawing.Size(37, 23);
			this.B_DelP.TabIndex = 8;
			this.B_DelP.Text = "Del";
			this.B_DelP.UseVisualStyleBackColor = true;
			this.B_DelP.Click += new System.EventHandler(this.B_DelP_Click);
			// 
			// B_AddP
			// 
			this.B_AddP.Location = new System.Drawing.Point(151, 113);
			this.B_AddP.Name = "B_AddP";
			this.B_AddP.Size = new System.Drawing.Size(37, 23);
			this.B_AddP.TabIndex = 7;
			this.B_AddP.Text = "Add";
			this.B_AddP.UseVisualStyleBackColor = true;
			this.B_AddP.Click += new System.EventHandler(this.B_AddP_Click);
			// 
			// L_N
			// 
			this.L_N.AutoSize = true;
			this.L_N.Location = new System.Drawing.Point(151, 168);
			this.L_N.Name = "L_N";
			this.L_N.Size = new System.Drawing.Size(15, 13);
			this.L_N.TabIndex = 6;
			this.L_N.Text = "N";
			// 
			// LB_Points
			// 
			this.LB_Points.FormattingEnabled = true;
			this.LB_Points.Location = new System.Drawing.Point(10, 113);
			this.LB_Points.Name = "LB_Points";
			this.LB_Points.Size = new System.Drawing.Size(126, 108);
			this.LB_Points.TabIndex = 5;
			this.LB_Points.SelectedIndexChanged += new System.EventHandler(this.LB_Points_SelectedIndexChanged);
			// 
			// Res_in
			// 
			this.Res_in.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Res_in.Location = new System.Drawing.Point(219, 44);
			this.Res_in.Name = "Res_in";
			this.Res_in.Size = new System.Drawing.Size(63, 20);
			this.Res_in.TabIndex = 3;
			this.Res_in.Text = "25";
			this.Res_in.TextChanged += new System.EventHandler(this.Res_in_TextChanged);
			// 
			// Res_label
			// 
			this.Res_label.AutoSize = true;
			this.Res_label.Location = new System.Drawing.Point(7, 25);
			this.Res_label.Name = "Res_label";
			this.Res_label.Size = new System.Drawing.Size(54, 13);
			this.Res_label.TabIndex = 2;
			this.Res_label.Text = "Auflösung";
			// 
			// Res_TB
			// 
			this.Res_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Res_TB.Location = new System.Drawing.Point(6, 44);
			this.Res_TB.Maximum = 100;
			this.Res_TB.Minimum = 1;
			this.Res_TB.Name = "Res_TB";
			this.Res_TB.Size = new System.Drawing.Size(198, 45);
			this.Res_TB.TabIndex = 0;
			this.Res_TB.Value = 25;
			this.Res_TB.Scroll += new System.EventHandler(this.Res_TB_Scroll);
			// 
			// Zoom_SB
			// 
			this.Zoom_SB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Zoom_SB.Location = new System.Drawing.Point(12, 656);
			this.Zoom_SB.Minimum = 1;
			this.Zoom_SB.Name = "Zoom_SB";
			this.Zoom_SB.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Zoom_SB.Size = new System.Drawing.Size(798, 18);
			this.Zoom_SB.TabIndex = 2;
			this.Zoom_SB.Value = 10;
			this.Zoom_SB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Zoom_SB_Scroll);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 757);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// Zoom_label
			// 
			this.Zoom_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Zoom_label.AutoSize = true;
			this.Zoom_label.Location = new System.Drawing.Point(13, 678);
			this.Zoom_label.Name = "Zoom_label";
			this.Zoom_label.Size = new System.Drawing.Size(52, 13);
			this.Zoom_label.TabIndex = 5;
			this.Zoom_label.Text = "Zoom = 1";
			// 
			// BC_Refresh_Timer
			// 
			this.BC_Refresh_Timer.Tick += new System.EventHandler(this.Refresh_Timer_Tick);
			// 
			// B_RelocateNullP
			// 
			this.B_RelocateNullP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.B_RelocateNullP.Location = new System.Drawing.Point(748, 678);
			this.B_RelocateNullP.Name = "B_RelocateNullP";
			this.B_RelocateNullP.Size = new System.Drawing.Size(62, 23);
			this.B_RelocateNullP.TabIndex = 15;
			this.B_RelocateNullP.Text = "Relocate";
			this.B_RelocateNullP.UseVisualStyleBackColor = true;
			this.B_RelocateNullP.Click += new System.EventHandler(this.B_RelocateNullP_Click);
			// 
			// cB_Points
			// 
			this.cB_Points.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cB_Points.AutoSize = true;
			this.cB_Points.Checked = true;
			this.cB_Points.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cB_Points.Location = new System.Drawing.Point(97, 707);
			this.cB_Points.Name = "cB_Points";
			this.cB_Points.Size = new System.Drawing.Size(85, 17);
			this.cB_Points.TabIndex = 16;
			this.cB_Points.Text = "Show Points";
			this.cB_Points.UseVisualStyleBackColor = true;
			this.cB_Points.CheckedChanged += new System.EventHandler(this.cB_Points_CheckedChanged);
			// 
			// cB_PName
			// 
			this.cB_PName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cB_PName.AutoSize = true;
			this.cB_PName.Checked = true;
			this.cB_PName.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cB_PName.Location = new System.Drawing.Point(97, 730);
			this.cB_PName.Name = "cB_PName";
			this.cB_PName.Size = new System.Drawing.Size(96, 17);
			this.cB_PName.TabIndex = 17;
			this.cB_PName.Text = "Show PNames";
			this.cB_PName.UseVisualStyleBackColor = true;
			this.cB_PName.CheckedChanged += new System.EventHandler(this.cB_PName_CheckedChanged);
			// 
			// cB_Lines
			// 
			this.cB_Lines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cB_Lines.AutoSize = true;
			this.cB_Lines.Location = new System.Drawing.Point(204, 730);
			this.cB_Lines.Name = "cB_Lines";
			this.cB_Lines.Size = new System.Drawing.Size(81, 17);
			this.cB_Lines.TabIndex = 19;
			this.cB_Lines.Text = "Show Lines";
			this.cB_Lines.UseVisualStyleBackColor = true;
			this.cB_Lines.CheckedChanged += new System.EventHandler(this.cB_Lines_CheckedChanged);
			// 
			// cB_Bezier
			// 
			this.cB_Bezier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cB_Bezier.AutoSize = true;
			this.cB_Bezier.Checked = true;
			this.cB_Bezier.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cB_Bezier.Location = new System.Drawing.Point(204, 707);
			this.cB_Bezier.Name = "cB_Bezier";
			this.cB_Bezier.Size = new System.Drawing.Size(84, 17);
			this.cB_Bezier.TabIndex = 18;
			this.cB_Bezier.Text = "Show Curve";
			this.cB_Bezier.UseVisualStyleBackColor = true;
			this.cB_Bezier.CheckedChanged += new System.EventHandler(this.cB_Bezier_CheckedChanged);
			// 
			// Settings_label
			// 
			this.Settings_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Settings_label.AutoSize = true;
			this.Settings_label.Location = new System.Drawing.Point(94, 691);
			this.Settings_label.Name = "Settings_label";
			this.Settings_label.Size = new System.Drawing.Size(45, 13);
			this.Settings_label.TabIndex = 20;
			this.Settings_label.Text = "Settings";
			// 
			// cB_Experimental
			// 
			this.cB_Experimental.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cB_Experimental.AutoSize = true;
			this.cB_Experimental.Location = new System.Drawing.Point(461, 690);
			this.cB_Experimental.Name = "cB_Experimental";
			this.cB_Experimental.Size = new System.Drawing.Size(98, 17);
			this.cB_Experimental.TabIndex = 22;
			this.cB_Experimental.Text = "! Experimental !";
			this.cB_Experimental.UseVisualStyleBackColor = true;
			this.cB_Experimental.CheckedChanged += new System.EventHandler(this.cB_Experimental_CheckedChanged);
			// 
			// teB_Intervall
			// 
			this.teB_Intervall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.teB_Intervall.Location = new System.Drawing.Point(565, 704);
			this.teB_Intervall.Name = "teB_Intervall";
			this.teB_Intervall.Size = new System.Drawing.Size(34, 20);
			this.teB_Intervall.TabIndex = 15;
			this.teB_Intervall.Tag = "";
			this.teB_Intervall.Text = "100";
			this.teB_Intervall.Visible = false;
			this.teB_Intervall.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.teB_Intervall_PreviewKeyDown);
			// 
			// Intervall_label
			// 
			this.Intervall_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Intervall_label.AutoSize = true;
			this.Intervall_label.Location = new System.Drawing.Point(477, 707);
			this.Intervall_label.Name = "Intervall_label";
			this.Intervall_label.Size = new System.Drawing.Size(82, 13);
			this.Intervall_label.TabIndex = 23;
			this.Intervall_label.Tag = "";
			this.Intervall_label.Text = "Render Intervall";
			this.Intervall_label.Visible = false;
			// 
			// cB_Antialising
			// 
			this.cB_Antialising.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cB_Antialising.AutoSize = true;
			this.cB_Antialising.Checked = true;
			this.cB_Antialising.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cB_Antialising.Location = new System.Drawing.Point(630, 703);
			this.cB_Antialising.Name = "cB_Antialising";
			this.cB_Antialising.Size = new System.Drawing.Size(73, 17);
			this.cB_Antialising.TabIndex = 24;
			this.cB_Antialising.Tag = "";
			this.cB_Antialising.Text = "Antialising";
			this.cB_Antialising.UseVisualStyleBackColor = true;
			this.cB_Antialising.Visible = false;
			this.cB_Antialising.CheckedChanged += new System.EventHandler(this.cB_Antialising_CheckedChanged);
			// 
			// Refresh_Timer
			// 
			this.Refresh_Timer.Enabled = true;
			this.Refresh_Timer.Interval = 20;
			this.Refresh_Timer.Tick += new System.EventHandler(this.Refresh_Timer_Tick_1);
			// 
			// Coord_label
			// 
			this.Coord_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Coord_label.AutoSize = true;
			this.Coord_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Coord_label.Location = new System.Drawing.Point(29, 626);
			this.Coord_label.Name = "Coord_label";
			this.Coord_label.Size = new System.Drawing.Size(36, 13);
			this.Coord_label.TabIndex = 25;
			this.Coord_label.Text = "(X ; Y)";
			// 
			// But_OpenFile
			// 
			this.But_OpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.But_OpenFile.Location = new System.Drawing.Point(862, 12);
			this.But_OpenFile.Name = "But_OpenFile";
			this.But_OpenFile.Size = new System.Drawing.Size(75, 23);
			this.But_OpenFile.TabIndex = 26;
			this.But_OpenFile.Text = "Open";
			this.But_OpenFile.UseVisualStyleBackColor = true;
			this.But_OpenFile.Click += new System.EventHandler(this.But_OpenFile_Click);
			// 
			// but_save
			// 
			this.but_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.but_save.Location = new System.Drawing.Point(989, 12);
			this.but_save.Name = "but_save";
			this.but_save.Size = new System.Drawing.Size(75, 23);
			this.but_save.TabIndex = 27;
			this.but_save.Text = "Save";
			this.but_save.UseVisualStyleBackColor = true;
			this.but_save.Click += new System.EventHandler(this.but_save_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.FileName = "UnnamedBezier";
			// 
			// cB_tP
			// 
			this.cB_tP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cB_tP.AutoSize = true;
			this.cB_tP.Location = new System.Drawing.Point(303, 707);
			this.cB_tP.Name = "cB_tP";
			this.cB_tP.Size = new System.Drawing.Size(85, 17);
			this.cB_tP.TabIndex = 28;
			this.cB_tP.Text = "Show t point";
			this.cB_tP.UseVisualStyleBackColor = true;
			this.cB_tP.CheckedChanged += new System.EventHandler(this.cB_tP_CheckedChanged);
			// 
			// tB_tP
			// 
			this.tB_tP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tB_tP.Location = new System.Drawing.Point(303, 721);
			this.tB_tP.Maximum = 100;
			this.tB_tP.Name = "tB_tP";
			this.tB_tP.Size = new System.Drawing.Size(85, 45);
			this.tB_tP.TabIndex = 29;
			this.tB_tP.Value = 50;
			this.tB_tP.Scroll += new System.EventHandler(this.tB_tP_Scroll);
			// 
			// teB_tP
			// 
			this.teB_tP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.teB_tP.Location = new System.Drawing.Point(385, 721);
			this.teB_tP.Name = "teB_tP";
			this.teB_tP.Size = new System.Drawing.Size(34, 20);
			this.teB_tP.TabIndex = 30;
			this.teB_tP.Tag = "";
			this.teB_tP.Text = "0.5";
			this.teB_tP.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.teB_tP_PreviewKeyDown);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1116, 757);
			this.Controls.Add(this.teB_tP);
			this.Controls.Add(this.tB_tP);
			this.Controls.Add(this.cB_tP);
			this.Controls.Add(this.but_save);
			this.Controls.Add(this.But_OpenFile);
			this.Controls.Add(this.Coord_label);
			this.Controls.Add(this.cB_Antialising);
			this.Controls.Add(this.Intervall_label);
			this.Controls.Add(this.teB_Intervall);
			this.Controls.Add(this.cB_Experimental);
			this.Controls.Add(this.Settings_label);
			this.Controls.Add(this.cB_Lines);
			this.Controls.Add(this.cB_Bezier);
			this.Controls.Add(this.cB_PName);
			this.Controls.Add(this.cB_Points);
			this.Controls.Add(this.B_RelocateNullP);
			this.Controls.Add(this.Zoom_label);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.Zoom_SB);
			this.Controls.Add(this.GB_Properties);
			this.Controls.Add(this.picB);
			this.Name = "Form1";
			this.Text = "BezierNgine";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
			((System.ComponentModel.ISupportInitialize)(this.picB)).EndInit();
			this.GB_Properties.ResumeLayout(false);
			this.GB_Properties.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Res_TB)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tB_tP)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picB;
		private System.Windows.Forms.GroupBox GB_Properties;
		private System.Windows.Forms.TrackBar Res_TB;
		private System.Windows.Forms.HScrollBar Zoom_SB;
		private System.Windows.Forms.Label Res_label;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.TextBox Res_in;
		private System.Windows.Forms.Label Zoom_label;
		private System.Windows.Forms.Timer BC_Refresh_Timer;
		private System.Windows.Forms.ListBox LB_Points;
		private System.Windows.Forms.Label L_N;
		private System.Windows.Forms.Button B_DelP;
		private System.Windows.Forms.Button B_AddP;
		private System.Windows.Forms.Label Point_label;
		private System.Windows.Forms.Label Points_label;
		private System.Windows.Forms.Label PY_label;
		private System.Windows.Forms.Label PX_label;
		private System.Windows.Forms.TextBox PY_in;
		private System.Windows.Forms.TextBox PX_in;
		private System.Windows.Forms.Button B_RelocateNullP;
		private System.Windows.Forms.CheckBox cB_Points;
		private System.Windows.Forms.CheckBox cB_PName;
		private System.Windows.Forms.CheckBox cB_Lines;
		private System.Windows.Forms.CheckBox cB_Bezier;
		private System.Windows.Forms.Label Settings_label;
		private System.Windows.Forms.CheckBox cB_Experimental;
		private System.Windows.Forms.TextBox teB_Intervall;
		private System.Windows.Forms.Label Intervall_label;
		private System.Windows.Forms.CheckBox cB_Antialising;
		private System.Windows.Forms.Timer Refresh_Timer;
		private System.Windows.Forms.Label Coord_label;
		private System.Windows.Forms.Button But_OpenFile;
		private System.Windows.Forms.Button but_save;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.CheckBox cB_tP;
		private System.Windows.Forms.TrackBar tB_tP;
		private System.Windows.Forms.TextBox teB_tP;
	}
}

