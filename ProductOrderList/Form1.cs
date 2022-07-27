using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductOrderList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        } 
         
        private void btnEnter_Click(object sender, EventArgs e)
        {   
            string category = txtCategory.Text;
            int quantity = int.Parse(txtQuantity.Text);
            int Amount = int.Parse(txtAmount.Text);
            int totalAmount = quantity * Amount;
            string brand = "";
            if (category == "")
            {
                MessageBox.Show("Require Category Name", "Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (rdoAsus.Checked)
            {
                brand = "Asus";
            }
            else if (rdoDell.Checked)
            {
                brand = "Dell";
            }
            else if (rdoLenovo.Checked)
            {
                brand = "Lenovo";
            }
            else if (rdoMac.Checked)
            {
                brand = "Mac";
            }
            else if (rdomsi.Checked)
            {
                brand = "Msi";
            }
            else
            {
                MessageBox.Show("Select one Brand", "Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }          
            
            lblDis.Text = "Brand:" + brand + "\n"+ "\n" + "Category: " + category + "\n"+ "\n" + "Quantity: " + quantity + "\n"+ "\n" + "Amount: " + Amount + "\n" +"\n" + "Total Price: " + totalAmount;           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "";
            txtCategory.Text = "";
            txtQuantity.Text = "";
            lblDis.Text = "" ;
        }
    }
}
