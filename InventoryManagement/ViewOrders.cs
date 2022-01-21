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
    }
}//END
