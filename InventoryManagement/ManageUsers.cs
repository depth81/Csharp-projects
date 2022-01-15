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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\casa\Documents\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");

      

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                Con.Open();
                string MyQuery = "SELECT * FROM UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(MyQuery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGv.DataSource = ds.Tables[0];
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
                SqlCommand cmd = new SqlCommand("INSERT INTO UserTbl VALUES('" + UnameTb.Text + "','" + FnameTb.Text + "', '" + PasswordTb.Text + "','" + PhoneTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User succesfully added");
                Con.Close();
                populate();
            }
            catch
            {

            }
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PhoneTb.Text == "")
            {
                MessageBox.Show("Enter the user's phone number");
            }
            else
            {
                Con.Open();
                string myQuery = "DELETE FROM UserTbl WHERE UPhone = '"+ PhoneTb.Text + "';";
                SqlCommand cmd = new SqlCommand(myQuery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The user has been succesfully deleted");
                Con.Close();
                populate();
            }
        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsersGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);

            MessageBox.Show(selectedRowCount.ToString());
            if (selectedRowCount > 0)
            {
                

                UnameTb.Text = UsersGv.SelectedRows[0].Cells[0].Value.ToString();
                //UnameTb.Text = UsersGv.Rows[0].Cells[0].Value.ToString();
                //FnameTb.Text = UsersGv.SelectedRows[0].Cells[1].Value.ToString();
                FnameTb.Text = UsersGv.Rows[0].Cells[1].Value.ToString();
                //PasswordTb.Text = UsersGv.SelectedRows[0].Cells[2].Value.ToString();
                PasswordTb.Text = UsersGv.Rows[0].Cells[2].Value.ToString();
                //PhoneTb.Text = UsersGv.SelectedRows[0].Cells[3].Value.ToString();
                PhoneTb.Text = UsersGv.Rows[0].Cells[3].Value.ToString();


            }
}

        }
    }
}
