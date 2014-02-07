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
        


        private string SpNR
        {
            get { return spNr; }
            set { this.spNr = value; }

        }

        #region Constructor and 'OnFormClosing'
        public Form1(string spNr, string name, Controller controller, Boolean Admin)
        {
            InitializeComponent();
            this.controller = controller;
            this.spNr = spNr;
            this.ClearAllErrorMessages();
            FillProductTable();

            if (Admin) 
            {
                tabControl.Enabled = true; lblLoggedInAs.Text = "Logged in as : " + name + " (Admin)"; 
                FillProductTableAdmin();
                FillProductTableNotForSaleAdmin();
                FillNotWorkingSalesPersonTable();
                FillWorkingSalesPersonTable();
                FillEmployeeComboBox();
                FillDataGridViewHistory1AllSalesPersons();

            }
            else
            {
                tabControl.Controls.Remove(tabPageEmployee);
                tabControl.Controls.Remove(tabPageProduct);
                tabControl.Controls.Remove(tabPageHistory);
                tabControl.Controls.Remove(tabPageStatistics);
                exitToolStripMenuItem.Enabled = false;
                lblLoggedInAs.Text = "Logged in as: " + name;
                exitToolStripMenuItem.Enabled = false;
            }
            this.spNr = spNr;

            // GÖR SÅ ATT KOMMA BLIR PUNKT ISTÄLLET! (viktigt för att det ska gå att lägga in i sql) /LUDDE
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            // 
            textBoxNumPad.Text = totalPrice.ToString();
            btnViewSale.Visible = false;
            

            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            ClearAllSaleView();
            Environment.Exit(0);

        }

        #endregion Constructor and 'OnFormClosing'

        #region Menu
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

        #endregion Menu

        #region Tab1 Sales 

        private void btnGetAllProducts_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();

            btnMyHistory.Text = "My History";
            SqlDataAdapter da = controller.GetAllProductsToSaleList();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewProductList.DataSource = data;

            SqlDataAdapter da1 = controller.GetAllProductsNotForSale();
            DataTable data1 = new DataTable();
            da1.Fill(data1);
            dataGridViewDeletedPa.DataSource = data1;

            btnViewSale.Visible = false;
            btwAddProductToSale.Enabled = true;
            btnRemoveProductFromSale.Enabled = true;
 
        }

        private void btnAddProductToSale_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();

            string currency = textBoxCurrencyUnit.Text = "SEK";
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
                                FillProductTableAdmin();
                                FillProductTable();
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
                            FillProductTable();
                            
                        }

                        textBoxNumPad.Text = Utility.GetCurrencyExchangeRate(currency, totalPrice).ToString();
                    }
                    else
                    {
                        FillProductTableAdmin();
                    }
                }
            

        }

        private void btnRemoveProductFromSale_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();
            if (dataGridViewSaleList.RowCount > 0)
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
                    FillProductTable();
                    textBoxNumPad.Text = totalPrice.ToString();
                    if (this.dataGridViewSaleList.Rows.Count == 0)
                    {
                        totalPrice = 0;
                        textBoxNumPad.Text = totalPrice.ToString();
                    }
                }
            }
        }

        private void btnRegisterSale_Click(object sender, EventArgs e)
        {
            if (dataGridViewSaleList.Rows.Count < 1)
            {
                MessageBox.Show("A sale must contain at least one item.", "Empty sale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                controller.SetSale(spNr, Utility.RoundSEK(totalPrice));
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
                FillDataGridViewHistory1AllSalesPersons();
                comboBoxEmployees.Text = "All employees";
            }
        }

        private void btnMyHistory_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();

            if (btnMyHistory.Text.Equals("My History"))
            {
                btwAddProductToSale.Enabled = false;
                btnRemoveProductFromSale.Enabled = false;
                SqlDataAdapter da = controller.GetSalesPersonSales(spNr);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridViewProductList.DataSource = data;
                btnMyHistory.Text = "Back To Products";
                if (dataGridViewProductList.Rows.Count == 0)
                {
                    btnViewSale.Visible = false;
                }
                else
                {
                    btnViewSale.Visible = true;
                }
            }
            else
            {
                FillProductTable();
                btnViewSale.Visible = false;
                btnRemoveProductFromSale.Enabled = true;
                btwAddProductToSale.Enabled = true;
                btnMyHistory.Text = "My History";
                btnViewSale.Text = "View Sale";
            }
        }

        private void btnClearAllSaleView_Click(object sender, EventArgs e)
        {
            ClearAllSaleView();

        }

        private void btnViewSale_Click(object sender, EventArgs e)
        
        {
            this.ClearAllErrorMessages();

            if (btnViewSale.Text.Equals("View Sale"))
            {
                int salesNr = int.Parse(dataGridViewProductList.SelectedRows[0].Cells[0].Value.ToString());

                SqlDataAdapter da = controller.GetSalesLinesFromSale(salesNr);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridViewProductList.DataSource = data;
                btnViewSale.Text = "Back";
            }
            else
            {
                SqlDataAdapter da = controller.GetSalesPersonSales(spNr);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridViewProductList.DataSource = data;
                btnViewSale.Text = "View Sale";
            }

        }

        private void btnSearchProductSaleMenu_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();

            btnMyHistory.Text = "My History";

            string search = textBoxSearchProduct.Text;
            if (Utility.CheckIfContainsForbiddenChars(search))
            {
                lblErrorSaleSearch.Text = " [ ' ] is not allowed in the search";
            }
            else
            {
                SqlDataAdapter da = controller.SearchProductTill(search);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridViewProductList.DataSource = data;
                textBoxSearchProduct.Text = "";

                btnViewSale.Visible = false;
                btwAddProductToSale.Enabled = true;
                btnRemoveProductFromSale.Enabled = true;
            }
        }

        private void textBoxSearchProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearchProductSalesTab.PerformClick();
            }
        }

        #endregion Tab1 Sales 

        #region Tab1 Money Converter

        private void btnSEK_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "SEK";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("SEK", totalPrice).ToString();
        }

        private void btnEURO_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "€";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("EUR", totalPrice).ToString();

        }

        private void btnUSD_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "$";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("USD", totalPrice).ToString();
        }

        private void btnDKK_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "DKK";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("DKK", totalPrice).ToString();
        }

        private void btnGBP_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "£";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("GBP", totalPrice).ToString();
        }

        private void btnNOK_Click(object sender, EventArgs e)
        {
            textBoxCurrencyUnit.Text = "NOK";
            textBoxNumPad.Text = Utility.GetCurrencyExchangeRate("NOK", totalPrice).ToString();
        }

        #endregion Tab1 Money Converter

        #region Tab2 EmployeeAdmin

        private void btnGetAllWorkingSalesPersons_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();

            SqlDataAdapter da = controller.GetAllWorkingSalesPersons();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewSP.DataSource = data;

            SqlDataAdapter da1 = controller.GetAllNotWorkingSalesPersons();
            DataTable data1 = new DataTable();
            da1.Fill(data1);
            dataGridViewDeletedSP.DataSource = data1;
        }

        private void btnEaClearAll_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();
            ClearAllEmployeeAdmin();
        }

        private void btnEaUpdate_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();

            int isAdmin = Utility.ConvertBoolToInt(checkBoxEmployeeAdmin.Checked);
            int isActive = Utility.ConvertBoolToInt(checkBoxEmployee.Checked);
            string spNr = Utility.FirstCharToUpper(textBoxEaSpNr.Text);
            string firstName = Utility.FirstCharToUpper(textBoxEaFName.Text);
            string lastName = Utility.FirstCharToUpper(textBoxEaLName.Text);
            string sPhone = Utility.FirstCharToUpper(textBoxEaPhoneNr.Text);
            string totalInformation = spNr + firstName + lastName + sPhone;

            if (Utility.CheckIfSearchIsEmpty(spNr))
            {
                lblErrorSalesPersonFields.Text = "Select a employee from \n" + "any of the tables";
            }
            else if (Utility.CheckIfContainsForbiddenChars(totalInformation))
            {
                lblErrorSalesPersonFields.Text = "[ ' ] is not a allowed sign";

            }
            else if (Utility.CheckIfSearchIsEmpty(firstName) ||
                Utility.CheckIfSearchIsEmpty(lastName) || Utility.CheckIfSearchIsEmpty(sPhone))
            {
                lblErrorSalesPersonFields.Text = "Please provide information \n" + "in all the fields";
            }
            else
            {

                controller.UpdateSalesPerson(spNr, firstName, lastName, sPhone, isAdmin, isActive);
                MessageBox.Show("Person: " + spNr + " was updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FillNotWorkingSalesPersonTable();
                FillWorkingSalesPersonTable();
                ClearAllEmployeeAdmin();
                lblErrorSalesPersonFields.Text = "";
            }
        }

        private void btnEaNew_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();

            int isAdmin = Utility.ConvertBoolToInt(checkBoxEmployeeAdmin.Checked);
            int isActive = Utility.ConvertBoolToInt(checkBoxEmployee.Checked);
            string spNr = textBoxEaSpNr.Text;
            string firstName = Utility.FirstCharToUpper(textBoxEaFName.Text);
            string lastName = Utility.FirstCharToUpper(textBoxEaLName.Text);
            string sPhone = Utility.FirstCharToUpper(textBoxEaPhoneNr.Text);


            if (Utility.CheckSalesPersonAddNew(controller.SearchSalesPerson(spNr)) != spNr)
            {
                string totalInformation = spNr + firstName + lastName + sPhone;
                if (Utility.CheckIfContainsForbiddenChars(totalInformation))
                {
                    lblErrorSalesPersonFields.Text = "[ ' ] is not a allowed sign";

                }
                else if (Utility.CheckIfSearchIsEmpty(spNr) || Utility.CheckIfSearchIsEmpty(firstName) ||
                    Utility.CheckIfSearchIsEmpty(lastName) || Utility.CheckIfSearchIsEmpty(sPhone))
                {
                    lblErrorSalesPersonFields.Text = "Please provide information \n" + "in all the fields";
                }
                else
                {

                    controller.SetSalesPerson(spNr, firstName, lastName, sPhone, isAdmin, isActive);
                    MessageBox.Show("Person: " + spNr + " was added.", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FillNotWorkingSalesPersonTable();
                    FillWorkingSalesPersonTable();
                    ClearAllEmployeeAdmin();
                    lblErrorSalesPersonFields.Text = "";
                    comboBoxEmployees.Items.Clear();
                    FillEmployeeComboBox();
                   
                }
            }
            else
            {
                lblErrorSalesPersonFields.Text = "Social security number already\nexists in database";
            }
        }

        private void textBoxSearchSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearchSalesPerson.PerformClick();

            }
        }

        private void buttonSearchSP_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();

            string search = textBoxSearchSP.Text;
            if (Utility.CheckIfContainsForbiddenChars(search))
            {
                lblErrorSalesPersonSearch.Text = " [ ' ] is not allowed in the search";
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


        #endregion Tab2 EmployeeAdmin
                
        #region Tab3 ProductAdmin

        private void btnSearchPa_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();

            string search = textBoxSearchPa.Text;
            if (Utility.CheckIfContainsForbiddenChars(search))
            {
                lblErrorProductSearch.Text = " [ ' ] is not allowed in the search";
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

        private void btnPaUpdate_Click(object sender, EventArgs e)
        {

            this.ClearAllErrorMessages();

            int isForSale = Utility.ConvertBoolToInt(checkBoxForSale.Checked);
            string productNrString = textBoxPaPrNr.Text;
            string amountString = textBoxPaAmount.Text;
            string inPriceString = textBoxPaInPrice.Text;
            string outPriceString = textBoxPaOutPrice.Text;
            string productName = Utility.FirstCharToUpper(textBoxPaName.Text);
            
            string totalInformation = amountString + inPriceString + outPriceString + productName;

            if (Utility.CheckIfSearchIsEmpty(productNrString))
            {
                lblErrorProductAdminFields.Text = "Select a product from \n" + "any of the tables";
            }
            else if (Utility.CheckIfContainsForbiddenChars(totalInformation))
            {
                lblErrorProductAdminFields.Text = "[ ' ] is not a allowed sign";

            }
            else if (Utility.CheckIfSearchIsEmpty(amountString) || Utility.CheckIfSearchIsEmpty(inPriceString) ||
                Utility.CheckIfSearchIsEmpty(outPriceString) || Utility.CheckIfSearchIsEmpty(productName))
            {
                lblErrorProductAdminFields.Text = "Please provide information \n" + "in all the fields";
            }
            else if (!Utility.CheckOnlyNumbers(amountString))
            {
                lblErrorProductAdminFields.Text = "Please provide the amount \n" + "as a integer";
            }
            else if (!Utility.CheckOnlyNumbersAndDecimals(inPriceString) || !Utility.CheckOnlyNumbersAndDecimals(outPriceString))
            {
                lblErrorProductAdminFields.Text = "Please provide the prices \n" + "with numbers only";
            }
            else if (Utility.CompareInAndOutPrice(double.Parse(inPriceString), double.Parse(outPriceString)))
            {
                lblErrorProductAdminFields.Text = "In Price can't be higher \n" + "than out price";
            }
            else
            {

                int productNr = int.Parse(textBoxPaPrNr.Text);
                double productInPrice = Utility.CheckDouble(double.Parse(textBoxPaInPrice.Text));
                double productOutPrice = Utility.CheckDouble(double.Parse(textBoxPaOutPrice.Text));
                int amount = Utility.CheckInt(int.Parse(textBoxPaAmount.Text));

                controller.UpdateProduct(productNr, productName, productInPrice, productOutPrice, amount, isForSale);
                MessageBox.Show("Product nr: " + productNr + " was updated.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAllInPa();
                FillProductTable();
                FillProductTableAdmin();
                FillProductTableNotForSaleAdmin();
                lblErrorProductAdminFields.Text = "";
            }
        }

        private void btnPaNew_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();

            int isForSale = Utility.ConvertBoolToInt(checkBoxForSale.Checked);
            string amountString = textBoxPaAmount.Text;
            string inPriceString = textBoxPaInPrice.Text;
            string outPriceString = textBoxPaOutPrice.Text;
            string productName = Utility.FirstCharToUpper(textBoxPaName.Text);
            
            string totalInformation = amountString + inPriceString + outPriceString + productName;

            if (Utility.CheckIfContainsForbiddenChars(totalInformation))
            {
                lblErrorProductAdminFields.Text = "[ ' ] is not a allowed sign";
                
            }
            else if (Utility.CheckIfSearchIsEmpty(amountString) || Utility.CheckIfSearchIsEmpty(inPriceString) ||
                Utility.CheckIfSearchIsEmpty(outPriceString) || Utility.CheckIfSearchIsEmpty(productName))
            {
                lblErrorProductAdminFields.Text = "Please provide information \n"+"in all the editable fields";
            }
            else if (!Utility.CheckOnlyNumbers(amountString))
            {
                lblErrorProductAdminFields.Text = "Please provide the amount \n" + "as a integer";
            }
            else if (!Utility.CheckOnlyNumbersAndDecimals(inPriceString) || !Utility.CheckOnlyNumbersAndDecimals(outPriceString))
            {
                lblErrorProductAdminFields.Text = "Please provide the prices \n" + "with numbers only";
            }
            else if (Utility.CompareInAndOutPrice(double.Parse(inPriceString), double.Parse(outPriceString)))
            {
                lblErrorProductAdminFields.Text = "In Price can't be higher \n" + "than out price";
            }
            else
            {
                int amount = Utility.CheckInt(int.Parse(textBoxPaAmount.Text));
                double productInPrice = Utility.CheckDouble(double.Parse(textBoxPaInPrice.Text));
                double productOutPrice = Utility.CheckDouble(double.Parse(textBoxPaOutPrice.Text));

                controller.SetProduct(productName, productInPrice, productOutPrice, amount, isForSale);

                MessageBox.Show("Product with nr: " + ProductNr + " was created.", "New Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                FillProductTableAdmin();
                FillProductTableNotForSaleAdmin();
                FillProductTable();
                ClearAllInPa();
                lblErrorProductAdminFields.Text = "";
            }
        }

        private void btnPaClearAll_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();
            this.ClearAllInPa();
        }

        private void btnGetAllPa_Click(object sender, EventArgs e)
        {
            this.ClearAllErrorMessages();

            SqlDataAdapter da = controller.GetAllProductsForSale();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewPa.DataSource = data;

            SqlDataAdapter da1 = controller.GetAllProductsNotForSale();
            DataTable data1 = new DataTable();
            da1.Fill(data1);
            dataGridViewDeletedPa.DataSource = data1;
        }
                
        private void textBoxSearchPa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSearchProductAdmin.PerformClick();
            }
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

        private void dataGridViewPa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPaPrNr.Text = dataGridViewPa.SelectedRows[0].Cells[0].Value.ToString();
            textBoxPaName.Text = dataGridViewPa.SelectedRows[0].Cells[1].Value.ToString();
            textBoxPaInPrice.Text = dataGridViewPa.SelectedRows[0].Cells[2].Value.ToString();
            textBoxPaOutPrice.Text = dataGridViewPa.SelectedRows[0].Cells[3].Value.ToString();
            textBoxPaAmount.Text = dataGridViewPa.SelectedRows[0].Cells[4].Value.ToString();
            checkBoxForSale.Checked = (bool)dataGridViewPa.SelectedRows[0].Cells[5].Value;
        }

        #endregion Tab3 ProductAdmin

        #region Tab4 History


        private void btnHAGetSales_Click(object sender, EventArgs e)
        {
            string spNr = comboBoxEmployees.Text;
            string startDate = dateTimePickerStart.Text;
            string endDate = dateTimePickerEnd.Text;

            if (!spNr.Equals("All employees"))
            {
                SqlDataAdapter da = controller.GetSalesPersonSalesBetweenDates(spNr, startDate, endDate);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridViewHistory1.DataSource = data;
            }
            else
            {
                SqlDataAdapter da = controller.GetAllSalesFromAllSalesPersonsBetweenDates(startDate, endDate);
                DataTable data = new DataTable();
                da.Fill(data);
                dataGridViewHistory1.DataSource = data;
            }
        }

        private void btnHAViewSaleLines_Click(object sender, EventArgs e)
        {
            int salesNr = 0;

            if (comboBoxEmployees.Text.Equals("All employees"))
            {
                salesNr = int.Parse(dataGridViewHistory1.SelectedRows[0].Cells[1].Value.ToString());
            }
            else
            {
                salesNr = int.Parse(dataGridViewHistory1.SelectedRows[0].Cells[0].Value.ToString());
            }

            SqlDataAdapter da = controller.GetSalesLinesFromSale(salesNr);
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewHistory2.DataSource = data;
            


        }



        #endregion Tab4 History

        #region Tab5 Statistics

        private void btnTopSellers_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = controller.GetHighestSales();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewStatistics.DataSource = data;

        }

        private void btnTopProduct_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = controller.GetTopProductSale();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewStatistics.DataSource = data;
        }

        private void btnTopCombos_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = controller.GetTopOneSalesPerson();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewStatistics.DataSource = data;
        }

        #endregion Tab5 Statistics
                
        #region Helper-Methods (Fill table / clear etc)
        
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
        
        //CLEAR ALL EMPLOYEE ADMIN
        private void ClearAllEmployeeAdmin()
        {
            textBoxEaSpNr.Enabled = true;
            textBoxEaSpNr.Text = "";
            textBoxEaFName.Text = "";
            textBoxEaLName.Text = "";
            textBoxEaPhoneNr.Text = "";
            textBoxSearchSP.Text = "";

            checkBoxEmployee.Checked = false;
            checkBoxEmployeeAdmin.Checked = false;
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


        }
        
        private void ClearAllErrorMessages()
        {
            lblErrorSalesPersonFields.Text = "";
            lblErrorProductAdminFields.Text = "";
            lblErrorProductSearch.Text = "";
            lblErrorSaleSearch.Text = "";
            lblErrorSalesPersonSearch.Text = "";
        }

        public void FillEmployeeComboBox()
        {
            SqlDataReader dr = controller.GetAllSalesPersonSpnr();
            while (dr.Read())
            {
                comboBoxEmployees.Items.Add(dr.GetString(0));
            }
        }

        public void FillDataGridViewHistory1AllSalesPersons()
        {
            SqlDataAdapter da = controller.GetAllSalesFromAllSalesPersons();
            DataTable data = new DataTable();
            da.Fill(data);
            dataGridViewHistory1.DataSource = data;
        }

        #endregion Helper-Methods (Fill table / clear etc)

      

    }
}
