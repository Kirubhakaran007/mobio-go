using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mobile_Shop_Manager
{
	public partial class Accessories : Form
	{
		public Accessories()
		{
			InitializeComponent();
		}
		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\MobileShopDb.mdf;Integrated Security=True;Connect Timeout=30");

		private void populate()
		{
			Con.Open();
			String query = "select * from ATbl";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(da);
			var ds = new DataSet();
			da.Fill(ds);
			ADGV.DataSource = ds.Tables[0];
			Con.Close();
		}

		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
			if (Aidtb.Text == "" || Abrandtb.Text == "" || Amodeltb.Text == "" || Apricetb.Text == "" || Astocktb.Text == "")
			{
				MessageBox.Show("Missing Required Information!");
			}
			else
			{
				try
				{
					Con.Open();
					String sql = "insert into ATbl values(" + Aidtb.Text + ",'" + Abrandtb.Text + "','" + Amodeltb.Text + "'," + Apricetb.Text + "," + Astocktb.Text + ")";
					SqlCommand cmd = new SqlCommand(sql, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Accessories Added Successfully!");
					Con.Close();
					populate();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void Accessories_Load(object sender, EventArgs e)
		{
			populate();
		}

		private void label3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void bunifuThinButton24_Click(object sender, EventArgs e)
		{
			Aidtb.Text = "";
			Abrandtb.Text = "";
			Amodeltb.Text = "";
			Astocktb.Text = "";
			Apricetb.Text = "";
		}


		private void mobileDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void ADGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			Aidtb.Text = ADGV.SelectedRows[0].Cells[0].Value.ToString();
			Abrandtb.Text = ADGV.SelectedRows[0].Cells[1].Value.ToString();
			Amodeltb.Text = ADGV.SelectedRows[0].Cells[2].Value.ToString();
			Apricetb.Text = ADGV.SelectedRows[0].Cells[3].Value.ToString();
			Astocktb.Text = ADGV.SelectedRows[0].Cells[4].Value.ToString();
		}

		private void bunifuThinButton23_Click(object sender, EventArgs e)
		{
			if (Aidtb.Text == "")
			{

				MessageBox.Show("Enter The Accessories To Be Deleted!");
			}
			else
			{
				try
				{
					Con.Open();
					String query = "delete from ATbl where AId=" + Aidtb.Text + "";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Accessory Deleted!");
					Con.Close();
					populate();
				}
				catch (Exception Ex)
				{
					MessageBox.Show(Ex.Message);
				}
			}
		}

		private void bunifuThinButton22_Click(object sender, EventArgs e)
		{
			if (Aidtb.Text == "" || Abrandtb.Text == "" || Amodeltb.Text == "" || Apricetb.Text == "" || Astocktb.Text == "")
			{
				MessageBox.Show("Missing Required Information!");
			}
			else
			{
				try
				{
					Con.Open();
					String sql = "update ATbl set Abrand='" + Abrandtb.Text + "',AModel='" + Amodeltb.Text + "',APrice =" + Apricetb.Text + ",AStock =" + Astocktb.Text + " where AId=" + Aidtb.Text + ";";

					SqlCommand cmd = new SqlCommand(sql, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Accessories UPDATED Successfully!");
					Con.Close();
					populate();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void bunifuThinButton25_Click(object sender, EventArgs e)
		{
			Home home = new Home();
			home.Show();
			this.Hide();
		}
	}
}
