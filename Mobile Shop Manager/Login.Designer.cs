namespace Mobile_Shop_Manager
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.UidTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.PassTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
			this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.label1.Location = new System.Drawing.Point(151, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 36);
			this.label1.TabIndex = 3;
			this.label1.Text = "MOBIO GO 1.0";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(202, 92);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(118, 68);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// UidTb
			// 
			this.UidTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.UidTb.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UidTb.ForeColor = System.Drawing.Color.Black;
			this.UidTb.HintForeColor = System.Drawing.Color.Empty;
			this.UidTb.HintText = "";
			this.UidTb.isPassword = false;
			this.UidTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.UidTb.LineIdleColor = System.Drawing.SystemColors.Highlight;
			this.UidTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.UidTb.LineThickness = 4;
			this.UidTb.Location = new System.Drawing.Point(206, 220);
			this.UidTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.UidTb.Name = "UidTb";
			this.UidTb.Size = new System.Drawing.Size(267, 25);
			this.UidTb.TabIndex = 5;
			this.UidTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.UidTb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
			// 
			// PassTb
			// 
			this.PassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PassTb.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PassTb.ForeColor = System.Drawing.Color.Black;
			this.PassTb.HintForeColor = System.Drawing.Color.Empty;
			this.PassTb.HintText = "";
			this.PassTb.isPassword = false;
			this.PassTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.PassTb.LineIdleColor = System.Drawing.SystemColors.Highlight;
			this.PassTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.PassTb.LineThickness = 4;
			this.PassTb.Location = new System.Drawing.Point(206, 280);
			this.PassTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.PassTb.Name = "PassTb";
			this.PassTb.Size = new System.Drawing.Size(267, 25);
			this.PassTb.TabIndex = 6;
			this.PassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.PassTb.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
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
			this.bunifuThinButton21.ButtonText = "Login";
			this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuThinButton21.ForeColor = System.Drawing.Color.White;
			this.bunifuThinButton21.IdleBorderThickness = 1;
			this.bunifuThinButton21.IdleCornerRadius = 30;
			this.bunifuThinButton21.IdleFillColor = System.Drawing.SystemColors.Highlight;
			this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
			this.bunifuThinButton21.Location = new System.Drawing.Point(177, 362);
			this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.bunifuThinButton21.Name = "bunifuThinButton21";
			this.bunifuThinButton21.Size = new System.Drawing.Size(163, 44);
			this.bunifuThinButton21.TabIndex = 7;
			this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(56, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(87, 29);
			this.label3.TabIndex = 9;
			this.label3.Text = "User ID";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Corbel", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(56, 275);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 29);
			this.label2.TabIndex = 10;
			this.label2.Text = "Password";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(215, 422);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 28);
			this.label4.TabIndex = 11;
			this.label4.Text = "clear";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Red;
			this.label9.Location = new System.Drawing.Point(470, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(26, 25);
			this.label9.TabIndex = 50;
			this.label9.Text = "X";
			this.label9.UseMnemonic = false;
			this.label9.Click += new System.EventHandler(this.label9_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(508, 470);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.bunifuThinButton21);
			this.Controls.Add(this.PassTb);
			this.Controls.Add(this.UidTb);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Bunifu.Framework.UI.BunifuMaterialTextbox UidTb;
		private Bunifu.Framework.UI.BunifuMaterialTextbox PassTb;
		private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
	}
}