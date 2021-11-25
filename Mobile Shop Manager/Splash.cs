using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Shop_Manager
{
	public partial class Splash : Form
	{
		public Splash()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
		int startpoint = 15;
		private void timer1_Tick(object sender, EventArgs e)
		{
			startpoint += 2;
			AProgressBar1.Value = startpoint;
			BProgressBar1.Value = startpoint;
			if(AProgressBar1.Value == 100)
			{
				AProgressBar1.Value = 0;
				BProgressBar1.Value = 0;
				timer1.Stop();
				Login log = new Login();
				log.Show();
				this.Hide();
			}

		}

		private void Splash_Load(object sender, EventArgs e)
		{
			timer1.Start();
		}

		private void BProgressBar1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
