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
            int amount = int.Parse(richTextBoxAmount.Text);
           
           
            string[] row = new string[] { productNr.ToString(), productName, productOutPrice.ToString(), amount.ToString() };
            dataGridViewSaleList.Rows.Add(row);

            double SinglePrice = amount * productOutPrice;
            totalPrice = totalPrice + SinglePrice;
            textBoxNumPad.Text = totalPrice.ToString();

        }

        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            string search = textBoxSearchProduct.Text;
            
            
                SqlDataAdapter da = controller.SearchProductTill(search);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridViewProductList.DataSource = data;
            
          
        }

        private void dataGridViewPa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPa.SelectedRows.Count == 1)
            {
                textBoxPaPrNr.Enabled = false;
                textBoxPaPrNr.Text = dataGridViewPa.SelectedRows[0].Cells[0].Value.ToString();
                textBoxPaName.Text = dataGridViewPa.SelectedRows[0].Cells[1].Value.ToString();
                textBoxPaInPrice.Text = dataGridViewPa.SelectedRows[0].Cells[2].Value.ToString();
                textBoxPaOutPrice.Text = dataGridViewPa.SelectedRows[0].Cells[3].Value.ToString();
                textBoxPaAmount.Text = dataGridViewPa.SelectedRows[0].Cells[4].Value.ToString();
            }
            else
            {
                textBoxPaPrNr.Enabled = true;
            }
        }

        private void buttonPaUpdate_Click(object sender, EventArgs e)
        {
            
            int productNr = int.Parse(textBoxPaPrNr.Text);
            string productName = Utility.FirstCharToUpper(textBoxPaName.Text);
            double productInPrice = Utility.CheckDouble(double.Parse(textBoxPaInPrice.Text));
            double productOutPrice = Utility.CheckDouble(double.Parse(textBoxPaOutPrice.Text));
            int amount = Utility.CheckInt(int.Parse(textBoxPaAmount.Text));

            controller.UpdateProduct(productNr, productName, productInPrice, productOutPrice, amount);
            
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            
 
        }

        private void buttonENTER_Click(object sender, EventArgs e)
        {
           // totalPrice = double.Parse(textBoxNumPad.Text);
           // controller.SetSale(spNr, totalPrice);

           // controller.SetSalesLine();
        }
    
        

    }
}
