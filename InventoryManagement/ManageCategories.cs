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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\casa\Inventorydb.mdf;Integrated Security=True; Connect Timeout=30");

        void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM CategoryTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CategoriesGv.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO CategoryTbl VALUES('" + CatIdTb.Text + "','" + CatNameTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category succesfully added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CatIdTb.Text == "")
            {
                MessageBox.Show("Enter the category's ID");
            }
            else
            {
                Con.Open();
                string myQuery = "DELETE FROM CategoryTbl WHERE CatID = '" + CatIdTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The category has been succesfully deleted");
                Con.Close();
                populate();
            }
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CategoryTbl SET CatName = '" + CatNameTb.Text + "' WHERE CatID = '" + CatIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category succesfully updated");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void CategoriesGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (CategoriesGv.SelectedRows.Count > 0)
                {
                    CatIdTb.Text = CategoriesGv.SelectedRows[0].Cells[0].Value.ToString();
                    CatNameTb.Text = CategoriesGv.SelectedRows[0].Cells[1].Value.ToString();
                  
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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
