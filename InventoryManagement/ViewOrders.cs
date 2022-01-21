using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagement
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\casa\Inventorydb.mdf;Integrated Security=True; Connect Timeout=30");

        void populateorders()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                OrderGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void ViewOders_Load(object sender, EventArgs e)
        {
            populateorders();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order summary", new Font("Century",25,FontStyle.Bold),Brushes.Red,new Point(230));
            e.Graphics.DrawString("Order Id: " + OrderGv.SelectedRows[0].Cells[0].Value.ToString(), new Font("Century",25,FontStyle.Regular), Brushes.Black, new Point(80,100));
            e.Graphics.DrawString("Customer Id: " + OrderGv.SelectedRows[0].Cells[1].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 133));
            e.Graphics.DrawString("Customer Name: " + OrderGv.SelectedRows[0].Cells[2].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("Order date: " + OrderGv.SelectedRows[0].Cells[3].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 199));
            e.Graphics.DrawString("Customer Id: " + OrderGv.SelectedRows[0].Cells[4].Value.ToString(), new Font("Century", 25, FontStyle.Regular), Brushes.Black, new Point(80, 232));
            e.Graphics.DrawString("PoweredByPETV", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230,350));
        }

    }
}//END
