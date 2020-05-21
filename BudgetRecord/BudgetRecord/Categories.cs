using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetRecord
{
    public partial class Categories : Form
    {
        Newprod addProd = new Newprod();
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Load(object sender, EventArgs e)
        {
            cat_combobox.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Categories_FormClosed(object sender, FormClosedEventArgs e)
        {
            sender = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!addProd.Visible)
            {
                addProd.Show();
            }
            else addProd.BringToFront();
        }
    }
}
