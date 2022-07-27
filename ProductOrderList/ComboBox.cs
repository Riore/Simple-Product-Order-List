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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string combo = comboBox1.Text;
            string text = txtbox.Text;
            lblD.Text = combo + text;
            if (txtbox.Text == "")
            {
                lblD.Text = "";
                MessageBox.Show("Enter your number");
                txtbox.Focus();
            }
            if (comboBox1.SelectedText == "")
            {
                lblD.Text = "";
            }
            else
            {
                MessageBox.Show("Please Select one");
            }



        }
    }
}
