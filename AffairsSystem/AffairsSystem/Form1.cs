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
using System.Web;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Net;

namespace AffairsSystem
{
    public partial class Form1 : Form
    {
        private string spNr = "";
        private double totalPrice = 0;
        private Controller controller;
        private string payedAmount = "";

        
        public Form1(string spNr, string name, Controller controller, Boolean Admin)
        {
            InitializeComponent();
            this.controller = controller;
            this.spNr = spNr;
            FillProductTable();
            


           // if (Admin) { tabControl.Enabled = true; lblLoggedInAs.Text = "Logged in as Admin: " + spNr; }
           //else { tabControl.Enabled = false; lblLoggedInAs.Text = "Logged in as: " + spNr; }

            if (Admin) 
            {
                tabControl.Enabled = true; lblLoggedInAs.Text = "Logged in as : " + name + " (Admin)"; 
                FillProductTableAdmin();
                FillProductTableNotForSaleAdmin();
                FillNotWorkingSalesPersonTable();
                FillWorkingSalesPersonTable();

            }
            else
            {
                tabControl.Controls.Remove(tabPageEmployee);
                tabControl.Controls.Remove(tabPageProduct);
                tabControl.Controls.Remove(tabPageStatistics);
                exitToolStripMenuItem.Enabled = false;
                lblLoggedInAs.Text = "Logged in as: " + name; 
            }
            this.spNr = spNr;

            // GÖR SÅ ATT KOMMA BLIR PUNKT ISTÄLLET! (viktigt för att det ska gå att lägga in i sql) /LUDDE
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            // 
            textBoxNumPad.Text = totalPrice.ToString();
            buttonBack.Visible = false;
            buttonViewSale.Visible = false;
            

            
        }
        private string SpNR{
            get { return spNr; }
            set { this.spNr = value;}

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void buttonGetAllProducts_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = controller.GetAllProductsToSaleList();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewProductList.DataSource = data;

            SqlDataAdapter da1 = controller.GetAllProductsNotForSale();
            DataTable data1 = new DataTable();
            da1.Fill(data1);
            dataGridViewDeletedPa.DataSource = data1;

            buttonBack.Visible = false;
            buttonViewSale.Visible = false;
            button1.Enabled = true;
 
        }

        

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            l.Show();
            this.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllSaleView();
            this.Close();
            Application.Exit();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "SEK";
            int productNr = int.Parse(dataGridViewProductList.SelectedRows[0].Cells[0].Value.ToString());
            string productName = dataGridViewProductList.SelectedRows[0].Cells[1].Value.ToString();
            double productOutPrice = double.Parse(dataGridViewProductList.SelectedRows[0].Cells[2].Value.ToString());
            string amountString = richTextBoxAmount.Text;
            richTextBoxAmount.Text = "";
            int amountInt = 1;
            string minusOrPlus = "-";
            bool exists = false;

                if (!Utility.CheckOnlyNumbers(amountString))
                {
                    MessageBox.Show("Amount must be integer", "Check amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Utility.CheckIfSearchIsEmpty(amountString))
                    {

                        amountInt = 1;
                        amountString = "1";
                    }
                    amountInt = int.Parse(amountString);
                    int productAmount = Utility.GetProductAmount(controller.getProductAmount(productNr));
                    int productAmountLeft = Utility.CheckProductAmount(productAmount, amountInt);
                    

                    if (productAmountLeft > 0)
                    {

                        int rowCount = dataGridViewSaleList.RowCount;
                                                                      

                        for (int i = 0; i < rowCount; i++)
                        {
                            int tmpProductNr = int.Parse(dataGridViewSaleList.Rows[i].Cells[0].Value.ToString());
                            if (productNr==tmpProductNr) 
                            {
                                int currentAmountInSalesLine = int.Parse(dataGridViewSaleList.Rows[i].Cells[3].Value.ToString());
                                double SinglePrice = amountInt * productOutPrice;
                                
                                
                                
                                int newAmountInSalesLine = amountInt + currentAmountInSalesLine;
                                
                                totalPrice += SinglePrice;
                                
                                amountString = newAmountInSalesLine.ToString();
                                dataGridViewSaleList.Rows[i].Cells[3].Value = amountString;

                                controller.UpdateProductAmount(amountInt, productNr, minusOrPlus);
                                exists = true;
                                

                            }
                            
                        }
                        if (!exists)
                        {
                            string[] row = new string[] { productNr.ToString(), productName, productOutPrice.ToString(), amountInt.ToString() };
                            dataGridViewSaleList.Rows.Add(row);

                            double SinglePrice = amountInt * productOutPrice;
                            totalPrice = totalPrice + SinglePrice;
                            controller.UpdateProductAmount(amountInt, productNr, minusOrPlus);
                            FillProductTableAdmin();
                            
                        }
                        
                        textBoxNumPad.Text = totalPrice.ToString();
                    }
                    else
                    {
                        FillProductTableAdmin();
                    }
                }
            

        }
        

        


        private void buttonPaUpdate_Click(object sender, EventArgs e)
        {
            int isForSale = Utility.ConvertBoolToInt(checkBoxForSale.Checked);
            int productNr = int.Parse(textBoxPaPrNr.Text);
            string productName = Utility.FirstCharToUpper(textBoxPaName.Text);
            double productInPrice = Utility.CheckDouble(double.Parse(textBoxPaInPrice.Text));
            double productOutPrice = Utility.CheckDouble(double.Parse(textBoxPaOutPrice.Text));
            int amount = Utility.CheckInt(int.Parse(textBoxPaAmount.Text));

            controller.UpdateProduct(productNr, productName, productInPrice, productOutPrice, amount, isForSale);
            MessageBox.Show("Product nr: " + productNr + " was updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearAllInPa();
            FillProductTable();
            FillProductTableAdmin();
            FillProductTableNotForSaleAdmin();
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
            button1.Enabled = false;
            buttonViewSale.Visible = true;
            SqlDataAdapter da = controller.GetSalesPersonSales(spNr);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewProductList.DataSource = data;
        }


        

        private void buttonPaNew_Click(object sender, EventArgs e)
        {
            int isForSale = Utility.ConvertBoolToInt(checkBoxForSale.Checked);
            int amount = Utility.CheckInt(int.Parse(textBoxPaAmount.Text));
            double productInPrice = Utility.CheckDouble(double.Parse(textBoxPaInPrice.Text));
            string productName = Utility.FirstCharToUpper(textBoxPaName.Text);
            double productOutPrice = Utility.CheckDouble(double.Parse(textBoxPaOutPrice.Text));

            controller.SetProduct(productName, productInPrice, productOutPrice, amount, isForSale);

            FillProductTableAdmin();
            FillProductTableNotForSaleAdmin();
            FillProductTable();
            ClearAllInPa();
        }

        private void buttonPaClearAll_Click(object sender, EventArgs e)
        {
            ClearAllInPa();
        }

        

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            ClearAllSaleView();

        }

        private void textBoxSearchProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                buttonSearchProduct.PerformClick();
            }
        }

        private void buttonTopSellers_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = controller.GetHighestSales();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewStatistics.DataSource = data;

        }

        private void buttonTopProduct_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = controller.GetTopProductSale();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewStatistics.DataSource = data;
        }

        private void buttonTopCombos_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = controller.GetTopOneSalesPerson();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewStatistics.DataSource = data;
        }
        //FILL PRODUCT TABLE
        private void FillProductTable()
        {
            SqlDataAdapter da = controller.GetAllProductsToSaleList();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewProductList.DataSource = data;

        }
        //FILL WORKING SALES PERSON TABLE
        private void FillWorkingSalesPersonTable()
        {
            SqlDataAdapter da = controller.GetAllWorkingSalesPersons();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewSP.DataSource = data;
        }

        //FILL NOT WORKING SALES PERSON TABLE
        private void FillNotWorkingSalesPersonTable()
        {
            SqlDataAdapter da = controller.GetAllNotWorkingSalesPersons();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewDeletedSP.DataSource = data;
        }


        //FILL PRODUCTS FOR SALE TABLE ADMIN
        private void FillProductTableAdmin()
        {
            SqlDataAdapter da = controller.GetAllProductsForSale();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewPa.DataSource = data;
        }
        //FILL PRODUCTS NOT FOR SALE TABLE ADMIN
        private void FillProductTableNotForSaleAdmin()
        {
            SqlDataAdapter da = controller.GetAllProductsNotForSale();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewDeletedPa.DataSource = data;
        }

        // CLEAR ALL IN PRODUCT ADMIN
        private void ClearAllInPa()
        {
            textBoxPaPrNr.Text = "";
            textBoxPaAmount.Text = "";
            textBoxPaInPrice.Text = "";
            textBoxPaName.Text = "";
            textBoxPaOutPrice.Text = "";
            checkBoxForSale.Checked = false;
        }

        //Detta gör så att programmet STÄNGS när man trycker på X
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ClearAllSaleView();
            Environment.Exit(0);
            
        }

        

        

        private void textBoxSearchPa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                buttonSearchPa.PerformClick();
            }
        }

        

        private void buttonGetAllPa_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = controller.GetAllProductsForSale();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewPa.DataSource = data;

            SqlDataAdapter da1 = controller.GetAllProductsNotForSale();
            DataTable data1 = new DataTable();
            da1.Fill(data1);
            dataGridViewDeletedPa.DataSource = data1;
        }

        

        private void dataGridViewPa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPaPrNr.Text = dataGridViewPa.SelectedRows[0].Cells[0].Value.ToString();
            textBoxPaName.Text = dataGridViewPa.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPaInPrice.Text = dataGridViewPa.SelectedRows[0].Cells[2].Value.ToString();
            textBoxPaOutPrice.Text = dataGridViewPa.SelectedRows[0].Cells[3].Value.ToString();
            textBoxPaAmount.Text = dataGridViewPa.SelectedRows[0].Cells[4].Value.ToString();
            checkBoxForSale.Checked = (bool)dataGridViewPa.SelectedRows[0].Cells[5].Value;
        }

       

        private void buttonSEK_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "SEK";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("SEK", totalPrice).ToString();
        }

        private void buttonEURO_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "€";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("EUR", totalPrice).ToString();
            
        }

        private void buttonUSD_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "$";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("USD", totalPrice).ToString();
        }

        private void buttonDKK_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "DKK";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("DKK", totalPrice).ToString();
        }

        private void buttonGBP_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "£";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("GBP", totalPrice).ToString();
        }

        private void buttonNOK_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "NOK";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("NOK", totalPrice).ToString();
        }
        
        private void buttonNP1_Click(object sender, EventArgs e)
        {
            string input = "1";
            textBoxNumPad2.Text = payedAmount = Utility.CalculateNumpad(input, payedAmount);
            
        }

        private void buttonNP2_Click(object sender, EventArgs e)
        {
            string input = "2";
            textBoxNumPad2.Text = payedAmount = Utility.CalculateNumpad(input, payedAmount);
            
        }

        private void buttonNP3_Click(object sender, EventArgs e)
        {

            string input = "3";
            textBoxNumPad2.Text = payedAmount = Utility.CalculateNumpad(input, payedAmount);
            
        }

        private void buttonNP4_Click(object sender, EventArgs e)
        {
            string input = "4";
            textBoxNumPad2.Text = payedAmount = Utility.CalculateNumpad(input, payedAmount);
            
        }

        private void buttonNP5_Click(object sender, EventArgs e)
        {
            string input = "5";
            textBoxNumPad2.Text = payedAmount = Utility.CalculateNumpad(input, payedAmount);
            
        }

        private void buttonNP6_Click(object sender, EventArgs e)
        {
            string input = "6";
            textBoxNumPad2.Text = payedAmount = Utility.CalculateNumpad(input, payedAmount);
            
        }

        private void buttonNP7_Click(object sender, EventArgs e)
        {
            string input = "7";
            textBoxNumPad2.Text = payedAmount = Utility.CalculateNumpad(input, payedAmount);
            
        }

        private void buttonNP8_Click(object sender, EventArgs e)
        {
            string input = "8";
            textBoxNumPad2.Text = payedAmount = Utility.CalculateNumpad(input, payedAmount);
            
        }

        private void buttonNP9_Click(object sender, EventArgs e)
        {
            string input = "9";
            textBoxNumPad2.Text = payedAmount = Utility.CalculateNumpad(input, payedAmount);
            
        }

        private void buttonNP0_Click(object sender, EventArgs e)
        {
            string input = "0";
            textBoxNumPad2.Text =  payedAmount = Utility.CalculateNumpad(input, payedAmount);
        }

        private void buttonNPDECIMAL_Click(object sender, EventArgs e)
        {
            string input = ".";
            textBoxNumPad2.Text = payedAmount = Utility.CalculateNumpad(input, payedAmount);
            
        }

        private void buttonDELETE_Click(object sender, EventArgs e)
        {
            textBoxNumPad2.Text = payedAmount = Utility.TrimLastCharacter(payedAmount);
            
           
        }

        private void buttonGetAllWorkingSalesPersons_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = controller.GetAllWorkingSalesPersons();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewSP.DataSource = data;

            SqlDataAdapter da1 = controller.GetAllNotWorkingSalesPersons();
            DataTable data1 = new DataTable();
            da1.Fill(data1);
            dataGridViewDeletedSP.DataSource = data1;
        }

             

        private void dataGridViewDeletedPa_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPaPrNr.Text = dataGridViewDeletedPa.SelectedRows[0].Cells[0].Value.ToString();
            textBoxPaName.Text = dataGridViewDeletedPa.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPaInPrice.Text = dataGridViewDeletedPa.SelectedRows[0].Cells[2].Value.ToString();
            textBoxPaOutPrice.Text = dataGridViewDeletedPa.SelectedRows[0].Cells[3].Value.ToString();
            textBoxPaAmount.Text = dataGridViewDeletedPa.SelectedRows[0].Cells[4].Value.ToString();
            checkBoxForSale.Checked = (bool)dataGridViewDeletedPa.SelectedRows[0].Cells[5].Value;
        }

        private void dataGridViewSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxEaSpNr.Enabled = false;
            string spNr = dataGridViewSP.SelectedRows[0].Cells[0].Value.ToString();
            textBoxEaSpNr.Text = spNr.ToString();
            textBoxEaFName.Text = dataGridViewSP.SelectedRows[0].Cells[1].Value.ToString();
            textBoxEaLName.Text = dataGridViewSP.SelectedRows[0].Cells[2].Value.ToString();
            textBoxEaPhoneNr.Text = dataGridViewSP.SelectedRows[0].Cells[3].Value.ToString();
            checkBoxEmployee.Checked = Utility.GetIsActive(controller.GetIsActive(spNr));
            checkBoxEmployeeAdmin.Checked = Utility.CheckAdmin(controller.SearchSalesPerson(spNr));
        }

        private void dataGridViewDeletedSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxEaSpNr.Enabled = false;
            string spNr = dataGridViewDeletedSP.SelectedRows[0].Cells[0].Value.ToString();
            textBoxEaSpNr.Text = spNr.ToString();
            textBoxEaFName.Text = dataGridViewDeletedSP.SelectedRows[0].Cells[1].Value.ToString();
            textBoxEaLName.Text = dataGridViewDeletedSP.SelectedRows[0].Cells[2].Value.ToString();
            textBoxEaPhoneNr.Text = dataGridViewDeletedSP.SelectedRows[0].Cells[3].Value.ToString();
            checkBoxEmployee.Checked = Utility.GetIsActive(controller.GetIsActive(spNr));
            checkBoxEmployeeAdmin.Checked = Utility.CheckAdmin(controller.SearchSalesPerson(spNr));
        }

        private void buttonEaClearAll_Click(object sender, EventArgs e)
        {
            ClearAllEmployeeAdmin();
        }

        //CLEAR ALL EMPLOYEE ADMIN
        private void ClearAllEmployeeAdmin(){
            textBoxEaSpNr.Enabled = true;
            textBoxEaSpNr.Text = "";
            textBoxEaFName.Text = "";
            textBoxEaLName.Text = "";
            textBoxEaPhoneNr.Text = "";
            textBoxSearchSP.Text = "";
            
            checkBoxEmployee.Checked = false;
            checkBoxEmployeeAdmin.Checked = false;
        }

        private void buttonEaUpdate_Click(object sender, EventArgs e)
        {
            int isAdmin = Utility.ConvertBoolToInt(checkBoxEmployeeAdmin.Checked);
            int isActive = Utility.ConvertBoolToInt(checkBoxEmployee.Checked);
            string spNr = Utility.FirstCharToUpper(textBoxEaSpNr.Text);
            string firstName = Utility.FirstCharToUpper(textBoxEaFName.Text);
            string lastName = Utility.FirstCharToUpper(textBoxEaLName.Text);
            string sPhone = Utility.FirstCharToUpper(textBoxEaPhoneNr.Text);

            controller.UpdateSalesPerson(spNr, firstName, lastName, sPhone, isAdmin, isActive);
            MessageBox.Show("Person: " + spNr + " was updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FillNotWorkingSalesPersonTable();
            FillWorkingSalesPersonTable();
            ClearAllEmployeeAdmin();
           
        }

        private void buttonEaNew_Click(object sender, EventArgs e)
        {
            int isAdmin = Utility.ConvertBoolToInt(checkBoxEmployeeAdmin.Checked);
            int isActive = Utility.ConvertBoolToInt(checkBoxEmployee.Checked);
            string spNr = Utility.FirstCharToUpper(textBoxEaSpNr.Text);
            string firstName = Utility.FirstCharToUpper(textBoxEaFName.Text);
            string lastName = Utility.FirstCharToUpper(textBoxEaLName.Text);
            string sPhone = Utility.FirstCharToUpper(textBoxEaPhoneNr.Text);

            controller.SetSalesPerson(spNr, firstName, lastName, sPhone, isAdmin, isActive);
            MessageBox.Show("Person: " + spNr + " was added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            FillNotWorkingSalesPersonTable();
            FillWorkingSalesPersonTable();
            ClearAllEmployeeAdmin();
        }

        private void textBoxSearchSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                buttonSearchSP.PerformClick();
                
            }
        }

        
        private void buttonSearchProduct_Click(object sender, EventArgs e)
        {
            labelErrorSaleSearch.Text = "";
            string search = textBoxSearchProduct.Text;
            if (Utility.checkIfSearchContainsForbiddenChars(search))
            {
                labelErrorSaleSearch.Text = " [ ' ] is not allowed in the search";
            }
            else
            {
                SqlDataAdapter da = controller.SearchProductTill(search);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridViewProductList.DataSource = data;
                textBoxSearchProduct.Text = "";
                buttonBack.Visible = false;
            buttonViewSale.Visible = false;
            button1.Enabled = true;
            }
        }

        private void buttonSearchPa_Click(object sender, EventArgs e)
        {
            labelErrorProductSearch.Text = "";
            string search = textBoxSearchPa.Text;
            if (Utility.checkIfSearchContainsForbiddenChars(search))
            {
                labelErrorProductSearch.Text = " [ ' ] is not allowed in the search";
            }
            else
            {
                SqlDataAdapter da1 = controller.SearchProductAllAttributesForSale(search);
                DataTable data1 = new DataTable();
                da1.Fill(data1);
                dataGridViewPa.DataSource = data1;
                textBoxSearchPa.Text = "";

                SqlDataAdapter da2 = controller.SearchProductAllAttributesNotForSale(search);
                DataTable data2 = new DataTable();
                da2.Fill(data2);
                dataGridViewDeletedPa.DataSource = data2;

            }
        }
        private void buttonSearchSP_Click(object sender, EventArgs e)
        {
            labelErrorSalesPersonSearch.Text = "";
            string search = textBoxSearchSP.Text;
            if (Utility.checkIfSearchContainsForbiddenChars(search))
            {
                labelErrorSalesPersonSearch.Text = " [ ' ] is not allowed in the search";
            }
            else
            {
                SqlDataAdapter da1 = controller.SearchWorkingSalesPersons(search);
                DataTable data1 = new DataTable();
                da1.Fill(data1);
                dataGridViewSP.DataSource = data1;
                ClearAllEmployeeAdmin();

                // Klistrar in andra searchknappmetoden

                SqlDataAdapter da2 = controller.SearchNotWorkingSalesPersons(search);
                DataTable data2 = new DataTable();
                da2.Fill(data2);
                dataGridViewDeletedSP.DataSource = data2;
                ClearAllEmployeeAdmin();
            }
        }

        private void buttonSearchDeletedSP_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewSale_Click(object sender, EventArgs e)
        {
            int salesNr = int.Parse(dataGridViewProductList.SelectedRows[0].Cells[0].Value.ToString());

            SqlDataAdapter da = controller.getSalesLinesFromSale(salesNr);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewProductList.DataSource = data;
            buttonBack.Visible = true;
            

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonBack.Visible = false;
            SqlDataAdapter da = controller.GetSalesPersonSales(spNr);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewProductList.DataSource = data;
        }
        private void ClearAllSaleView()
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
            payedAmount = "";
            textBoxNumPad2.Text = "";
        }

        

        

        

        

        

        



    }
}
