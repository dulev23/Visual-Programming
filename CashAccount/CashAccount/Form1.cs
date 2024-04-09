using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashAccount
{
    public partial class Form1 : Form
    {
        public Product Product;
        public Form1()
        {
            InitializeComponent();
            Product product1 = new Product(200,"Портокали",75);
            Product product2 = new Product(230,"Банани",54);
            lbProducts.Items.Add(product1);
            lbProducts.Items.Add(product2);
            
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNew addNew = new AddNew();
            if(addNew.ShowDialog() == DialogResult.OK)
            {
                foreach (object obj in lbProducts.Items)
                {
                    Product product = (Product)obj;
                    if(product.Code == addNew.Product.Code)
                    {
                        MessageBox.Show("Производ со овој код веќе постои");
                        return;
                    }
                }
                lbProducts.Items.Add(addNew.Product);
            }
        }

        private void btnAddToPaycheck_Click(object sender, EventArgs e)
        {
            Product selected = (Product)lbProducts.SelectedItem;
            Item item = new Item(selected,(int)nudQuantity.Value);
            lbPaycheck.Items.Add(item);
            calculateTotal();
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnAddToPaycheck.Enabled = lbProducts.SelectedIndex != -1;
            nudQuantity.Enabled = lbProducts.SelectedIndex != -1; 
        }

        void calculateTotal()
        {
            float total = 0;
            foreach (object obj in lbPaycheck.Items) 
            {
                Item item = (Item)obj;
                total += item.Price();
            }
            tbTotal.Text = string.Format("{0:0.00} ден",total);
            tbToPay.Text = string.Format("{0:0.00} ден",total * (float) (1+nudFee.Value / 100));
        }

        private void nudFee_ValueChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void btnDeletePaycheck_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Дали сте сигурни дека сакате да ја избришете ставката?", "Избриши ставка", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
           {
                lbPaycheck.Items.RemoveAt(lbPaycheck.SelectedIndex);
                calculateTotal();
           }
        }

        private void lbPaycheck_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeletePaycheck.Enabled=lbPaycheck.SelectedIndex != -1;
        }
    }
}
