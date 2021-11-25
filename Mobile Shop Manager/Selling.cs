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
	public partial class Selling : Form
	{
		public Selling()
		{
			InitializeComponent();
		}

		SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\MobileShopDb.mdf;Integrated Security=True;Connect Timeout=30");

		private void populate()
		{
			Con.Open();
			String query = "select Mbrand,MModel,MPrice from MobileTbl";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(da);
			var ds = new DataSet();
			da.Fill(ds);
			mobileDGV.DataSource = ds.Tables[0];
			Con.Close();
		}
		private void populateAccess()
		{
			Con.Open();
			String query = "select ABrand,AModel,APrice from ATbl";
			SqlDataAdapter da = new SqlDataAdapter(query, Con);
			SqlCommandBuilder builder = new SqlCommandBuilder(da);
			var ds = new DataSet();
			da.Fill(ds);
			ADGV.DataSource = ds.Tables[0];
			Con.Close();
		}

		private void insertbill()
		{
			if (BillIdTb.Text == "" || clientTb.Text == "")
			{
				MessageBox.Show("Missing Required Information!");
			}
			else
			{
				try
				{
					int amount = Convert.ToInt32(AmtTb.Text);
					Con.Open();
					String sql = "insert into BillTbl values ("+BillIdTb.Text+",'"+clientTb.Text+"',"+ amount +")";
					SqlCommand cmd = new SqlCommand(sql, Con);
					cmd.ExecuteNonQuery();
					Con.Close();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void Selling_Load(object sender, EventArgs e)
		{
	 		populate();
			populateAccess();
			sum();
		}
		private void sum()
		{
			String query = "select sum(Amt) from BillTbl";
			Con.Open();
			SqlDataAdapter sda = new SqlDataAdapter(query,Con);
			DataTable dt = new DataTable();
			sda.Fill(dt);
			sellamttb.Text = dt.Rows[0][0].ToString();
			Con.Close();
		}

		private void mobid_OnValueChanged(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		

		private void mobileDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			productt.Text = mobileDGV.SelectedRows[0].Cells[0].Value.ToString() + mobileDGV.SelectedRows[0].Cells[1].Value.ToString();
			pricee.Text = mobileDGV.SelectedRows[0].Cells[2].Value.ToString();
		}
		int prodid, prodqty, prodprice, prodpricee, tota,pos = 60;
		String prodname; 
		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void ADGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			productt.Text = ADGV.SelectedRows[0].Cells[0].Value.ToString() + ADGV.SelectedRows[0].Cells[1].Value.ToString();
			pricee.Text = ADGV.SelectedRows[0].Cells[2].Value.ToString();
		}

		private void bunifuThinButton25_Click(object sender, EventArgs e)
		{
			Home home = new Home();
			home.Show();
			this.Hide();
		}

		int n = 0, grdtotal = 0;

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawString("MOBIO GO 1.0", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Red, new Point(90, 15));
			e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Red, new Point(26, 40));
			foreach (DataGridViewRow row in BillDGV.Rows)
			{
				prodid = Convert.ToInt32(row.Cells["Column1"].Value);
				prodname = "" + row.Cells["Column2"].Value;
				prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
				prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
				tota = Convert.ToInt32(row.Cells["Column5"].Value);
				e.Graphics.DrawString("" + prodid, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
				e.Graphics.DrawString("" + prodname, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
				e.Graphics.DrawString("" + prodprice, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
				e.Graphics.DrawString("" + prodqty, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
				e.Graphics.DrawString("" + tota, new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
				pos += 20;
			}
			e.Graphics.DrawString("Grand Total: Rs." + grdtotal, new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50));
			e.Graphics.DrawString("**********Mobio Go************", new Font("Century Gothic", 12, FontStyle.Bold), Brushes.Crimson, new Point(10, pos + 85));
			BillDGV.Rows.Clear();
			BillDGV.Refresh();
			pos = 100;
			grdtotal = 0;
			n = 0;
			insertbill();
			sum();
		}

		private void bunifuThinButton22_Click(object sender, EventArgs e)
		{
			printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
			if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}

		private void printPreviewDialog1_Load(object sender, EventArgs e)
		{

		}

		private void bunifuThinButton21_Click_1(object sender, EventArgs e)
		{
			if (Qty.Text == "" || pricee.Text == "")
			{
				MessageBox.Show("Enter the Quantity!");
			}
			else
			{
				int total = Convert.ToInt32(Qty.Text) * Convert.ToInt32(pricee.Text);
				DataGridViewRow newrow = new DataGridViewRow();
				newrow.CreateCells(BillDGV);
				newrow.Cells[0].Value = n + 1;
				newrow.Cells[1].Value = productt.Text;
				newrow.Cells[2].Value = pricee.Text;
				newrow.Cells[3].Value = Qty.Text;
				newrow.Cells[4].Value = total;
				BillDGV.Rows.Add(newrow);
				n++;
				grdtotal = grdtotal + total;
				AmtTb.Text = ""+grdtotal;
			}
		}
	}
}
