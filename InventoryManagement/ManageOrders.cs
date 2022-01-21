using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace InventoryManagement
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\casa\Inventorydb.mdf;Integrated Security=True; Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        void populateproducts()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        void fillCategory()
        {
            string query = "SELECT * FROM CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                //CatCombo.ValueMember = "CatName";
                //CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        void updateproduct()
        {
            Con.Open();
            int id = Convert.ToInt32(ProductsGv.SelectedRows[0].Cells[0].Value.ToString()); 
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            string query = "UPDATE ProductTbl set ProdQty = " + newQty + " WHERE ProdId = " + id + ";";
            SqlCommand cmd = new SqlCommand(query,Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            populateproducts();
        }

        int num = 0;
        int uprice, totprice, qty;
        string product;

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateproducts();
            fillCategory();

        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           CustIdTb.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
           CustNameTb.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();

        }

        
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM ProductTbl WHERE ProdCat='" + SearchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        int flag = 0;
        int sum = 0;
        int stock;

        private void ProductsGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ProductsGv.SelectedRows.Count > 0)
                {
                    product = ProductsGv.SelectedRows[0].Cells[1].Value.ToString();
                    stock = Convert.ToInt32(ProductsGv.SelectedRows[0].Cells[2].Value.ToString());
                    uprice = Convert.ToInt32(ProductsGv.SelectedRows[0].Cells[3].Value.ToString());
                    flag = 1;
                }
                else
                {
                    MessageBox.Show("No rows selected");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        DataTable table = new DataTable();

        private void totAmTb_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(OrderIdTb.Text == "" || CustIdTb.Text == "" || CustNameTb.Text == "" || TotAmount.Text == "")
            {
                MessageBox.Show("Please fill the data correctly");
            }
            else if(OrderIdTb.Text == "OrderId")
            {
                MessageBox.Show("Insert an order id");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO OrderTbl VALUES('" + OrderIdTb.Text + "','" + CustIdTb.Text + "','" + CustNameTb.Text + "','" + Convert.ToDateTime(orderdate.Text) + "', '" + Convert.ToInt32(TotAmount.Text) + "');", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order succesfully added");
                Con.Close();
                //populate();
                try
                {

                }
                catch
                {

                }
  
            }
        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (QtyTb.Text == ""){
                MessageBox.Show("Enter the quantity of products");
            }
            else if(flag == 0)
            {
                MessageBox.Show("Select the product");
            }
            else if(Convert.ToInt32(QtyTb.Text) > stock){
                MessageBox.Show("Not enough stock available");
            }
            else
            {
                if(table.Columns.Count == 0)
                {
                    table.Columns.Add("Num", typeof(int));//datatype int
                    table.Columns.Add("Product", typeof(string));//datatype string
                    table.Columns.Add("Quantity", typeof(int));//datatype string
                    table.Columns.Add("UPrice", typeof(int));//datatype string
                    table.Columns.Add("Totprice", typeof(int));//datatype datetype int
                }
                
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * uprice;
                table.Rows.Add(num, product, qty, uprice, totprice);
                OrderGv.DataSource = table;
                flag = 0;
            }

            sum = sum + totprice;
            TotAmount.Text = sum.ToString();
            updateproduct();
        }

        private void ProdIdTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
