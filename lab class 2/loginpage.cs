using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_class_2
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            label1.Text = username;

            if (username == "neba" && password == "okay")
            {
                Form1 form1 = new Form1(username);
                form1.Visible = true;
            }
            else
            {
                MessageBox.Show("invalid password or username");
            }

        }
    }
}
