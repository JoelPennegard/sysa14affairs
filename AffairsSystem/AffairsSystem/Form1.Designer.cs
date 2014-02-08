namespace AffairsSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSale = new System.Windows.Forms.TabPage();
            this.groupBoxTotalPrice = new System.Windows.Forms.GroupBox();
            this.textBoxNumPad = new System.Windows.Forms.TextBox();
            this.textBoxCurrencyUnit = new System.Windows.Forms.TextBox();
            this.groupBoxCurrencys = new System.Windows.Forms.GroupBox();
            this.btnNOK = new System.Windows.Forms.Button();
            this.btnSEK = new System.Windows.Forms.Button();
            this.btnDKK = new System.Windows.Forms.Button();
            this.btnEURO = new System.Windows.Forms.Button();
            this.btnGBP = new System.Windows.Forms.Button();
            this.btnUSD = new System.Windows.Forms.Button();
            this.btnViewSale = new System.Windows.Forms.Button();
            this.lblErrorSaleSearch = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnClearAllSaleView = new System.Windows.Forms.Button();
            this.btnMyHistory = new System.Windows.Forms.Button();
            this.lblSearchProduct = new System.Windows.Forms.Label();
            this.btnSearchProductSalesTab = new System.Windows.Forms.Button();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.btnRegisterSale = new System.Windows.Forms.Button();
            this.dataGridViewSaleList = new System.Windows.Forms.DataGridView();
            this.ProductNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBoxAmount = new System.Windows.Forms.RichTextBox();
            this.btnRemoveProductFromSale = new System.Windows.Forms.Button();
            this.btwAddProductToSale = new System.Windows.Forms.Button();
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxEaFName = new System.Windows.Forms.TextBox();
            this.btnAddNewSalesPerson = new System.Windows.Forms.Button();
            this.btnUpdateSalesPerson = new System.Windows.Forms.Button();
            this.checkBoxEmployeeAdmin = new System.Windows.Forms.CheckBox();
            this.textBoxEaSpNr = new System.Windows.Forms.TextBox();
            this.checkBoxEmployee = new System.Windows.Forms.CheckBox();
            this.textBoxEaPhoneNr = new System.Windows.Forms.TextBox();
            this.textBoxEaLName = new System.Windows.Forms.TextBox();
            this.btnClearAllSalesPersonFields = new System.Windows.Forms.Button();
            this.labelEaSpNr = new System.Windows.Forms.Label();
            this.labelEaFName = new System.Windows.Forms.Label();
            this.labelEaLName = new System.Windows.Forms.Label();
            this.labelEaPhoneNr = new System.Windows.Forms.Label();
            this.lblErrorSalesPersonFields = new System.Windows.Forms.Label();
            this.lblErrorSalesPersonSearch = new System.Windows.Forms.Label();
            this.btnGetAllWorkingSalesPersons = new System.Windows.Forms.Button();
            this.lblSearchDeletedSP = new System.Windows.Forms.Label();
            this.dataGridViewDeletedSP = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lblSearchSP = new System.Windows.Forms.Label();
            this.btnSearchSalesPerson = new System.Windows.Forms.Button();
            this.textBoxSearchSP = new System.Windows.Forms.TextBox();
            this.dataGridViewSP = new System.Windows.Forms.DataGridView();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPaName = new System.Windows.Forms.TextBox();
            this.textBoxPaPrNr = new System.Windows.Forms.TextBox();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.lblPaInPrice = new System.Windows.Forms.Label();
            this.lblPaOutPrice = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.textBoxPaAmount = new System.Windows.Forms.TextBox();
            this.lblPaName = new System.Windows.Forms.Label();
            this.lblPaAmount = new System.Windows.Forms.Label();
            this.lblPaPrNr = new System.Windows.Forms.Label();
            this.checkBoxForSale = new System.Windows.Forms.CheckBox();
            this.textBoxPaInPrice = new System.Windows.Forms.TextBox();
            this.btnClearAllProductFields = new System.Windows.Forms.Button();
            this.textBoxPaOutPrice = new System.Windows.Forms.TextBox();
            this.lblErrorProductAdminFields = new System.Windows.Forms.Label();
            this.lblErrorProductSearch = new System.Windows.Forms.Label();
            this.btnGetAllProductAdmin = new System.Windows.Forms.Button();
            this.dataGridViewDeletedPa = new System.Windows.Forms.DataGridView();
            this.lblSearchDeletedPa = new System.Windows.Forms.Label();
            this.lblSearchPa = new System.Windows.Forms.Label();
            this.btnSearchProductAdmin = new System.Windows.Forms.Button();
            this.textBoxSearchPa = new System.Windows.Forms.TextBox();
            this.dataGridViewPa = new System.Windows.Forms.DataGridView();
            this.tabPageHistory = new System.Windows.Forms.TabPage();
            this.btnHAGetSales = new System.Windows.Forms.Button();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.groupBoxBetween = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblAnd = new System.Windows.Forms.Label();
            this.btnHAViewSaleLines = new System.Windows.Forms.Button();
            this.dataGridViewHistory2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewHistory1 = new System.Windows.Forms.DataGridView();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.dataGridViewStatistics = new System.Windows.Forms.DataGridView();
            this.btnTopProduct = new System.Windows.Forms.Button();
            this.btnTopCombos = new System.Windows.Forms.Button();
            this.btnTopSellers = new System.Windows.Forms.Button();
            this.lblLoggedInAs = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabPageSale.SuspendLayout();
            this.groupBoxTotalPrice.SuspendLayout();
            this.groupBoxCurrencys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.tabPageEmployee.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletedSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).BeginInit();
            this.tabPageProduct.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletedPa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPa)).BeginInit();
            this.tabPageHistory.SuspendLayout();
            this.groupBoxSelect.SuspendLayout();
            this.groupBoxBetween.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory1)).BeginInit();
            this.tabPageStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSale);
            this.tabControl.Controls.Add(this.tabPageEmployee);
            this.tabControl.Controls.Add(this.tabPageProduct);
            this.tabControl.Controls.Add(this.tabPageHistory);
            this.tabControl.Controls.Add(this.tabPageStatistics);
            this.tabControl.Location = new System.Drawing.Point(0, 25);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1142, 543);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageSale
            // 
            this.tabPageSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPageSale.Controls.Add(this.groupBoxTotalPrice);
            this.tabPageSale.Controls.Add(this.groupBoxCurrencys);
            this.tabPageSale.Controls.Add(this.btnViewSale);
            this.tabPageSale.Controls.Add(this.lblErrorSaleSearch);
            this.tabPageSale.Controls.Add(this.btnClearAll);
            this.tabPageSale.Controls.Add(this.btnClearAllSaleView);
            this.tabPageSale.Controls.Add(this.btnMyHistory);
            this.tabPageSale.Controls.Add(this.lblSearchProduct);
            this.tabPageSale.Controls.Add(this.btnSearchProductSalesTab);
            this.tabPageSale.Controls.Add(this.textBoxSearchProduct);
            this.tabPageSale.Controls.Add(this.btnRegisterSale);
            this.tabPageSale.Controls.Add(this.dataGridViewSaleList);
            this.tabPageSale.Controls.Add(this.richTextBoxAmount);
            this.tabPageSale.Controls.Add(this.btnRemoveProductFromSale);
            this.tabPageSale.Controls.Add(this.btwAddProductToSale);
            this.tabPageSale.Controls.Add(this.dataGridViewProductList);
            this.tabPageSale.Location = new System.Drawing.Point(4, 22);
            this.tabPageSale.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSale.Name = "tabPageSale";
            this.tabPageSale.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageSale.Size = new System.Drawing.Size(1134, 517);
            this.tabPageSale.TabIndex = 0;
            this.tabPageSale.Text = "Sale menu";
            this.tabPageSale.UseVisualStyleBackColor = true;
            // 
            // groupBoxTotalPrice
            // 
            this.groupBoxTotalPrice.Controls.Add(this.textBoxNumPad);
            this.groupBoxTotalPrice.Controls.Add(this.textBoxCurrencyUnit);
            this.groupBoxTotalPrice.Location = new System.Drawing.Point(901, 203);
            this.groupBoxTotalPrice.Name = "groupBoxTotalPrice";
            this.groupBoxTotalPrice.Size = new System.Drawing.Size(228, 77);
            this.groupBoxTotalPrice.TabIndex = 49;
            this.groupBoxTotalPrice.TabStop = false;
            this.groupBoxTotalPrice.Text = "Total Price:";
            // 
            // textBoxNumPad
            // 
            this.textBoxNumPad.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumPad.Location = new System.Drawing.Point(9, 18);
            this.textBoxNumPad.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumPad.Name = "textBoxNumPad";
            this.textBoxNumPad.Size = new System.Drawing.Size(141, 44);
            this.textBoxNumPad.TabIndex = 38;
            this.textBoxNumPad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCurrencyUnit
            // 
            this.textBoxCurrencyUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxCurrencyUnit.Location = new System.Drawing.Point(154, 18);
            this.textBoxCurrencyUnit.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCurrencyUnit.Multiline = true;
            this.textBoxCurrencyUnit.Name = "textBoxCurrencyUnit";
            this.textBoxCurrencyUnit.Size = new System.Drawing.Size(68, 44);
            this.textBoxCurrencyUnit.TabIndex = 38;
            // 
            // groupBoxCurrencys
            // 
            this.groupBoxCurrencys.Controls.Add(this.btnNOK);
            this.groupBoxCurrencys.Controls.Add(this.btnSEK);
            this.groupBoxCurrencys.Controls.Add(this.btnDKK);
            this.groupBoxCurrencys.Controls.Add(this.btnEURO);
            this.groupBoxCurrencys.Controls.Add(this.btnGBP);
            this.groupBoxCurrencys.Controls.Add(this.btnUSD);
            this.groupBoxCurrencys.Location = new System.Drawing.Point(920, 77);
            this.groupBoxCurrencys.Name = "groupBoxCurrencys";
            this.groupBoxCurrencys.Size = new System.Drawing.Size(192, 120);
            this.groupBoxCurrencys.TabIndex = 48;
            this.groupBoxCurrencys.TabStop = false;
            this.groupBoxCurrencys.Text = "Currency";
            // 
            // btnNOK
            // 
            this.btnNOK.Location = new System.Drawing.Point(127, 65);
            this.btnNOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnNOK.Name = "btnNOK";
            this.btnNOK.Size = new System.Drawing.Size(53, 42);
            this.btnNOK.TabIndex = 13;
            this.btnNOK.Text = "NOK";
            this.btnNOK.UseVisualStyleBackColor = true;
            this.btnNOK.Click += new System.EventHandler(this.btnNOK_Click);
            // 
            // btnSEK
            // 
            this.btnSEK.Location = new System.Drawing.Point(12, 19);
            this.btnSEK.Margin = new System.Windows.Forms.Padding(2);
            this.btnSEK.Name = "btnSEK";
            this.btnSEK.Size = new System.Drawing.Size(54, 42);
            this.btnSEK.TabIndex = 8;
            this.btnSEK.Text = "SEK";
            this.btnSEK.UseVisualStyleBackColor = true;
            this.btnSEK.Click += new System.EventHandler(this.btnSEK_Click);
            // 
            // btnDKK
            // 
            this.btnDKK.Location = new System.Drawing.Point(13, 66);
            this.btnDKK.Margin = new System.Windows.Forms.Padding(2);
            this.btnDKK.Name = "btnDKK";
            this.btnDKK.Size = new System.Drawing.Size(53, 42);
            this.btnDKK.TabIndex = 9;
            this.btnDKK.Text = "DKK";
            this.btnDKK.UseVisualStyleBackColor = true;
            this.btnDKK.Click += new System.EventHandler(this.btnDKK_Click);
            // 
            // btnEURO
            // 
            this.btnEURO.Location = new System.Drawing.Point(70, 19);
            this.btnEURO.Margin = new System.Windows.Forms.Padding(2);
            this.btnEURO.Name = "btnEURO";
            this.btnEURO.Size = new System.Drawing.Size(53, 42);
            this.btnEURO.TabIndex = 10;
            this.btnEURO.Text = "EURO";
            this.btnEURO.UseVisualStyleBackColor = true;
            this.btnEURO.Click += new System.EventHandler(this.btnEURO_Click);
            // 
            // btnGBP
            // 
            this.btnGBP.Location = new System.Drawing.Point(70, 66);
            this.btnGBP.Margin = new System.Windows.Forms.Padding(2);
            this.btnGBP.Name = "btnGBP";
            this.btnGBP.Size = new System.Drawing.Size(53, 42);
            this.btnGBP.TabIndex = 11;
            this.btnGBP.Text = "GBP";
            this.btnGBP.UseVisualStyleBackColor = true;
            this.btnGBP.Click += new System.EventHandler(this.btnGBP_Click);
            // 
            // btnUSD
            // 
            this.btnUSD.Location = new System.Drawing.Point(127, 19);
            this.btnUSD.Margin = new System.Windows.Forms.Padding(2);
            this.btnUSD.Name = "btnUSD";
            this.btnUSD.Size = new System.Drawing.Size(53, 42);
            this.btnUSD.TabIndex = 12;
            this.btnUSD.Text = "USD";
            this.btnUSD.UseVisualStyleBackColor = true;
            this.btnUSD.Click += new System.EventHandler(this.btnUSD_Click);
            // 
            // btnViewSale
            // 
            this.btnViewSale.Location = new System.Drawing.Point(121, 446);
            this.btnViewSale.Name = "btnViewSale";
            this.btnViewSale.Size = new System.Drawing.Size(95, 41);
            this.btnViewSale.TabIndex = 47;
            this.btnViewSale.Text = "View Sale";
            this.btnViewSale.UseVisualStyleBackColor = true;
            this.btnViewSale.Click += new System.EventHandler(this.btnViewSale_Click);
            // 
            // lblErrorSaleSearch
            // 
            this.lblErrorSaleSearch.AutoSize = true;
            this.lblErrorSaleSearch.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSaleSearch.Location = new System.Drawing.Point(158, 58);
            this.lblErrorSaleSearch.Name = "lblErrorSaleSearch";
            this.lblErrorSaleSearch.Size = new System.Drawing.Size(97, 13);
            this.lblErrorSaleSearch.TabIndex = 46;
            this.lblErrorSaleSearch.Text = "Felmedelanden här";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(909, 399);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(141, 42);
            this.btnClearAll.TabIndex = 44;
            this.btnClearAll.Text = "Clear all fields";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAllSaleView_Click);
            // 
            // btnClearAllSaleView
            // 
            this.btnClearAllSaleView.Location = new System.Drawing.Point(328, 77);
            this.btnClearAllSaleView.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAllSaleView.Name = "btnClearAllSaleView";
            this.btnClearAllSaleView.Size = new System.Drawing.Size(69, 42);
            this.btnClearAllSaleView.TabIndex = 4;
            this.btnClearAllSaleView.Text = "Get all";
            this.btnClearAllSaleView.UseVisualStyleBackColor = true;
            this.btnClearAllSaleView.Click += new System.EventHandler(this.btnGetAllProducts_Click);
            // 
            // btnMyHistory
            // 
            this.btnMyHistory.Location = new System.Drawing.Point(12, 445);
            this.btnMyHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnMyHistory.Name = "btnMyHistory";
            this.btnMyHistory.Size = new System.Drawing.Size(104, 42);
            this.btnMyHistory.TabIndex = 42;
            this.btnMyHistory.Text = "My History";
            this.btnMyHistory.UseVisualStyleBackColor = true;
            this.btnMyHistory.Click += new System.EventHandler(this.btnMyHistory_Click);
            // 
            // lblSearchProduct
            // 
            this.lblSearchProduct.AutoSize = true;
            this.lblSearchProduct.Location = new System.Drawing.Point(13, 58);
            this.lblSearchProduct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchProduct.Name = "lblSearchProduct";
            this.lblSearchProduct.Size = new System.Drawing.Size(139, 13);
            this.lblSearchProduct.TabIndex = 41;
            this.lblSearchProduct.Text = "Search on product attribute:";
            // 
            // btnSearchProductSalesTab
            // 
            this.btnSearchProductSalesTab.Location = new System.Drawing.Point(259, 77);
            this.btnSearchProductSalesTab.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchProductSalesTab.Name = "btnSearchProductSalesTab";
            this.btnSearchProductSalesTab.Size = new System.Drawing.Size(64, 42);
            this.btnSearchProductSalesTab.TabIndex = 2;
            this.btnSearchProductSalesTab.Text = "Search";
            this.btnSearchProductSalesTab.UseVisualStyleBackColor = true;
            this.btnSearchProductSalesTab.Click += new System.EventHandler(this.btnSearchProductSaleMenu_Click);
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchProduct.Location = new System.Drawing.Point(12, 77);
            this.textBoxSearchProduct.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(243, 44);
            this.textBoxSearchProduct.TabIndex = 1;
            this.textBoxSearchProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchProduct_KeyPress);
            // 
            // btnRegisterSale
            // 
            this.btnRegisterSale.Location = new System.Drawing.Point(910, 285);
            this.btnRegisterSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegisterSale.Name = "btnRegisterSale";
            this.btnRegisterSale.Size = new System.Drawing.Size(141, 110);
            this.btnRegisterSale.TabIndex = 36;
            this.btnRegisterSale.Text = "Register Sale";
            this.btnRegisterSale.UseVisualStyleBackColor = true;
            this.btnRegisterSale.Click += new System.EventHandler(this.btnRegisterSale_Click);
            // 
            // dataGridViewSaleList
            // 
            this.dataGridViewSaleList.AllowUserToAddRows = false;
            this.dataGridViewSaleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductNr,
            this.ProductName,
            this.Price,
            this.Amount});
            this.dataGridViewSaleList.Location = new System.Drawing.Point(512, 119);
            this.dataGridViewSaleList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSaleList.MultiSelect = false;
            this.dataGridViewSaleList.Name = "dataGridViewSaleList";
            this.dataGridViewSaleList.ReadOnly = true;
            this.dataGridViewSaleList.RowHeadersVisible = false;
            this.dataGridViewSaleList.RowTemplate.Height = 24;
            this.dataGridViewSaleList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSaleList.Size = new System.Drawing.Size(384, 322);
            this.dataGridViewSaleList.TabIndex = 7;
            // 
            // ProductNr
            // 
            this.ProductNr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ProductNr.HeaderText = "Product Nr";
            this.ProductNr.Name = "ProductNr";
            this.ProductNr.ReadOnly = true;
            this.ProductNr.Width = 83;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 56;
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 68;
            // 
            // richTextBoxAmount
            // 
            this.richTextBoxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAmount.Location = new System.Drawing.Point(422, 250);
            this.richTextBoxAmount.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxAmount.Name = "richTextBoxAmount";
            this.richTextBoxAmount.Size = new System.Drawing.Size(65, 34);
            this.richTextBoxAmount.TabIndex = 3;
            this.richTextBoxAmount.Text = "";
            // 
            // btnRemoveProductFromSale
            // 
            this.btnRemoveProductFromSale.Location = new System.Drawing.Point(422, 297);
            this.btnRemoveProductFromSale.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProductFromSale.Name = "btnRemoveProductFromSale";
            this.btnRemoveProductFromSale.Size = new System.Drawing.Size(64, 33);
            this.btnRemoveProductFromSale.TabIndex = 5;
            this.btnRemoveProductFromSale.Text = "<<<";
            this.btnRemoveProductFromSale.UseVisualStyleBackColor = true;
            this.btnRemoveProductFromSale.Click += new System.EventHandler(this.btnRemoveProductFromSale_Click);
            // 
            // btwAddProductToSale
            // 
            this.btwAddProductToSale.Location = new System.Drawing.Point(422, 204);
            this.btwAddProductToSale.Margin = new System.Windows.Forms.Padding(2);
            this.btwAddProductToSale.Name = "btwAddProductToSale";
            this.btwAddProductToSale.Size = new System.Drawing.Size(64, 33);
            this.btwAddProductToSale.TabIndex = 4;
            this.btwAddProductToSale.Text = ">>>";
            this.btwAddProductToSale.UseVisualStyleBackColor = true;
            this.btwAddProductToSale.Click += new System.EventHandler(this.btnAddProductToSale_Click);
            // 
            // dataGridViewProductList
            // 
            this.dataGridViewProductList.AllowUserToAddRows = false;
            this.dataGridViewProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductList.Location = new System.Drawing.Point(12, 124);
            this.dataGridViewProductList.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProductList.MultiSelect = false;
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.ReadOnly = true;
            this.dataGridViewProductList.RowHeadersVisible = false;
            this.dataGridViewProductList.RowTemplate.Height = 24;
            this.dataGridViewProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProductList.Size = new System.Drawing.Size(384, 317);
            this.dataGridViewProductList.TabIndex = 2;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.groupBox2);
            this.tabPageEmployee.Controls.Add(this.lblErrorSalesPersonFields);
            this.tabPageEmployee.Controls.Add(this.lblErrorSalesPersonSearch);
            this.tabPageEmployee.Controls.Add(this.btnGetAllWorkingSalesPersons);
            this.tabPageEmployee.Controls.Add(this.lblSearchDeletedSP);
            this.tabPageEmployee.Controls.Add(this.dataGridViewDeletedSP);
            this.tabPageEmployee.Controls.Add(this.splitter1);
            this.tabPageEmployee.Controls.Add(this.lblSearchSP);
            this.tabPageEmployee.Controls.Add(this.btnSearchSalesPerson);
            this.tabPageEmployee.Controls.Add(this.textBoxSearchSP);
            this.tabPageEmployee.Controls.Add(this.dataGridViewSP);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageEmployee.Size = new System.Drawing.Size(1134, 517);
            this.tabPageEmployee.TabIndex = 1;
            this.tabPageEmployee.Text = "Employee administration";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxEaFName);
            this.groupBox2.Controls.Add(this.btnAddNewSalesPerson);
            this.groupBox2.Controls.Add(this.btnUpdateSalesPerson);
            this.groupBox2.Controls.Add(this.checkBoxEmployeeAdmin);
            this.groupBox2.Controls.Add(this.textBoxEaSpNr);
            this.groupBox2.Controls.Add(this.checkBoxEmployee);
            this.groupBox2.Controls.Add(this.textBoxEaPhoneNr);
            this.groupBox2.Controls.Add(this.textBoxEaLName);
            this.groupBox2.Controls.Add(this.btnClearAllSalesPersonFields);
            this.groupBox2.Controls.Add(this.labelEaSpNr);
            this.groupBox2.Controls.Add(this.labelEaFName);
            this.groupBox2.Controls.Add(this.labelEaLName);
            this.groupBox2.Controls.Add(this.labelEaPhoneNr);
            this.groupBox2.Location = new System.Drawing.Point(460, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 380);
            this.groupBox2.TabIndex = 402;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Handle Employee";
            // 
            // textBoxEaFName
            // 
            this.textBoxEaFName.Location = new System.Drawing.Point(16, 80);
            this.textBoxEaFName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEaFName.Name = "textBoxEaFName";
            this.textBoxEaFName.Size = new System.Drawing.Size(148, 20);
            this.textBoxEaFName.TabIndex = 52;
            // 
            // btnAddNewSalesPerson
            // 
            this.btnAddNewSalesPerson.Location = new System.Drawing.Point(48, 256);
            this.btnAddNewSalesPerson.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewSalesPerson.Name = "btnAddNewSalesPerson";
            this.btnAddNewSalesPerson.Size = new System.Drawing.Size(76, 24);
            this.btnAddNewSalesPerson.TabIndex = 57;
            this.btnAddNewSalesPerson.Text = "New";
            this.btnAddNewSalesPerson.UseVisualStyleBackColor = true;
            this.btnAddNewSalesPerson.Click += new System.EventHandler(this.btnEaNew_Click);
            // 
            // btnUpdateSalesPerson
            // 
            this.btnUpdateSalesPerson.Location = new System.Drawing.Point(48, 284);
            this.btnUpdateSalesPerson.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateSalesPerson.Name = "btnUpdateSalesPerson";
            this.btnUpdateSalesPerson.Size = new System.Drawing.Size(76, 24);
            this.btnUpdateSalesPerson.TabIndex = 58;
            this.btnUpdateSalesPerson.Text = "Update";
            this.btnUpdateSalesPerson.UseVisualStyleBackColor = true;
            this.btnUpdateSalesPerson.Click += new System.EventHandler(this.btnEaUpdate_Click);
            // 
            // checkBoxEmployeeAdmin
            // 
            this.checkBoxEmployeeAdmin.AutoSize = true;
            this.checkBoxEmployeeAdmin.Location = new System.Drawing.Point(14, 192);
            this.checkBoxEmployeeAdmin.Name = "checkBoxEmployeeAdmin";
            this.checkBoxEmployeeAdmin.Size = new System.Drawing.Size(61, 17);
            this.checkBoxEmployeeAdmin.TabIndex = 55;
            this.checkBoxEmployeeAdmin.Text = "ADMIN";
            this.checkBoxEmployeeAdmin.UseVisualStyleBackColor = true;
            // 
            // textBoxEaSpNr
            // 
            this.textBoxEaSpNr.Location = new System.Drawing.Point(16, 42);
            this.textBoxEaSpNr.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEaSpNr.Name = "textBoxEaSpNr";
            this.textBoxEaSpNr.Size = new System.Drawing.Size(148, 20);
            this.textBoxEaSpNr.TabIndex = 51;
            // 
            // checkBoxEmployee
            // 
            this.checkBoxEmployee.AutoSize = true;
            this.checkBoxEmployee.Location = new System.Drawing.Point(14, 215);
            this.checkBoxEmployee.Name = "checkBoxEmployee";
            this.checkBoxEmployee.Size = new System.Drawing.Size(67, 17);
            this.checkBoxEmployee.TabIndex = 56;
            this.checkBoxEmployee.Text = "Is Active";
            this.checkBoxEmployee.UseVisualStyleBackColor = true;
            // 
            // textBoxEaPhoneNr
            // 
            this.textBoxEaPhoneNr.Location = new System.Drawing.Point(16, 156);
            this.textBoxEaPhoneNr.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEaPhoneNr.Name = "textBoxEaPhoneNr";
            this.textBoxEaPhoneNr.Size = new System.Drawing.Size(148, 20);
            this.textBoxEaPhoneNr.TabIndex = 54;
            // 
            // textBoxEaLName
            // 
            this.textBoxEaLName.Location = new System.Drawing.Point(16, 118);
            this.textBoxEaLName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEaLName.Name = "textBoxEaLName";
            this.textBoxEaLName.Size = new System.Drawing.Size(148, 20);
            this.textBoxEaLName.TabIndex = 53;
            // 
            // btnClearAllSalesPersonFields
            // 
            this.btnClearAllSalesPersonFields.Location = new System.Drawing.Point(37, 312);
            this.btnClearAllSalesPersonFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAllSalesPersonFields.Name = "btnClearAllSalesPersonFields";
            this.btnClearAllSalesPersonFields.Size = new System.Drawing.Size(104, 42);
            this.btnClearAllSalesPersonFields.TabIndex = 59;
            this.btnClearAllSalesPersonFields.Text = "Clear all fields";
            this.btnClearAllSalesPersonFields.UseVisualStyleBackColor = true;
            this.btnClearAllSalesPersonFields.Click += new System.EventHandler(this.btnEaClearAll_Click);
            // 
            // labelEaSpNr
            // 
            this.labelEaSpNr.AutoSize = true;
            this.labelEaSpNr.Location = new System.Drawing.Point(12, 27);
            this.labelEaSpNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEaSpNr.Name = "labelEaSpNr";
            this.labelEaSpNr.Size = new System.Drawing.Size(89, 13);
            this.labelEaSpNr.TabIndex = 64;
            this.labelEaSpNr.Text = "Personal number:";
            // 
            // labelEaFName
            // 
            this.labelEaFName.AutoSize = true;
            this.labelEaFName.Location = new System.Drawing.Point(11, 65);
            this.labelEaFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEaFName.Name = "labelEaFName";
            this.labelEaFName.Size = new System.Drawing.Size(58, 13);
            this.labelEaFName.TabIndex = 65;
            this.labelEaFName.Text = "First name:";
            // 
            // labelEaLName
            // 
            this.labelEaLName.AutoSize = true;
            this.labelEaLName.Location = new System.Drawing.Point(11, 103);
            this.labelEaLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEaLName.Name = "labelEaLName";
            this.labelEaLName.Size = new System.Drawing.Size(59, 13);
            this.labelEaLName.TabIndex = 66;
            this.labelEaLName.Text = "Last name:";
            // 
            // labelEaPhoneNr
            // 
            this.labelEaPhoneNr.AutoSize = true;
            this.labelEaPhoneNr.Location = new System.Drawing.Point(13, 141);
            this.labelEaPhoneNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEaPhoneNr.Name = "labelEaPhoneNr";
            this.labelEaPhoneNr.Size = new System.Drawing.Size(79, 13);
            this.labelEaPhoneNr.TabIndex = 67;
            this.labelEaPhoneNr.Text = "Phone number:";
            // 
            // lblErrorSalesPersonFields
            // 
            this.lblErrorSalesPersonFields.AutoSize = true;
            this.lblErrorSalesPersonFields.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSalesPersonFields.Location = new System.Drawing.Point(457, 57);
            this.lblErrorSalesPersonFields.Name = "lblErrorSalesPersonFields";
            this.lblErrorSalesPersonFields.Size = new System.Drawing.Size(88, 13);
            this.lblErrorSalesPersonFields.TabIndex = 96;
            this.lblErrorSalesPersonFields.Text = "felmedelande här";
            // 
            // lblErrorSalesPersonSearch
            // 
            this.lblErrorSalesPersonSearch.AutoSize = true;
            this.lblErrorSalesPersonSearch.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSalesPersonSearch.Location = new System.Drawing.Point(174, 38);
            this.lblErrorSalesPersonSearch.Name = "lblErrorSalesPersonSearch";
            this.lblErrorSalesPersonSearch.Size = new System.Drawing.Size(97, 13);
            this.lblErrorSalesPersonSearch.TabIndex = 95;
            this.lblErrorSalesPersonSearch.Text = "Felmedelanden här";
            // 
            // btnGetAllWorkingSalesPersons
            // 
            this.btnGetAllWorkingSalesPersons.Location = new System.Drawing.Point(366, 56);
            this.btnGetAllWorkingSalesPersons.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetAllWorkingSalesPersons.Name = "btnGetAllWorkingSalesPersons";
            this.btnGetAllWorkingSalesPersons.Size = new System.Drawing.Size(64, 44);
            this.btnGetAllWorkingSalesPersons.TabIndex = 50;
            this.btnGetAllWorkingSalesPersons.Text = "Get All";
            this.btnGetAllWorkingSalesPersons.UseVisualStyleBackColor = true;
            this.btnGetAllWorkingSalesPersons.Click += new System.EventHandler(this.btnGetAllWorkingSalesPersons_Click);
            // 
            // lblSearchDeletedSP
            // 
            this.lblSearchDeletedSP.AutoSize = true;
            this.lblSearchDeletedSP.Location = new System.Drawing.Point(664, 87);
            this.lblSearchDeletedSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchDeletedSP.Name = "lblSearchDeletedSP";
            this.lblSearchDeletedSP.Size = new System.Drawing.Size(84, 13);
            this.lblSearchDeletedSP.TabIndex = 89;
            this.lblSearchDeletedSP.Text = "Past employees:";
            // 
            // dataGridViewDeletedSP
            // 
            this.dataGridViewDeletedSP.AllowUserToAddRows = false;
            this.dataGridViewDeletedSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDeletedSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeletedSP.Location = new System.Drawing.Point(667, 104);
            this.dataGridViewDeletedSP.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDeletedSP.MultiSelect = false;
            this.dataGridViewDeletedSP.Name = "dataGridViewDeletedSP";
            this.dataGridViewDeletedSP.ReadOnly = true;
            this.dataGridViewDeletedSP.RowHeadersVisible = false;
            this.dataGridViewDeletedSP.RowTemplate.Height = 24;
            this.dataGridViewDeletedSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeletedSP.Size = new System.Drawing.Size(438, 317);
            this.dataGridViewDeletedSP.TabIndex = 401;
            this.dataGridViewDeletedSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeletedSP_CellClick);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 513);
            this.splitter1.TabIndex = 85;
            this.splitter1.TabStop = false;
            // 
            // lblSearchSP
            // 
            this.lblSearchSP.AutoSize = true;
            this.lblSearchSP.Location = new System.Drawing.Point(7, 38);
            this.lblSearchSP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchSP.Name = "lblSearchSP";
            this.lblSearchSP.Size = new System.Drawing.Size(162, 13);
            this.lblSearchSP.TabIndex = 50;
            this.lblSearchSP.Text = "Search on sales person attribute:";
            // 
            // btnSearchSalesPerson
            // 
            this.btnSearchSalesPerson.Location = new System.Drawing.Point(298, 56);
            this.btnSearchSalesPerson.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchSalesPerson.Name = "btnSearchSalesPerson";
            this.btnSearchSalesPerson.Size = new System.Drawing.Size(64, 44);
            this.btnSearchSalesPerson.TabIndex = 49;
            this.btnSearchSalesPerson.Text = "Search";
            this.btnSearchSalesPerson.UseVisualStyleBackColor = true;
            this.btnSearchSalesPerson.Click += new System.EventHandler(this.buttonSearchSP_Click);
            // 
            // textBoxSearchSP
            // 
            this.textBoxSearchSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchSP.Location = new System.Drawing.Point(12, 57);
            this.textBoxSearchSP.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchSP.Name = "textBoxSearchSP";
            this.textBoxSearchSP.Size = new System.Drawing.Size(282, 44);
            this.textBoxSearchSP.TabIndex = 48;
            this.textBoxSearchSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchSP_KeyPress);
            // 
            // dataGridViewSP
            // 
            this.dataGridViewSP.AllowUserToAddRows = false;
            this.dataGridViewSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSP.Location = new System.Drawing.Point(10, 104);
            this.dataGridViewSP.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSP.MultiSelect = false;
            this.dataGridViewSP.Name = "dataGridViewSP";
            this.dataGridViewSP.ReadOnly = true;
            this.dataGridViewSP.RowHeadersVisible = false;
            this.dataGridViewSP.RowTemplate.Height = 24;
            this.dataGridViewSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSP.Size = new System.Drawing.Size(424, 317);
            this.dataGridViewSP.TabIndex = 400;
            this.dataGridViewSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSP_CellClick);
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.groupBox1);
            this.tabPageProduct.Controls.Add(this.lblErrorProductAdminFields);
            this.tabPageProduct.Controls.Add(this.lblErrorProductSearch);
            this.tabPageProduct.Controls.Add(this.btnGetAllProductAdmin);
            this.tabPageProduct.Controls.Add(this.dataGridViewDeletedPa);
            this.tabPageProduct.Controls.Add(this.lblSearchDeletedPa);
            this.tabPageProduct.Controls.Add(this.lblSearchPa);
            this.tabPageProduct.Controls.Add(this.btnSearchProductAdmin);
            this.tabPageProduct.Controls.Add(this.textBoxSearchPa);
            this.tabPageProduct.Controls.Add(this.dataGridViewPa);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 22);
            this.tabPageProduct.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageProduct.Size = new System.Drawing.Size(1134, 517);
            this.tabPageProduct.TabIndex = 2;
            this.tabPageProduct.Text = "Product administration";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPaName);
            this.groupBox1.Controls.Add(this.textBoxPaPrNr);
            this.groupBox1.Controls.Add(this.btnAddNewProduct);
            this.groupBox1.Controls.Add(this.lblPaInPrice);
            this.groupBox1.Controls.Add(this.lblPaOutPrice);
            this.groupBox1.Controls.Add(this.btnUpdateProduct);
            this.groupBox1.Controls.Add(this.textBoxPaAmount);
            this.groupBox1.Controls.Add(this.lblPaName);
            this.groupBox1.Controls.Add(this.lblPaAmount);
            this.groupBox1.Controls.Add(this.lblPaPrNr);
            this.groupBox1.Controls.Add(this.checkBoxForSale);
            this.groupBox1.Controls.Add(this.textBoxPaInPrice);
            this.groupBox1.Controls.Add(this.btnClearAllProductFields);
            this.groupBox1.Controls.Add(this.textBoxPaOutPrice);
            this.groupBox1.Location = new System.Drawing.Point(479, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 357);
            this.groupBox1.TabIndex = 404;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Handle Product";
            // 
            // textBoxPaName
            // 
            this.textBoxPaName.Location = new System.Drawing.Point(12, 73);
            this.textBoxPaName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPaName.Name = "textBoxPaName";
            this.textBoxPaName.Size = new System.Drawing.Size(151, 20);
            this.textBoxPaName.TabIndex = 95;
            // 
            // textBoxPaPrNr
            // 
            this.textBoxPaPrNr.Enabled = false;
            this.textBoxPaPrNr.Location = new System.Drawing.Point(12, 35);
            this.textBoxPaPrNr.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPaPrNr.Name = "textBoxPaPrNr";
            this.textBoxPaPrNr.Size = new System.Drawing.Size(151, 20);
            this.textBoxPaPrNr.TabIndex = 94;
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(47, 248);
            this.btnAddNewProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(76, 24);
            this.btnAddNewProduct.TabIndex = 100;
            this.btnAddNewProduct.Text = "New";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnPaNew_Click);
            // 
            // lblPaInPrice
            // 
            this.lblPaInPrice.AutoSize = true;
            this.lblPaInPrice.Location = new System.Drawing.Point(7, 96);
            this.lblPaInPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaInPrice.Name = "lblPaInPrice";
            this.lblPaInPrice.Size = new System.Drawing.Size(45, 13);
            this.lblPaInPrice.TabIndex = 103;
            this.lblPaInPrice.Text = "In price:";
            // 
            // lblPaOutPrice
            // 
            this.lblPaOutPrice.AutoSize = true;
            this.lblPaOutPrice.Location = new System.Drawing.Point(9, 134);
            this.lblPaOutPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaOutPrice.Name = "lblPaOutPrice";
            this.lblPaOutPrice.Size = new System.Drawing.Size(54, 13);
            this.lblPaOutPrice.TabIndex = 104;
            this.lblPaOutPrice.Text = "Out Price:";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(47, 276);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(76, 24);
            this.btnUpdateProduct.TabIndex = 101;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnPaUpdate_Click);
            // 
            // textBoxPaAmount
            // 
            this.textBoxPaAmount.Location = new System.Drawing.Point(12, 187);
            this.textBoxPaAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPaAmount.Name = "textBoxPaAmount";
            this.textBoxPaAmount.Size = new System.Drawing.Size(151, 20);
            this.textBoxPaAmount.TabIndex = 98;
            // 
            // lblPaName
            // 
            this.lblPaName.AutoSize = true;
            this.lblPaName.Location = new System.Drawing.Point(7, 58);
            this.lblPaName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaName.Name = "lblPaName";
            this.lblPaName.Size = new System.Drawing.Size(38, 13);
            this.lblPaName.TabIndex = 102;
            this.lblPaName.Text = "Name:";
            // 
            // lblPaAmount
            // 
            this.lblPaAmount.AutoSize = true;
            this.lblPaAmount.Location = new System.Drawing.Point(9, 172);
            this.lblPaAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaAmount.Name = "lblPaAmount";
            this.lblPaAmount.Size = new System.Drawing.Size(46, 13);
            this.lblPaAmount.TabIndex = 110;
            this.lblPaAmount.Text = "Amount:";
            // 
            // lblPaPrNr
            // 
            this.lblPaPrNr.AutoSize = true;
            this.lblPaPrNr.Location = new System.Drawing.Point(8, 20);
            this.lblPaPrNr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPaPrNr.Name = "lblPaPrNr";
            this.lblPaPrNr.Size = new System.Drawing.Size(47, 13);
            this.lblPaPrNr.TabIndex = 101;
            this.lblPaPrNr.Text = "Number:";
            // 
            // checkBoxForSale
            // 
            this.checkBoxForSale.AutoSize = true;
            this.checkBoxForSale.Location = new System.Drawing.Point(10, 213);
            this.checkBoxForSale.Name = "checkBoxForSale";
            this.checkBoxForSale.Size = new System.Drawing.Size(76, 17);
            this.checkBoxForSale.TabIndex = 99;
            this.checkBoxForSale.Text = "Is For Sale";
            this.checkBoxForSale.UseVisualStyleBackColor = true;
            // 
            // textBoxPaInPrice
            // 
            this.textBoxPaInPrice.Location = new System.Drawing.Point(12, 111);
            this.textBoxPaInPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPaInPrice.Name = "textBoxPaInPrice";
            this.textBoxPaInPrice.Size = new System.Drawing.Size(151, 20);
            this.textBoxPaInPrice.TabIndex = 96;
            // 
            // btnClearAllProductFields
            // 
            this.btnClearAllProductFields.Location = new System.Drawing.Point(47, 304);
            this.btnClearAllProductFields.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearAllProductFields.Name = "btnClearAllProductFields";
            this.btnClearAllProductFields.Size = new System.Drawing.Size(76, 42);
            this.btnClearAllProductFields.TabIndex = 102;
            this.btnClearAllProductFields.Text = "Clear all fields";
            this.btnClearAllProductFields.UseVisualStyleBackColor = true;
            this.btnClearAllProductFields.Click += new System.EventHandler(this.btnPaClearAll_Click);
            // 
            // textBoxPaOutPrice
            // 
            this.textBoxPaOutPrice.Location = new System.Drawing.Point(12, 149);
            this.textBoxPaOutPrice.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPaOutPrice.Name = "textBoxPaOutPrice";
            this.textBoxPaOutPrice.Size = new System.Drawing.Size(151, 20);
            this.textBoxPaOutPrice.TabIndex = 97;
            // 
            // lblErrorProductAdminFields
            // 
            this.lblErrorProductAdminFields.AutoSize = true;
            this.lblErrorProductAdminFields.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProductAdminFields.Location = new System.Drawing.Point(486, 56);
            this.lblErrorProductAdminFields.Name = "lblErrorProductAdminFields";
            this.lblErrorProductAdminFields.Size = new System.Drawing.Size(88, 13);
            this.lblErrorProductAdminFields.TabIndex = 117;
            this.lblErrorProductAdminFields.Text = "felmedelande här";
            // 
            // lblErrorProductSearch
            // 
            this.lblErrorProductSearch.AutoSize = true;
            this.lblErrorProductSearch.ForeColor = System.Drawing.Color.Red;
            this.lblErrorProductSearch.Location = new System.Drawing.Point(138, 37);
            this.lblErrorProductSearch.Name = "lblErrorProductSearch";
            this.lblErrorProductSearch.Size = new System.Drawing.Size(88, 13);
            this.lblErrorProductSearch.TabIndex = 116;
            this.lblErrorProductSearch.Text = "felmedelande här";
            // 
            // btnGetAllProductAdmin
            // 
            this.btnGetAllProductAdmin.Location = new System.Drawing.Point(401, 56);
            this.btnGetAllProductAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetAllProductAdmin.Name = "btnGetAllProductAdmin";
            this.btnGetAllProductAdmin.Size = new System.Drawing.Size(64, 42);
            this.btnGetAllProductAdmin.TabIndex = 93;
            this.btnGetAllProductAdmin.Text = "Get All";
            this.btnGetAllProductAdmin.UseVisualStyleBackColor = true;
            this.btnGetAllProductAdmin.Click += new System.EventHandler(this.btnGetAllPa_Click);
            // 
            // dataGridViewDeletedPa
            // 
            this.dataGridViewDeletedPa.AllowUserToAddRows = false;
            this.dataGridViewDeletedPa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeletedPa.Location = new System.Drawing.Point(669, 103);
            this.dataGridViewDeletedPa.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewDeletedPa.Name = "dataGridViewDeletedPa";
            this.dataGridViewDeletedPa.ReadOnly = true;
            this.dataGridViewDeletedPa.RowHeadersVisible = false;
            this.dataGridViewDeletedPa.RowTemplate.Height = 24;
            this.dataGridViewDeletedPa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDeletedPa.Size = new System.Drawing.Size(458, 317);
            this.dataGridViewDeletedPa.TabIndex = 403;
            this.dataGridViewDeletedPa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeletedPa_CellClick_1);
            // 
            // lblSearchDeletedPa
            // 
            this.lblSearchDeletedPa.AutoSize = true;
            this.lblSearchDeletedPa.Location = new System.Drawing.Point(666, 85);
            this.lblSearchDeletedPa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchDeletedPa.Name = "lblSearchDeletedPa";
            this.lblSearchDeletedPa.Size = new System.Drawing.Size(147, 13);
            this.lblSearchDeletedPa.TabIndex = 108;
            this.lblSearchDeletedPa.Text = "Products not currently for sale";
            // 
            // lblSearchPa
            // 
            this.lblSearchPa.AutoSize = true;
            this.lblSearchPa.Location = new System.Drawing.Point(8, 37);
            this.lblSearchPa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchPa.Name = "lblSearchPa";
            this.lblSearchPa.Size = new System.Drawing.Size(124, 13);
            this.lblSearchPa.TabIndex = 93;
            this.lblSearchPa.Text = "Search product attribute:";
            // 
            // btnSearchProductAdmin
            // 
            this.btnSearchProductAdmin.Location = new System.Drawing.Point(333, 56);
            this.btnSearchProductAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchProductAdmin.Name = "btnSearchProductAdmin";
            this.btnSearchProductAdmin.Size = new System.Drawing.Size(64, 42);
            this.btnSearchProductAdmin.TabIndex = 92;
            this.btnSearchProductAdmin.Text = "Search";
            this.btnSearchProductAdmin.UseVisualStyleBackColor = true;
            this.btnSearchProductAdmin.Click += new System.EventHandler(this.btnSearchPa_Click);
            // 
            // textBoxSearchPa
            // 
            this.textBoxSearchPa.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearchPa.Location = new System.Drawing.Point(7, 56);
            this.textBoxSearchPa.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSearchPa.Name = "textBoxSearchPa";
            this.textBoxSearchPa.Size = new System.Drawing.Size(322, 44);
            this.textBoxSearchPa.TabIndex = 91;
            this.textBoxSearchPa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearchPa_KeyPress);
            // 
            // dataGridViewPa
            // 
            this.dataGridViewPa.AllowUserToAddRows = false;
            this.dataGridViewPa.AllowUserToResizeColumns = false;
            this.dataGridViewPa.AllowUserToResizeRows = false;
            this.dataGridViewPa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPa.Location = new System.Drawing.Point(7, 103);
            this.dataGridViewPa.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewPa.Name = "dataGridViewPa";
            this.dataGridViewPa.ReadOnly = true;
            this.dataGridViewPa.RowHeadersVisible = false;
            this.dataGridViewPa.RowTemplate.Height = 24;
            this.dataGridViewPa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPa.Size = new System.Drawing.Size(458, 317);
            this.dataGridViewPa.TabIndex = 402;
            this.dataGridViewPa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPa_CellClick);
            // 
            // tabPageHistory
            // 
            this.tabPageHistory.Controls.Add(this.btnHAGetSales);
            this.tabPageHistory.Controls.Add(this.groupBoxSelect);
            this.tabPageHistory.Controls.Add(this.groupBoxBetween);
            this.tabPageHistory.Controls.Add(this.btnHAViewSaleLines);
            this.tabPageHistory.Controls.Add(this.dataGridViewHistory2);
            this.tabPageHistory.Controls.Add(this.dataGridViewHistory1);
            this.tabPageHistory.Location = new System.Drawing.Point(4, 22);
            this.tabPageHistory.Name = "tabPageHistory";
            this.tabPageHistory.Size = new System.Drawing.Size(1134, 517);
            this.tabPageHistory.TabIndex = 4;
            this.tabPageHistory.Text = "History administration";
            this.tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // btnHAGetSales
            // 
            this.btnHAGetSales.Location = new System.Drawing.Point(425, 48);
            this.btnHAGetSales.Name = "btnHAGetSales";
            this.btnHAGetSales.Size = new System.Drawing.Size(67, 48);
            this.btnHAGetSales.TabIndex = 11;
            this.btnHAGetSales.Text = "Get Sales";
            this.btnHAGetSales.UseVisualStyleBackColor = true;
            this.btnHAGetSales.Click += new System.EventHandler(this.btnHAGetSales_Click);
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.comboBoxEmployees);
            this.groupBoxSelect.Location = new System.Drawing.Point(23, 41);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(148, 55);
            this.groupBoxSelect.TabIndex = 10;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Select employee(s)";
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Items.AddRange(new object[] {
            "All employees"});
            this.comboBoxEmployees.Location = new System.Drawing.Point(6, 22);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(136, 21);
            this.comboBoxEmployees.TabIndex = 3;
            this.comboBoxEmployees.Text = "All employees";
            // 
            // groupBoxBetween
            // 
            this.groupBoxBetween.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxBetween.Controls.Add(this.dateTimePickerStart);
            this.groupBoxBetween.Controls.Add(this.lblAnd);
            this.groupBoxBetween.Location = new System.Drawing.Point(177, 41);
            this.groupBoxBetween.Name = "groupBoxBetween";
            this.groupBoxBetween.Size = new System.Drawing.Size(242, 55);
            this.groupBoxBetween.TabIndex = 9;
            this.groupBoxBetween.TabStop = false;
            this.groupBoxBetween.Text = "Between";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(138, 22);
            this.dateTimePickerEnd.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(92, 20);
            this.dateTimePickerEnd.TabIndex = 4;
            this.dateTimePickerEnd.Value = new System.DateTime(2014, 2, 8, 13, 6, 31, 0);
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(9, 22);
            this.dateTimePickerStart.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(92, 20);
            this.dateTimePickerStart.TabIndex = 2;
            this.dateTimePickerStart.Value = new System.DateTime(2014, 1, 1, 0, 0, 0, 0);
            // 
            // lblAnd
            // 
            this.lblAnd.AutoSize = true;
            this.lblAnd.Location = new System.Drawing.Point(107, 24);
            this.lblAnd.Name = "lblAnd";
            this.lblAnd.Size = new System.Drawing.Size(25, 13);
            this.lblAnd.TabIndex = 6;
            this.lblAnd.Text = "and";
            // 
            // btnHAViewSaleLines
            // 
            this.btnHAViewSaleLines.Location = new System.Drawing.Point(531, 271);
            this.btnHAViewSaleLines.Name = "btnHAViewSaleLines";
            this.btnHAViewSaleLines.Size = new System.Drawing.Size(75, 46);
            this.btnHAViewSaleLines.TabIndex = 8;
            this.btnHAViewSaleLines.Text = "View Sale Lines";
            this.btnHAViewSaleLines.UseVisualStyleBackColor = true;
            this.btnHAViewSaleLines.Click += new System.EventHandler(this.btnHAViewSaleLines_Click);
            // 
            // dataGridViewHistory2
            // 
            this.dataGridViewHistory2.AllowUserToAddRows = false;
            this.dataGridViewHistory2.AllowUserToDeleteRows = false;
            this.dataGridViewHistory2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory2.ColumnHeadersVisible = false;
            this.dataGridViewHistory2.Location = new System.Drawing.Point(643, 102);
            this.dataGridViewHistory2.MultiSelect = false;
            this.dataGridViewHistory2.Name = "dataGridViewHistory2";
            this.dataGridViewHistory2.ReadOnly = true;
            this.dataGridViewHistory2.RowHeadersVisible = false;
            this.dataGridViewHistory2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistory2.Size = new System.Drawing.Size(469, 389);
            this.dataGridViewHistory2.TabIndex = 1;
            // 
            // dataGridViewHistory1
            // 
            this.dataGridViewHistory1.AllowUserToAddRows = false;
            this.dataGridViewHistory1.AllowUserToDeleteRows = false;
            this.dataGridViewHistory1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory1.Location = new System.Drawing.Point(23, 102);
            this.dataGridViewHistory1.MultiSelect = false;
            this.dataGridViewHistory1.Name = "dataGridViewHistory1";
            this.dataGridViewHistory1.ReadOnly = true;
            this.dataGridViewHistory1.RowHeadersVisible = false;
            this.dataGridViewHistory1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHistory1.Size = new System.Drawing.Size(469, 389);
            this.dataGridViewHistory1.TabIndex = 0;
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.BackColor = System.Drawing.Color.LightGray;
            this.tabPageStatistics.Controls.Add(this.dataGridViewStatistics);
            this.tabPageStatistics.Controls.Add(this.btnTopProduct);
            this.tabPageStatistics.Controls.Add(this.btnTopCombos);
            this.tabPageStatistics.Controls.Add(this.btnTopSellers);
            this.tabPageStatistics.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 22);
            this.tabPageStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageStatistics.Size = new System.Drawing.Size(1134, 517);
            this.tabPageStatistics.TabIndex = 3;
            this.tabPageStatistics.Text = "Statistics";
            // 
            // dataGridViewStatistics
            // 
            this.dataGridViewStatistics.AllowUserToAddRows = false;
            this.dataGridViewStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistics.Location = new System.Drawing.Point(7, 95);
            this.dataGridViewStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewStatistics.Name = "dataGridViewStatistics";
            this.dataGridViewStatistics.ReadOnly = true;
            this.dataGridViewStatistics.RowHeadersVisible = false;
            this.dataGridViewStatistics.RowTemplate.Height = 24;
            this.dataGridViewStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStatistics.Size = new System.Drawing.Size(467, 317);
            this.dataGridViewStatistics.TabIndex = 116;
            // 
            // btnTopProduct
            // 
            this.btnTopProduct.Location = new System.Drawing.Point(108, 43);
            this.btnTopProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnTopProduct.Name = "btnTopProduct";
            this.btnTopProduct.Size = new System.Drawing.Size(80, 36);
            this.btnTopProduct.TabIndex = 115;
            this.btnTopProduct.Text = "Top Products";
            this.btnTopProduct.UseVisualStyleBackColor = true;
            this.btnTopProduct.Click += new System.EventHandler(this.btnTopProduct_Click);
            // 
            // btnTopCombos
            // 
            this.btnTopCombos.Location = new System.Drawing.Point(210, 43);
            this.btnTopCombos.Margin = new System.Windows.Forms.Padding(2);
            this.btnTopCombos.Name = "btnTopCombos";
            this.btnTopCombos.Size = new System.Drawing.Size(80, 36);
            this.btnTopCombos.TabIndex = 114;
            this.btnTopCombos.Text = "Highest Sale";
            this.btnTopCombos.UseVisualStyleBackColor = true;
            this.btnTopCombos.Click += new System.EventHandler(this.btnTopCombos_Click);
            // 
            // btnTopSellers
            // 
            this.btnTopSellers.Location = new System.Drawing.Point(7, 43);
            this.btnTopSellers.Margin = new System.Windows.Forms.Padding(2);
            this.btnTopSellers.Name = "btnTopSellers";
            this.btnTopSellers.Size = new System.Drawing.Size(82, 36);
            this.btnTopSellers.TabIndex = 113;
            this.btnTopSellers.Text = "Top Sellers";
            this.btnTopSellers.UseVisualStyleBackColor = true;
            this.btnTopSellers.Click += new System.EventHandler(this.btnTopSellers_Click);
            // 
            // lblLoggedInAs
            // 
            this.lblLoggedInAs.AutoSize = true;
            this.lblLoggedInAs.Location = new System.Drawing.Point(9, 3);
            this.lblLoggedInAs.Name = "lblLoggedInAs";
            this.lblLoggedInAs.Size = new System.Drawing.Size(74, 13);
            this.lblLoggedInAs.TabIndex = 45;
            this.lblLoggedInAs.Text = "lblLoggedInAs";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLoggedInAs);
            this.panel1.Location = new System.Drawing.Point(4, 568);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 22);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AffAIRS system";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPageSale.ResumeLayout(false);
            this.tabPageSale.PerformLayout();
            this.groupBoxTotalPrice.ResumeLayout(false);
            this.groupBoxTotalPrice.PerformLayout();
            this.groupBoxCurrencys.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.tabPageEmployee.ResumeLayout(false);
            this.tabPageEmployee.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletedSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSP)).EndInit();
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeletedPa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPa)).EndInit();
            this.tabPageHistory.ResumeLayout(false);
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxBetween.ResumeLayout(false);
            this.groupBoxBetween.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory1)).EndInit();
            this.tabPageStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistics)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSale;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.TabPage tabPageProduct;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabPage tabPageStatistics;
        private System.Windows.Forms.DataGridView dataGridViewProductList;
        private System.Windows.Forms.RichTextBox richTextBoxAmount;
        private System.Windows.Forms.Button btnRemoveProductFromSale;
        private System.Windows.Forms.Button btwAddProductToSale;
        private System.Windows.Forms.TextBox textBoxNumPad;
        private System.Windows.Forms.Button btnRegisterSale;
        private System.Windows.Forms.Button btnNOK;
        private System.Windows.Forms.Button btnUSD;
        private System.Windows.Forms.Button btnGBP;
        private System.Windows.Forms.Button btnEURO;
        private System.Windows.Forms.Button btnDKK;
        private System.Windows.Forms.Button btnSEK;
        private System.Windows.Forms.DataGridView dataGridViewSaleList;
        private System.Windows.Forms.Button btnSearchProductSalesTab;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.Label lblSearchProduct;
        private System.Windows.Forms.Label lblSearchSP;
        private System.Windows.Forms.Button btnSearchSalesPerson;
        private System.Windows.Forms.TextBox textBoxSearchSP;
        private System.Windows.Forms.DataGridView dataGridViewSP;
        private System.Windows.Forms.Button btnUpdateSalesPerson;
        private System.Windows.Forms.Button btnAddNewSalesPerson;
        private System.Windows.Forms.TextBox textBoxEaLName;
        private System.Windows.Forms.TextBox textBoxEaPhoneNr;
        private System.Windows.Forms.TextBox textBoxEaFName;
        private System.Windows.Forms.TextBox textBoxEaSpNr;
        private System.Windows.Forms.Label lblSearchDeletedSP;
        
        private System.Windows.Forms.DataGridView dataGridViewDeletedSP;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelEaPhoneNr;
        private System.Windows.Forms.Label labelEaLName;
        private System.Windows.Forms.Label labelEaFName;
        private System.Windows.Forms.Label labelEaSpNr;
        private System.Windows.Forms.Label lblPaAmount;
        private System.Windows.Forms.TextBox textBoxPaAmount;
        private System.Windows.Forms.Label lblSearchDeletedPa;
        
      
        private System.Windows.Forms.Label lblPaOutPrice;
        private System.Windows.Forms.Label lblPaInPrice;
        private System.Windows.Forms.Label lblPaName;
        private System.Windows.Forms.Label lblPaPrNr;
        private System.Windows.Forms.TextBox textBoxPaInPrice;
        private System.Windows.Forms.TextBox textBoxPaOutPrice;
        private System.Windows.Forms.TextBox textBoxPaName;
        private System.Windows.Forms.TextBox textBoxPaPrNr;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Label lblSearchPa;
        private System.Windows.Forms.Button btnSearchProductAdmin;
        private System.Windows.Forms.TextBox textBoxSearchPa;
        private System.Windows.Forms.DataGridView dataGridViewPa;
        private System.Windows.Forms.DataGridView dataGridViewDeletedPa;
        private System.Windows.Forms.DataGridView dataGridViewStatistics;
        private System.Windows.Forms.Button btnTopProduct;
        private System.Windows.Forms.Button btnTopCombos;
        private System.Windows.Forms.Button btnTopSellers;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnClearAllSaleView;
        private System.Windows.Forms.Button btnMyHistory;
        private System.Windows.Forms.Button btnClearAllSalesPersonFields;
        private System.Windows.Forms.Button btnClearAllProductFields;
        private System.Windows.Forms.Label lblLoggedInAs;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.CheckBox checkBoxForSale;
        private System.Windows.Forms.Button btnGetAllProductAdmin;
        private System.Windows.Forms.TextBox textBoxCurrencyUnit;
        private System.Windows.Forms.Label lblErrorSaleSearch;
        private System.Windows.Forms.Label lblErrorProductSearch;
        private System.Windows.Forms.Button btnGetAllWorkingSalesPersons;
        private System.Windows.Forms.CheckBox checkBoxEmployee;
        private System.Windows.Forms.CheckBox checkBoxEmployeeAdmin;
        private System.Windows.Forms.Label lblErrorSalesPersonSearch;
        private System.Windows.Forms.Button btnViewSale;
        private System.Windows.Forms.Label lblErrorProductAdminFields;
        private System.Windows.Forms.Label lblErrorSalesPersonFields;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DataGridView dataGridViewHistory2;
        private System.Windows.Forms.DataGridView dataGridViewHistory1;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox comboBoxEmployees;
        private System.Windows.Forms.Button btnHAViewSaleLines;
        private System.Windows.Forms.Label lblAnd;
        private System.Windows.Forms.GroupBox groupBoxBetween;
        private System.Windows.Forms.Button btnHAGetSales;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.GroupBox groupBoxCurrencys;
        private System.Windows.Forms.GroupBox groupBoxTotalPrice;


    }
}

