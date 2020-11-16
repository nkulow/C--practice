using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass9
{
    public partial class Form3 : Form
    {
        private SortedList<string, double> _mylist = new SortedList<string, double>();
        public SortedList<string, double> productList { get { return _mylist; } set { _mylist = value; } }

        double totalPrice = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, double> p in productList)
            {
                productListBox.Items.Add(p.Key + " (" + p.Value.ToString("c") + ")");
                totalPrice += p.Value;
            }

            totalPriceLabel.Text = totalPrice.ToString("c");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
