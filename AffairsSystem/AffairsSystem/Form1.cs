﻿using System;
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
    public partial class Form1 : Form
    {
        private string spNr = "";
        private Controller controller;

        
        public Form1(string spNr, Controller controller, Boolean Admin)
        {
            InitializeComponent();
            this.controller = controller;
            this.spNr = spNr;
            FillProductTable();
            FillProductTableAdmin();

            
          
            


           // if (Admin) { tabControl.Enabled = true; lblLoggedInAs.Text = "Logged in as Admin: " + spNr; }
           //else { tabControl.Enabled = false; lblLoggedInAs.Text = "Logged in as: " + spNr; }

            if (Admin) { tabControl.Enabled = true; lblLoggedInAs.Text = "Logged in as Admin: " + spNr; }
            else
            {
                tabControl.Controls.Remove(tabPageEmployee);
                tabControl.Controls.Remove(tabPageProduct);
                tabControl.Controls.Remove(tabPageStatistics);
                lblLoggedInAs.Text = "Logged in as: " + spNr; }

            
        }
        private string SpNR{
            get { return spNr; }
            set { this.spNr = value;}

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPageStatistics_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            FillProductTable();
        }

        //FILL PRODUCT TABLE
        private void FillProductTable()
        {
            SqlDataAdapter da = controller.GetAllProducts();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewProductList.DataSource = data;
           
        }

        //FILL PRODUCT TABLE ADMIN
        private void FillProductTableAdmin()
        {
            SqlDataAdapter da = controller.GetAllProducts();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewPa.DataSource = data;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            l.Show();
            this.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

    }
}
