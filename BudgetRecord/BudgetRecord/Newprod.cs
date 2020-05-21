using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace BudgetRecord
{
    public partial class Newprod : Form
    {
        int amount = 1;
        String category = "";
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "docfvAZ6qQX66j3L9n7i0doi4j3wa5mhFKIbs0yE",
            BasePath = "https://budgetrecords-7ae17.firebaseio.com/"
        };

        IFirebaseClient client;
        public Newprod()
        {
            InitializeComponent();
        }

        private void Newprod_Load(object sender, EventArgs e)
        {

        }

        private void prod_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (prod_btn.Checked)
            {
                amount_label.Visible = true;
                amount_textbox.Visible = true;
                category = "Termék";
                amount = Int32.Parse(amount_textbox.Text);
            }
            else
            {
                amount_label.Visible = false;
                amount_textbox.Visible = false;
                category = "Szolgáltatás";
            }

        }

        //private async void button1_Click(object sender, EventArgs e)
        //{
        //    //var newData = new Expense
        //    //{
        //    //    ID = 0,
        //    //    Name = name_textbox.Text,
        //    //    Location = loc_textbox.Text,
        //    //    Category = category,
        //    //    Price = price_textbox,
        //    //    amount = amount

        //    //};
        //}
    }
}
