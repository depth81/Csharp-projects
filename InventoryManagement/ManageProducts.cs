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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\casa\Inventorydb.mdf;Integrated Security=True; Connect Timeout=30");

        void fillCategory()
        {
            string query = "SELECT * FROM CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName",typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        void fillSearchCombo()
        {
            string query = "SELECT * FROM CategoryTbl where CatName = '" + SearchCombo.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource = dt;
                //SearchCombo.ValueMember = "CatName";
                //SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillCategory();
            populate();
        }

        void populate()
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

        void filterbycategory()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM ProductTbl WHERE ProdCat='"+SearchCombo.SelectedValue.ToString()+"'";
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



        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ProductTbl VALUES('" + ProdIdTb.Text + "','" + ProdNameTb.Text + "','" + ProdQtyTb.Text + "','" + ProdPriceTb.Text + "' ,'" + ProdDescTb.Text + "' ,'" + CatCombo.SelectedValue.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product succesfully added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ProdIdTb.Text == "")
            {
                MessageBox.Show("Enter the product's ID");
            }
            else
            {
                Con.Open();
                string myQuery = "DELETE FROM ProductTbl WHERE ProdId = '" + ProdIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The product has been succesfully deleted");
                Con.Close();
                populate();
            }
        }

        private void ProductsGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ProductsGv.SelectedRows.Count > 0)
                {
                    ProdIdTb.Text = ProductsGv.SelectedRows[0].Cells[0].Value.ToString();
                    ProdNameTb.Text = ProductsGv.SelectedRows[0].Cells[1].Value.ToString();
                    ProdQtyTb.Text = ProductsGv.SelectedRows[0].Cells[2].Value.ToString();
                    ProdPriceTb.Text = ProductsGv.SelectedRows[0].Cells[3].Value.ToString();
                    ProdDescTb.Text = ProductsGv.SelectedRows[0].Cells[4].Value.ToString();
                    CatCombo.SelectedValue = ProductsGv.SelectedRows[0].Cells[5].Value.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ProductTbl SET ProdName = '" + ProdNameTb.Text + "', ProdQty ='" + ProdQtyTb.Text + "', ProdPrice ='" + ProdPriceTb.Text + "', ProdDesc ='" + ProdDescTb.Text + "' , ProdCat ='" + CatCombo.SelectedValue.ToString() + "' WHERE ProdId = '" + ProdIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product succesfully updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterbycategory();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
