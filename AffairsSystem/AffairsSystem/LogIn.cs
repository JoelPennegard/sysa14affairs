using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
    }
}
