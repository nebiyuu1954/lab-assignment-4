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
    public partial class mainframe : Form
    {
        public mainframe()
        {
            InitializeComponent();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form active = this.ActiveMdiChild;
            if (active != null)
            {
                active.Close();
            }
            string x = "hjbhadbdjs";
            Form1 form1 = new Form1(x);

           form1.MdiParent = this; 

            form1.Show();
        }
    }
}
