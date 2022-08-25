using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_class_2
{
    public class Product
    {
        static List<Product> p = new List<Product>();
        public String object_name { get; set; }
        public int number { get; set; }
        public string date { get; set; }
        public int inventory_number { get; set; }
        public int count { get; set; }
        public double price { get; set; }

        public bool is_available { get; set; }

        public bool chk_list { get; set; }
       // checkedListBox1

        public void save()
        {
            Console.WriteLine("saved");
            MessageBox.Show("saved");
            p.Add(this);
        }

        public static List<Product> getAll()
        {
            return p;  
        }

    }
    
}
