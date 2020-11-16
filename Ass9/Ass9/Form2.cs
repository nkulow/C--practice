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
    public partial class Form2 : Form
    {

        SortedList<string, double> productList = new SortedList<string, double>();

        //private SortedList<string, double> _mylist = new SortedList<string, double>();
        //public SortedList<string, double> productList { get { return _mylist; } set { _mylist = value; } }
        public Form2()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);

        }

        private void productNameTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            productNameTextBox.DoDragDrop(productNameTextBox.Text, DragDropEffects.Copy);
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            double unitPrice;

            //listBox1.Items.Add(e.Data.GetData(DataFormats.Text));
            if (listBox1.Items.Contains(productNameTextBox.Text))
            {
                MessageBox.Show("Product has already been added to list");
            }
            else
            {
                if (Double.TryParse(unitPriceLabel1.Text, out unitPrice))
                {
                    listBox1.Items.Add(e.Data.GetData(DataFormats.Text));
                    productList.Add(productNameTextBox.Text, unitPrice);
                }
            }
        }

        private void checkoutBtn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.productList = productList;
            f3.ShowDialog();
        }
    }
}
