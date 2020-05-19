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
    public partial class Greetings : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "docfvAZ6qQX66j3L9n7i0doi4j3wa5mhFKIbs0yE",
            BasePath = "https://budgetrecords-7ae17.firebaseio.com/"
        };

        IFirebaseClient client;
        public Greetings()
        {
            InitializeComponent();
        }

        private void Greetings_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            //if (client != null)
            //{
            //    MessageBox.Show("Adatbáziskapcsolat sikeresen létrehozva!");
            //}
        }
    }
}
