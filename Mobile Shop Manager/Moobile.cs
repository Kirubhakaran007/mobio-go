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
	public partial class Moobile : Form
	{
		public Moobile()
		{
			InitializeComponent();
		}

		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\MobileShopDb.mdf;Integrated Security=True;Connect Timeout=30");

		private void label3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void populate()
		{
			Con.Open();
			String query = "select * from MobileTbl";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(da);
			var ds = new DataSet();
			da.Fill(ds);
			mobileDGV.DataSource = ds.Tables[0];
			Con.Close();
		}

		private void UidTb_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void Moobile_Load(object sender, EventArgs e)
		{
			populate();
		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void bunifuThinButton21_Click(object sender, EventArgs e)
		{
			if(mobid.Text == "" || brandtb.Text == "" || modeltb.Text == "" || pricetb.Text == "" || stocktb.Text == "")
			{
				MessageBox.Show("Missing Required Information!");
			}
			else
			{
				try
				{
					Con.Open();
					String sql = "insert into MobileTbl values(" +mobid.Text+ ",'"+brandtb.Text+"','"+modeltb.Text+"',"+pricetb.Text+","+stocktb.Text+","+ramcb.SelectedItem.ToString()+","+romcb.SelectedItem.ToString()+")";
					SqlCommand cmd = new SqlCommand(sql, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Mobile Added Successfully!");
					Con.Close();
					populate();
				}catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void mobileDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			mobid.Text = mobileDGV.SelectedRows[0].Cells[0].Value.ToString();
			brandtb.Text = mobileDGV.SelectedRows[0].Cells[1].Value.ToString();
			modeltb.Text = mobileDGV.SelectedRows[0].Cells[2].Value.ToString();
			pricetb.Text = mobileDGV.SelectedRows[0].Cells[3].Value.ToString();
			stocktb.Text = mobileDGV.SelectedRows[0].Cells[4].Value.ToString();
			ramcb.SelectedItem = mobileDGV.SelectedRows[0].Cells[5].Value.ToString();
			romcb.SelectedItem = mobileDGV.SelectedRows[0].Cells[6].Value.ToString();

		}

		private void bunifuThinButton24_Click(object sender, EventArgs e)
		{
			mobid.Text = "";
			brandtb.Text = "";
			modeltb.Text = "";
			pricetb.Text = "";
			stocktb.Text = "";
			ramcb.SelectedItem = "";
			romcb.SelectedItem = "";
		}

		private void bunifuThinButton23_Click(object sender, EventArgs e)
		{
			if(mobid.Text == "")
			{

				MessageBox.Show("Enter The Mobile To Be Deleted!");
			}
			else
			{
				try
				{
					Con.Open();
					String query = "delete from MobileTbl where mobid=" + mobid.Text + "";
					SqlCommand cmd = new SqlCommand(query, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Mobile Deleted!");
					Con.Close();
					populate();
				}
				catch (Exception Ex)
				{
					
				}
			}
		}

		private void bunifuThinButton22_Click(object sender, EventArgs e)
		{
			if (mobid.Text == "" || brandtb.Text == "" || modeltb.Text == "" || pricetb.Text == "" || stocktb.Text == "")
			{
				MessageBox.Show("Missing Required Information!");
			}
			else
			{
				try
				{
					Con.Open();
					String sql = "update MobileTbl set Mbrand='"+brandtb.Text+"',MModel='"+modeltb.Text+"',MPrice ="+pricetb.Text+",MStock ="+stocktb.Text+",MRam ="+ramcb.SelectedItem.ToString()+",MRom ="+romcb.SelectedItem.ToString()+" where MobId="+mobid.Text+";";

					SqlCommand cmd = new SqlCommand(sql, Con);
					cmd.ExecuteNonQuery();
					MessageBox.Show("Mobile UPDATED Successfully!");
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
