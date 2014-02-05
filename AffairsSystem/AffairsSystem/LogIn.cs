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
            Boolean admin = Utility.CheckAdmin(da2);
            SqlDataReader da3 = controller.SearchSalesPerson(spNr);
            String name = Utility.GetSalesPersonName(da3);
            

            if (spNr.Equals(spNr2))
            {
                Form1 Form1 = new Form1(spNr, name, controller, admin);
                Form1.Show();
                this.Hide();
            }
            else
            {
                textBoxspNr.Text = "";
            }

        }

        private void textBoxspNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnLogIn.PerformClick();
            }
        }

        private void LogIn_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 4),
                            this.DisplayRectangle);                                     

        }
        

            
        }
    }

