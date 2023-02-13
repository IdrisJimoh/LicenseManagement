using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace License_Managment_Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "")
            { 
            MessageBox.Show("Username Field Empty, Please Type Your Username");
                return;
            }


            if (Textbox2.Text == "")
            {
                MessageBox.Show("Password Field Empty, Please Type Your Password");
                return;
            }

            if (TextBox1.Text == "anwab" && Textbox2.Text == "anwab")
            {
                MessageBox.Show("Login Details Correct, Press Enter Key To Continue");

                Dashboard mdashboard = new Dashboard();
                mdashboard.Show();
                this.Hide();

            }
        }
    }
}
