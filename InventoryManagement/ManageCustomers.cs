using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\casa\Inventorydb.mdf;Integrated Security=True; Connect Timeout=30");

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
                CustomersGv.DataSource = ds.Tables[0];
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
                SqlCommand cmd = new SqlCommand("INSERT INTO CustomerTbl VALUES('" + CustomerIDTb.Text + "','" + CustomerNameTb.Text + "','" + CustomerPhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer succesfully added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CustomerIDTb.Text == "")
            {
                MessageBox.Show("Enter the customer's ID");
            }
            else
            {
                Con.Open();
                string myQuery = "DELETE FROM CustomerTbl WHERE CustID = '" + CustomerIDTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The customer has been succesfully deleted");
                Con.Close();
                populate();
            }
        }

        private void CustomersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (CustomersGv.SelectedRows.Count > 0)
            {
                CustomerIDTb.Text = CustomersGv.SelectedRows[0].Cells[0].Value.ToString();
                CustomerNameTb.Text = CustomersGv.SelectedRows[0].Cells[1].Value.ToString();
                CustomerPhoneTb.Text = CustomersGv.SelectedRows[0].Cells[2].Value.ToString();
                
                Con.Open();
                
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM OrderTbl WHERE CustId = " + CustomerIDTb.Text + "", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                OrderLabel.Text = dt.Rows[0][0].ToString();

                SqlDataAdapter sda1 = new SqlDataAdapter("SELECT SUM(TotalAmt) FROM OrderTbl WHERE CustId = " + CustomerIDTb.Text + "", Con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                OrderLabel.Text = dt.Rows[0][0].ToString();

                Con.Close();
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CustomerTbl SET CustName = '" + CustomerNameTb.Text + "', CustPhone ='" + CustomerPhoneTb.Text + "' WHERE CustID = '" + CustomerIDTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer succesfully updated");
                Con.Close();
                populate();
            }
            catch
            {

            }

        }
    }
}
