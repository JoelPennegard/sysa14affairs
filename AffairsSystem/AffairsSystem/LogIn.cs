using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AffairsSystem
{
    public partial class LogIn : Form
    {
        Controller controller;
        public LogIn()
        {
            controller = new Controller();
            InitializeComponent();
           
        }
        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        // CLICK ON LOG IN
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string spNr = textBoxspNr.Text;
            SqlDataReader da = controller.SearchSalesPerson(spNr);
            string spNr2 = Utility.CheckSalesPerson(da);
            SqlDataReader da2 = controller.SearchSalesPerson(spNr);
            Boolean admin = UtilityAdminCheck.Check(da2);
            

            if (spNr.Equals(spNr2))
            {
                Form1 Form1 = new Form1(spNr, controller, admin);
                Form1.Show();
                this.Hide();
            }
            

        }

            
        }
    }

