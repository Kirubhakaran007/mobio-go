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
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}

		private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void Login_Load(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{
			UidTb.Text = " ";
			PassTb.Text = " ";
		}

		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
			if(UidTb.Text == "" || PassTb.Text == "")
			{
				MessageBox.Show("Both Username And Password Required!");
			}
			else if(UidTb.Text == "Kirubha" && PassTb.Text == "KNN@123")
			{
				Home home = new Home();
				home.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Incorrect Username or Password");
			}
		}

		private void label9_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
