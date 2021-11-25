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
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}

		private void bunifuThinButton22_Click(object sender, EventArgs e)
		{
			Moobile hi = new Moobile();
			hi.Show();
			this.Hide();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
			Accessories home = new Accessories();
			home.Show();
			this.Hide();
		}

		private void bunifuThinButton23_Click(object sender, EventArgs e)
		{
			Selling home = new Selling();
			home.Show();
			this.Hide();
		}

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
