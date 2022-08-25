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
    public partial class Form1 : Form
    {
        public Form1(string x)
        {
            InitializeComponent();
        }

        private void addlbl_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            
                try
                {
                    p.number = int.Parse(tbx_number.Text);
                    p.inventory_number = int.Parse(tbx_invnum.Text);
                    p.count = int.Parse(tbx_count.Text);
                    p.price = int.Parse(tbx_price.Text);
                    p.object_name = tbx_name.Text;
                    p.date = dtp.Text;
                    p.is_available = chk_avail.Checked;
                
                }
                catch {
                    MessageBox.Show("Invalid Input!");
                    return;
                }
            

            
                
            

            p.save();
            dgv.DataSource = null;
            dgv.DataSource = Product.getAll();
            MessageBox.Show($"product{p.number} succesfully added");

        }

        private void cancellbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int x;
            
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
