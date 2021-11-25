namespace Mobile_Shop_Manager
{
	partial class Moobile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moobile));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mobid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.brandtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.modeltb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.pricetb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.stocktb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ramcb = new System.Windows.Forms.ComboBox();
            this.romcb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.mobileDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Footlight MT Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(260, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "MOBILE MANAGEMENT SYSTEM";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(360, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manage Mobiles";
            this.label2.UseMnemonic = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(876, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "X";
            this.label3.UseMnemonic = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(44, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            this.label4.UseMnemonic = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // mobid
            // 
            this.mobid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.mobid.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobid.ForeColor = System.Drawing.Color.Black;
            this.mobid.HintForeColor = System.Drawing.Color.Empty;
            this.mobid.HintText = "";
            this.mobid.isPassword = false;
            this.mobid.LineFocusedColor = System.Drawing.Color.Blue;
            this.mobid.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.mobid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.mobid.LineThickness = 4;
            this.mobid.Location = new System.Drawing.Point(85, 205);
            this.mobid.Margin = new System.Windows.Forms.Padding(5);
            this.mobid.Name = "mobid";
            this.mobid.Size = new System.Drawing.Size(93, 25);
            this.mobid.TabIndex = 7;
            this.mobid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.mobid.OnValueChanged += new System.EventHandler(this.UidTb_OnValueChanged);
            // 
            // brandtb
            // 
            this.brandtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.brandtb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandtb.ForeColor = System.Drawing.Color.Black;
            this.brandtb.HintForeColor = System.Drawing.Color.Empty;
            this.brandtb.HintText = "";
            this.brandtb.isPassword = false;
            this.brandtb.LineFocusedColor = System.Drawing.Color.Blue;
            this.brandtb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.brandtb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.brandtb.LineThickness = 4;
            this.brandtb.Location = new System.Drawing.Point(302, 205);
            this.brandtb.Margin = new System.Windows.Forms.Padding(5);
            this.brandtb.Name = "brandtb";
            this.brandtb.Size = new System.Drawing.Size(133, 25);
            this.brandtb.TabIndex = 9;
            this.brandtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(222, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Brand";
            this.label5.UseMnemonic = false;
            // 
            // modeltb
            // 
            this.modeltb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modeltb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeltb.ForeColor = System.Drawing.Color.Black;
            this.modeltb.HintForeColor = System.Drawing.Color.Empty;
            this.modeltb.HintText = "";
            this.modeltb.isPassword = false;
            this.modeltb.LineFocusedColor = System.Drawing.Color.Blue;
            this.modeltb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.modeltb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.modeltb.LineThickness = 4;
            this.modeltb.Location = new System.Drawing.Point(559, 205);
            this.modeltb.Margin = new System.Windows.Forms.Padding(5);
            this.modeltb.Name = "modeltb";
            this.modeltb.Size = new System.Drawing.Size(116, 25);
            this.modeltb.TabIndex = 13;
            this.modeltb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(475, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Model";
            this.label6.UseMnemonic = false;
            // 
            // pricetb
            // 
            this.pricetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pricetb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricetb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pricetb.HintForeColor = System.Drawing.Color.Empty;
            this.pricetb.HintText = "";
            this.pricetb.isPassword = false;
            this.pricetb.LineFocusedColor = System.Drawing.Color.Blue;
            this.pricetb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.pricetb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.pricetb.LineThickness = 4;
            this.pricetb.Location = new System.Drawing.Point(793, 205);
            this.pricetb.Margin = new System.Windows.Forms.Padding(5);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(109, 25);
            this.pricetb.TabIndex = 15;
            this.pricetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(724, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Price";
            this.label7.UseMnemonic = false;
            // 
            // stocktb
            // 
            this.stocktb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stocktb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stocktb.ForeColor = System.Drawing.Color.Black;
            this.stocktb.HintForeColor = System.Drawing.Color.Empty;
            this.stocktb.HintText = "";
            this.stocktb.isPassword = false;
            this.stocktb.LineFocusedColor = System.Drawing.Color.Blue;
            this.stocktb.LineIdleColor = System.Drawing.SystemColors.Highlight;
            this.stocktb.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.stocktb.LineThickness = 4;
            this.stocktb.Location = new System.Drawing.Point(119, 263);
            this.stocktb.Margin = new System.Windows.Forms.Padding(5);
            this.stocktb.Name = "stocktb";
            this.stocktb.Size = new System.Drawing.Size(93, 25);
            this.stocktb.TabIndex = 17;
            this.stocktb.Text = "  ";
            this.stocktb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(44, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Stock";
            this.label8.UseMnemonic = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(238, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "RAM (GB)";
            this.label9.UseMnemonic = false;
            // 
            // ramcb
            // 
            this.ramcb.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ramcb.FormattingEnabled = true;
            this.ramcb.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "16"});
            this.ramcb.Location = new System.Drawing.Point(355, 273);
            this.ramcb.Name = "ramcb";
            this.ramcb.Size = new System.Drawing.Size(121, 33);
            this.ramcb.TabIndex = 20;
            // 
            // romcb
            // 
            this.romcb.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.romcb.FormattingEnabled = true;
            this.romcb.Items.AddRange(new object[] {
            "8",
            "16",
            "32",
            "64",
            "128",
            "256"});
            this.romcb.Location = new System.Drawing.Point(644, 273);
            this.romcb.Name = "romcb";
            this.romcb.Size = new System.Drawing.Size(121, 33);
            this.romcb.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(525, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "ROM (GB)";
            this.label10.UseMnemonic = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(-1, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 43);
            this.panel1.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(415, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Mobiles Stock";
            this.label11.UseMnemonic = false;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "ADD";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 30;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(40, 351);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(162, 44);
            this.bunifuThinButton21.TabIndex = 24;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "UPDATE";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 30;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(266, 351);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(163, 44);
            this.bunifuThinButton22.TabIndex = 25;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton23.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "DELETE";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 30;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(512, 351);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(163, 44);
            this.bunifuThinButton23.TabIndex = 26;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton24.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "CLEAR";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 30;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.Location = new System.Drawing.Point(723, 351);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(163, 44);
            this.bunifuThinButton24.TabIndex = 27;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // mobileDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.mobileDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.mobileDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mobileDGV.BackgroundColor = System.Drawing.Color.White;
            this.mobileDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mobileDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.mobileDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mobileDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.mobileDGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mobileDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.mobileDGV.EnableHeadersVisualStyles = false;
            this.mobileDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.mobileDGV.Location = new System.Drawing.Point(-1, 465);
            this.mobileDGV.Name = "mobileDGV";
            this.mobileDGV.RowHeadersVisible = false;
            this.mobileDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mobileDGV.Size = new System.Drawing.Size(922, 222);
            this.mobileDGV.TabIndex = 28;
            this.mobileDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.mobileDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.mobileDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.mobileDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.mobileDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.mobileDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.mobileDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.mobileDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.mobileDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.mobileDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.mobileDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.mobileDGV.ThemeStyle.HeaderStyle.Height = 25;
            this.mobileDGV.ThemeStyle.ReadOnly = false;
            this.mobileDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.mobileDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.mobileDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.mobileDGV.ThemeStyle.RowsStyle.Height = 22;
            this.mobileDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.mobileDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.mobileDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mobileDGV_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(393, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuThinButton25
            // 
            this.bunifuThinButton25.ActiveBorderThickness = 1;
            this.bunifuThinButton25.ActiveCornerRadius = 20;
            this.bunifuThinButton25.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuThinButton25.ActiveForecolor = System.Drawing.SystemColors.Window;
            this.bunifuThinButton25.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuThinButton25.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton25.BackgroundImage")));
            this.bunifuThinButton25.ButtonText = "Back";
            this.bunifuThinButton25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton25.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton25.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.IdleBorderThickness = 1;
            this.bunifuThinButton25.IdleCornerRadius = 30;
            this.bunifuThinButton25.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.bunifuThinButton25.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton25.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton25.Location = new System.Drawing.Point(419, 688);
            this.bunifuThinButton25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton25.Name = "bunifuThinButton25";
            this.bunifuThinButton25.Size = new System.Drawing.Size(120, 44);
            this.bunifuThinButton25.TabIndex = 30;
            this.bunifuThinButton25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton25.Click += new System.EventHandler(this.bunifuThinButton25_Click);
            // 
            // Moobile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 746);
            this.Controls.Add(this.bunifuThinButton25);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mobileDGV);
            this.Controls.Add(this.bunifuThinButton24);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.romcb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ramcb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stocktb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modeltb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brandtb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mobid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Moobile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Moobile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mobileDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Bunifu.Framework.UI.BunifuMaterialTextbox mobid;
		private Bunifu.Framework.UI.BunifuMaterialTextbox brandtb;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuMaterialTextbox modeltb;
		private System.Windows.Forms.Label label6;
		private Bunifu.Framework.UI.BunifuMaterialTextbox pricetb;
		private System.Windows.Forms.Label label7;
		private Bunifu.Framework.UI.BunifuMaterialTextbox stocktb;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ComboBox ramcb;
		private System.Windows.Forms.ComboBox romcb;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label11;
		private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
		private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
		private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
		private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
		private Guna.UI2.WinForms.Guna2DataGridView mobileDGV;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
	}
}