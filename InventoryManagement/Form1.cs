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

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\casa\Inventorydb.mdf;Integrated Security=True; Connect Timeout=30");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PasswordTb.PasswordChar = '\0';
            }
            else
            {
                PasswordTb.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            uNameTb.Text = "";
            PasswordTb.Text = "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select COUNT(*) FROM USerTbl WHERE Uname = '"+ uNameTb.Text + "' and uPassword ='"+ PasswordTb.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                ManageCustomers cust = new ManageCustomers();
                cust.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong user/password combination");
            }
            Con.Close();
        }
    }
}
