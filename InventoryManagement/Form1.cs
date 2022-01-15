using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


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


    }
}
