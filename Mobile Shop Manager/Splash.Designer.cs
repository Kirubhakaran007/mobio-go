namespace Mobile_Shop_Manager
{
	partial class Splash
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
			this.BProgressBar1 = new Guna.UI2.WinForms.Guna2VProgressBar();
			this.AProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// BProgressBar1
			// 
			this.BProgressBar1.FillColor = System.Drawing.Color.DimGray;
			this.BProgressBar1.ForeColor = System.Drawing.Color.Violet;
			this.BProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.BProgressBar1.Location = new System.Drawing.Point(29, 1);
			this.BProgressBar1.Name = "BProgressBar1";
			this.BProgressBar1.ProgressColor = System.Drawing.Color.WhiteSmoke;
			this.BProgressBar1.ProgressColor2 = System.Drawing.Color.WhiteSmoke;
			this.BProgressBar1.ShadowDecoration.Parent = this.BProgressBar1;
			this.BProgressBar1.Size = new System.Drawing.Size(10, 291);
			this.BProgressBar1.TabIndex = 0;
			this.BProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.BProgressBar1.ValueChanged += new System.EventHandler(this.BProgressBar1_ValueChanged);
			// 
			// AProgressBar1
			// 
			this.AProgressBar1.FillColor = System.Drawing.Color.DimGray;
			this.AProgressBar1.ForeColor = System.Drawing.Color.Violet;
			this.AProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
			this.AProgressBar1.Location = new System.Drawing.Point(-3, 251);
			this.AProgressBar1.Name = "AProgressBar1";
			this.AProgressBar1.ProgressColor = System.Drawing.Color.WhiteSmoke;
			this.AProgressBar1.ProgressColor2 = System.Drawing.Color.WhiteSmoke;
			this.AProgressBar1.ShadowDecoration.Parent = this.AProgressBar1;
			this.AProgressBar1.Size = new System.Drawing.Size(653, 10);
			this.AProgressBar1.TabIndex = 1;
			this.AProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(193, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(282, 42);
			this.label1.TabIndex = 2;
			this.label1.Text = "MOBIO GO 1.0";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(231, 114);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(186, 94);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Splash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.ClientSize = new System.Drawing.Size(651, 289);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AProgressBar1);
			this.Controls.Add(this.BProgressBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Splash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Splash_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2VProgressBar BProgressBar1;
		private Guna.UI2.WinForms.Guna2ProgressBar AProgressBar1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Timer timer1;
	}
}

