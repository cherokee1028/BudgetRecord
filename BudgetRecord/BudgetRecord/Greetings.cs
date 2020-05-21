using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace BudgetRecord
{

    public partial class Greetings : Form
    {
        Categories catForm = new Categories();
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = ConfigurationManager.AppSettings["Authentication"],
            BasePath = ConfigurationManager.AppSettings["Basepath"]
        };

        IFirebaseClient client;
        public Greetings()
        {
            InitializeComponent();
        }

        private void Greetings_Load(object sender, EventArgs e)
        {

            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Adatbáziskapcsolat sikeresen létrehozva!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!catForm.Visible)
            {
                catForm.Show();
            }
            else
            {
                catForm.BringToFront();
            }
       
        }

    }
}
