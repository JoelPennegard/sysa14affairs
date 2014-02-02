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
        private double totalPrice = 0;
        private Controller controller;

        
        public Form1(string spNr, string name, Controller controller, Boolean Admin)
        {
            InitializeComponent();
            this.controller = controller;
            this.spNr = spNr;
            FillProductTable();
            FillProductTableAdmin();


           // if (Admin) { tabControl.Enabled = true; lblLoggedInAs.Text = "Logged in as Admin: " + spNr; }
           //else { tabControl.Enabled = false; lblLoggedInAs.Text = "Logged in as: " + spNr; }

            if (Admin) 
            {
                tabControl.Enabled = true; lblLoggedInAs.Text = "Logged in as : " + name + " (Admin)"; 
            }
            else
            {
                tabControl.Controls.Remove(tabPageEmployee);
                tabControl.Controls.Remove(tabPageProduct);
                tabControl.Controls.Remove(tabPageStatistics);
                lblLoggedInAs.Text = "Logged in as: " + name; 
            }
            this.spNr = spNr;

            // GÖR SÅ ATT KOMMA BLIR PUNKT ISTÄLLET! (viktigt för att det ska gå att lägga in i sql) /LUDDE
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            // 
            textBoxNumPad.Text = totalPrice.ToString();
            
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
            SqlDataAdapter da = controller.GetAllProductsWithInPrice();
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

        private void textBoxSearchProduct_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int productNr = int.Parse(dataGridViewProductList.SelectedRows[0].Cells[0].Value.ToString());
            string productName = dataGridViewProductList.SelectedRows[0].Cells[1].Value.ToString();
            double productOutPrice = double.Parse(dataGridViewProductList.SelectedRows[0].Cells[2].Value.ToString());
            string amountString = richTextBoxAmount.Text;
            int amountInt = 1;
            string minusOrPlus = "-";         

                if (!Utility.CheckOnlyNumbers(amountString))
                {
                    MessageBox.Show("Amount must be integer", "Check amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (amountString.Length < 1)
                    {

                        amountInt = 1;
                        amountString = "1";
                    }
                    amountInt = int.Parse(amountString);
                    int productAmount = Utility.GetProductAmount(controller.getProductAmount(productNr));
                    int productAmountLeft = Utility.CheckProductAmount(productAmount, amountInt);
                    

                    if (productAmountLeft > 0)
                    {

                        string[] row = new string[] { productNr.ToString(), productName, productOutPrice.ToString(), amountInt.ToString() };
                        dataGridViewSaleList.Rows.Add(row);

                        double SinglePrice = amountInt * productOutPrice;
                        totalPrice = totalPrice + SinglePrice;
                        textBoxNumPad.Text = totalPrice.ToString();
                        controller.UpdateProductAmount(amountInt, productNr, minusOrPlus);
                        FillProductTableAdmin();
                    }
                    else
                    {
                        FillProductTableAdmin();
                    }
                }
            

        }
        

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            string search = textBoxSearchProduct.Text;
                SqlDataAdapter da = controller.SearchProductTill(search);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridViewProductList.DataSource = data;
                textBoxSearchProduct.Text = "";
                
            
          
        }

        private void dataGridViewPa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
                textBoxPaPrNr.Text = dataGridViewPa.SelectedRows[0].Cells[0].Value.ToString();
                textBoxPaName.Text = dataGridViewPa.SelectedRows[0].Cells[1].Value.ToString();
                textBoxPaInPrice.Text = dataGridViewPa.SelectedRows[0].Cells[2].Value.ToString();
                textBoxPaOutPrice.Text = dataGridViewPa.SelectedRows[0].Cells[3].Value.ToString();
                textBoxPaAmount.Text = dataGridViewPa.SelectedRows[0].Cells[4].Value.ToString();
            
         
        }

        private void buttonPaUpdate_Click(object sender, EventArgs e)
        {
            
            int productNr = int.Parse(textBoxPaPrNr.Text);
            string productName = Utility.FirstCharToUpper(textBoxPaName.Text);
            double productInPrice = Utility.CheckDouble(double.Parse(textBoxPaInPrice.Text));
            double productOutPrice = Utility.CheckDouble(double.Parse(textBoxPaOutPrice.Text));
            int amount = Utility.CheckInt(int.Parse(textBoxPaAmount.Text));

            controller.UpdateProduct(productNr, productName, productInPrice, productOutPrice, amount);
            MessageBox.Show("Product nr: " + productNr + " was updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearAllInPa();
            FillProductTable();
            FillProductTableAdmin();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(dataGridViewSaleList.SelectedRows[0].Cells[3].Value.ToString());
            int productNr = int.Parse(dataGridViewSaleList.SelectedRows[0].Cells[0].Value.ToString());
            double productOutPrice = double.Parse(dataGridViewSaleList.SelectedRows[0].Cells[2].Value.ToString());
            double SinglePrice = amount * productOutPrice;
            string minusOrPlus = "+";
            if (this.dataGridViewSaleList.SelectedRows.Count > 0)
            {
                
                totalPrice = totalPrice - SinglePrice;
                controller.UpdateProductAmount(amount, productNr, minusOrPlus);
                dataGridViewSaleList.Rows.RemoveAt(this.dataGridViewSaleList.SelectedRows[0].Index);
                FillProductTableAdmin();
                textBoxNumPad.Text = totalPrice.ToString();
                if (this.dataGridViewSaleList.Rows.Count == 0)
                {
                    totalPrice = 0;
                    textBoxNumPad.Text = totalPrice.ToString();
                }
            }
        }

        private void buttonENTER_Click(object sender, EventArgs e)
        {
            if (dataGridViewSaleList.Rows.Count < 1)
            {
                MessageBox.Show("A sale must contain at least one item.", "Empty sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                totalPrice = double.Parse(textBoxNumPad.Text);
                controller.SetSale(spNr, totalPrice);
                int salesNr = Utility.CheckLatestSale(controller.GetLatestSale());

                foreach (DataGridViewRow row in dataGridViewSaleList.Rows)
                {
                    int productNr = int.Parse(row.Cells[0].Value.ToString());
                    int amount = int.Parse(row.Cells[3].Value.ToString());
                    controller.SetSalesLine(productNr, salesNr, amount);
                }
                MessageBox.Show("Sale nr: " + salesNr + " was added.", "Sale completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewSaleList.Rows.Clear();
                totalPrice = 0;
                textBoxNumPad.Text = totalPrice.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlDataAdapter da = controller.GetSalesPersonSales(spNr);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewProductList.DataSource = data;
        }


        // CLEAR ALL IN PRODUCT ADMIN
        private void ClearAllInPa()
        {
            textBoxPaPrNr.Text = "";
            textBoxPaAmount.Text = "";
            textBoxPaInPrice.Text = "";
            textBoxPaName.Text = "";
            textBoxPaOutPrice.Text = "";
        }

        //Detta gör så att programmet STÄNGS när man trycker på X
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
                Environment.Exit(0);
        }

        private void buttonPaNew_Click(object sender, EventArgs e)
        {
            
            int amount = Utility.CheckInt(int.Parse(textBoxPaAmount.Text));
            double productInPrice = Utility.CheckDouble(double.Parse(textBoxPaInPrice.Text));
            string productName = Utility.FirstCharToUpper(textBoxPaName.Text);
            double productOutPrice = Utility.CheckDouble(double.Parse(textBoxPaOutPrice.Text));

            controller.SetProduct(productName, productInPrice, productOutPrice, amount);

            FillProductTableAdmin();
            FillProductTable();
            ClearAllInPa();
        }

        private void buttonPaClearAll_Click(object sender, EventArgs e)
        {
            ClearAllInPa();
        }

        private void buttonSearchPa_Click(object sender, EventArgs e)
        {
            string search = textBoxSearchPa.Text;
            SqlDataAdapter da = controller.SearchProductAllAttributes(search);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewPa.DataSource = data;

        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewSaleList.Rows)
            {
                int productNr = int.Parse(row.Cells[0].Value.ToString());
                int amount = int.Parse(row.Cells[3].Value.ToString());
                string minusOrPlus = "+";
                controller.UpdateProductAmount(amount, productNr, minusOrPlus);
            }
            FillProductTableAdmin();
            totalPrice = 0;
            textBoxNumPad.Text = totalPrice.ToString();
            dataGridViewSaleList.Rows.Clear();
            richTextBoxAmount.Text = "";
        }

        private void textBoxSearchProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                buttonSearchProduct.PerformClick();
            }
        }
    }
}
