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
            this.labelSearchProduct = new System.Windows.Forms.Label();
            this.buttonSearchProduct = new System.Windows.Forms.Button();
            this.textBoxSearchProduct = new System.Windows.Forms.TextBox();
            this.textBoxNumPad = new System.Windows.Forms.TextBox();
            this.buttonDELETE = new System.Windows.Forms.Button();
            this.buttonENTER = new System.Windows.Forms.Button();
            this.buttonNPDECIMAL = new System.Windows.Forms.Button();
            this.buttonNP0 = new System.Windows.Forms.Button();
            this.buttonNP9 = new System.Windows.Forms.Button();
            this.buttonNP8 = new System.Windows.Forms.Button();
            this.buttonNP7 = new System.Windows.Forms.Button();
            this.buttonNP6 = new System.Windows.Forms.Button();
            this.buttonNP5 = new System.Windows.Forms.Button();
            this.buttonNP4 = new System.Windows.Forms.Button();
            this.buttonNP2 = new System.Windows.Forms.Button();
            this.buttonNP3 = new System.Windows.Forms.Button();
            this.buttonNP1 = new System.Windows.Forms.Button();
            this.buttonNOK = new System.Windows.Forms.Button();
            this.buttonUSD = new System.Windows.Forms.Button();
            this.buttonGBP = new System.Windows.Forms.Button();
            this.buttonEURO = new System.Windows.Forms.Button();
            this.buttonDKK = new System.Windows.Forms.Button();
            this.buttonSEK = new System.Windows.Forms.Button();
            this.dataGridViewSaleList = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewProductList = new System.Windows.Forms.DataGridView();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.tabPageStatistics = new System.Windows.Forms.TabPage();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxspNr = new System.Windows.Forms.TextBox();
            this.textBoxfirstName = new System.Windows.Forms.TextBox();
            this.textBoxlastName = new System.Windows.Forms.TextBox();
            this.textBoxsPhone = new System.Windows.Forms.TextBox();
            this.buttonAddSalesPerson = new System.Windows.Forms.Button();
            this.buttonDeleteSalesPerson = new System.Windows.Forms.Button();
            this.buttonUpdateSalesPerson = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).BeginInit();
            this.tabPageEmployee.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSale);
            this.tabControl.Controls.Add(this.tabPageEmployee);
            this.tabControl.Controls.Add(this.tabPageProduct);
            this.tabControl.Controls.Add(this.tabPageStatistics);
            this.tabControl.Location = new System.Drawing.Point(0, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1523, 584);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageSale
            // 
            this.tabPageSale.Controls.Add(this.labelSearchProduct);
            this.tabPageSale.Controls.Add(this.buttonSearchProduct);
            this.tabPageSale.Controls.Add(this.textBoxSearchProduct);
            this.tabPageSale.Controls.Add(this.textBoxNumPad);
            this.tabPageSale.Controls.Add(this.buttonDELETE);
            this.tabPageSale.Controls.Add(this.buttonENTER);
            this.tabPageSale.Controls.Add(this.buttonNPDECIMAL);
            this.tabPageSale.Controls.Add(this.buttonNP0);
            this.tabPageSale.Controls.Add(this.buttonNP9);
            this.tabPageSale.Controls.Add(this.buttonNP8);
            this.tabPageSale.Controls.Add(this.buttonNP7);
            this.tabPageSale.Controls.Add(this.buttonNP6);
            this.tabPageSale.Controls.Add(this.buttonNP5);
            this.tabPageSale.Controls.Add(this.buttonNP4);
            this.tabPageSale.Controls.Add(this.buttonNP2);
            this.tabPageSale.Controls.Add(this.buttonNP3);
            this.tabPageSale.Controls.Add(this.buttonNP1);
            this.tabPageSale.Controls.Add(this.buttonNOK);
            this.tabPageSale.Controls.Add(this.buttonUSD);
            this.tabPageSale.Controls.Add(this.buttonGBP);
            this.tabPageSale.Controls.Add(this.buttonEURO);
            this.tabPageSale.Controls.Add(this.buttonDKK);
            this.tabPageSale.Controls.Add(this.buttonSEK);
            this.tabPageSale.Controls.Add(this.dataGridViewSaleList);
            this.tabPageSale.Controls.Add(this.richTextBox1);
            this.tabPageSale.Controls.Add(this.button);
            this.tabPageSale.Controls.Add(this.button1);
            this.tabPageSale.Controls.Add(this.dataGridViewProductList);
            this.tabPageSale.Location = new System.Drawing.Point(4, 25);
            this.tabPageSale.Name = "tabPageSale";
            this.tabPageSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSale.Size = new System.Drawing.Size(1515, 555);
            this.tabPageSale.TabIndex = 0;
            this.tabPageSale.Text = "Sale menu";
            this.tabPageSale.UseVisualStyleBackColor = true;
            this.tabPageSale.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // labelSearchProduct
            // 
            this.labelSearchProduct.AutoSize = true;
            this.labelSearchProduct.Location = new System.Drawing.Point(9, 43);
            this.labelSearchProduct.Name = "labelSearchProduct";
            this.labelSearchProduct.Size = new System.Drawing.Size(185, 17);
            this.labelSearchProduct.TabIndex = 41;
            this.labelSearchProduct.Text = "Search on product attribute:";
            // 
            // buttonSearchProduct
            // 
            this.buttonSearchProduct.Location = new System.Drawing.Point(298, 66);
            this.buttonSearchProduct.Name = "buttonSearchProduct";
            this.buttonSearchProduct.Size = new System.Drawing.Size(85, 52);
            this.buttonSearchProduct.TabIndex = 40;
            this.buttonSearchProduct.Text = "Search";
            this.buttonSearchProduct.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchProduct
            // 
            this.textBoxSearchProduct.Location = new System.Drawing.Point(8, 66);
            this.textBoxSearchProduct.Multiline = true;
            this.textBoxSearchProduct.Name = "textBoxSearchProduct";
            this.textBoxSearchProduct.Size = new System.Drawing.Size(284, 52);
            this.textBoxSearchProduct.TabIndex = 39;
            // 
            // textBoxNumPad
            // 
            this.textBoxNumPad.Location = new System.Drawing.Point(864, 240);
            this.textBoxNumPad.Multiline = true;
            this.textBoxNumPad.Name = "textBoxNumPad";
            this.textBoxNumPad.Size = new System.Drawing.Size(274, 52);
            this.textBoxNumPad.TabIndex = 38;
            // 
            // buttonDELETE
            // 
            this.buttonDELETE.Location = new System.Drawing.Point(1032, 296);
            this.buttonDELETE.Name = "buttonDELETE";
            this.buttonDELETE.Size = new System.Drawing.Size(106, 50);
            this.buttonDELETE.TabIndex = 37;
            this.buttonDELETE.Text = "<-";
            this.buttonDELETE.UseVisualStyleBackColor = true;
            // 
            // buttonENTER
            // 
            this.buttonENTER.Location = new System.Drawing.Point(1032, 352);
            this.buttonENTER.Name = "buttonENTER";
            this.buttonENTER.Size = new System.Drawing.Size(106, 162);
            this.buttonENTER.TabIndex = 36;
            this.buttonENTER.Text = "ENTER";
            this.buttonENTER.UseVisualStyleBackColor = true;
            // 
            // buttonNPDECIMAL
            // 
            this.buttonNPDECIMAL.Location = new System.Drawing.Point(976, 464);
            this.buttonNPDECIMAL.Name = "buttonNPDECIMAL";
            this.buttonNPDECIMAL.Size = new System.Drawing.Size(50, 50);
            this.buttonNPDECIMAL.TabIndex = 35;
            this.buttonNPDECIMAL.Text = ".";
            this.buttonNPDECIMAL.UseVisualStyleBackColor = true;
            // 
            // buttonNP0
            // 
            this.buttonNP0.Location = new System.Drawing.Point(864, 464);
            this.buttonNP0.Name = "buttonNP0";
            this.buttonNP0.Size = new System.Drawing.Size(106, 50);
            this.buttonNP0.TabIndex = 34;
            this.buttonNP0.Text = "0";
            this.buttonNP0.UseVisualStyleBackColor = true;
            // 
            // buttonNP9
            // 
            this.buttonNP9.Location = new System.Drawing.Point(976, 296);
            this.buttonNP9.Name = "buttonNP9";
            this.buttonNP9.Size = new System.Drawing.Size(50, 50);
            this.buttonNP9.TabIndex = 33;
            this.buttonNP9.Text = "9";
            this.buttonNP9.UseVisualStyleBackColor = true;
            // 
            // buttonNP8
            // 
            this.buttonNP8.Location = new System.Drawing.Point(920, 296);
            this.buttonNP8.Name = "buttonNP8";
            this.buttonNP8.Size = new System.Drawing.Size(50, 50);
            this.buttonNP8.TabIndex = 32;
            this.buttonNP8.Text = "8";
            this.buttonNP8.UseVisualStyleBackColor = true;
            // 
            // buttonNP7
            // 
            this.buttonNP7.Location = new System.Drawing.Point(864, 296);
            this.buttonNP7.Name = "buttonNP7";
            this.buttonNP7.Size = new System.Drawing.Size(50, 50);
            this.buttonNP7.TabIndex = 31;
            this.buttonNP7.Text = "7";
            this.buttonNP7.UseVisualStyleBackColor = true;
            // 
            // buttonNP6
            // 
            this.buttonNP6.Location = new System.Drawing.Point(976, 352);
            this.buttonNP6.Name = "buttonNP6";
            this.buttonNP6.Size = new System.Drawing.Size(50, 50);
            this.buttonNP6.TabIndex = 30;
            this.buttonNP6.Text = "6";
            this.buttonNP6.UseVisualStyleBackColor = true;
            // 
            // buttonNP5
            // 
            this.buttonNP5.Location = new System.Drawing.Point(920, 352);
            this.buttonNP5.Name = "buttonNP5";
            this.buttonNP5.Size = new System.Drawing.Size(50, 50);
            this.buttonNP5.TabIndex = 29;
            this.buttonNP5.Text = "5";
            this.buttonNP5.UseVisualStyleBackColor = true;
            // 
            // buttonNP4
            // 
            this.buttonNP4.Location = new System.Drawing.Point(864, 352);
            this.buttonNP4.Name = "buttonNP4";
            this.buttonNP4.Size = new System.Drawing.Size(50, 50);
            this.buttonNP4.TabIndex = 28;
            this.buttonNP4.Text = "4";
            this.buttonNP4.UseVisualStyleBackColor = true;
            // 
            // buttonNP2
            // 
            this.buttonNP2.Location = new System.Drawing.Point(920, 408);
            this.buttonNP2.Name = "buttonNP2";
            this.buttonNP2.Size = new System.Drawing.Size(50, 50);
            this.buttonNP2.TabIndex = 27;
            this.buttonNP2.Text = "2";
            this.buttonNP2.UseVisualStyleBackColor = true;
            // 
            // buttonNP3
            // 
            this.buttonNP3.Location = new System.Drawing.Point(976, 408);
            this.buttonNP3.Name = "buttonNP3";
            this.buttonNP3.Size = new System.Drawing.Size(50, 50);
            this.buttonNP3.TabIndex = 26;
            this.buttonNP3.Text = "3";
            this.buttonNP3.UseVisualStyleBackColor = true;
            // 
            // buttonNP1
            // 
            this.buttonNP1.Location = new System.Drawing.Point(864, 408);
            this.buttonNP1.Name = "buttonNP1";
            this.buttonNP1.Size = new System.Drawing.Size(50, 50);
            this.buttonNP1.TabIndex = 25;
            this.buttonNP1.Text = "1";
            this.buttonNP1.UseVisualStyleBackColor = true;
            // 
            // buttonNOK
            // 
            this.buttonNOK.Location = new System.Drawing.Point(1048, 182);
            this.buttonNOK.Name = "buttonNOK";
            this.buttonNOK.Size = new System.Drawing.Size(90, 52);
            this.buttonNOK.TabIndex = 13;
            this.buttonNOK.Text = "NOK";
            this.buttonNOK.UseVisualStyleBackColor = true;
            // 
            // buttonUSD
            // 
            this.buttonUSD.Location = new System.Drawing.Point(1048, 124);
            this.buttonUSD.Name = "buttonUSD";
            this.buttonUSD.Size = new System.Drawing.Size(90, 52);
            this.buttonUSD.TabIndex = 12;
            this.buttonUSD.Text = "USD";
            this.buttonUSD.UseVisualStyleBackColor = true;
            // 
            // buttonGBP
            // 
            this.buttonGBP.Location = new System.Drawing.Point(955, 182);
            this.buttonGBP.Name = "buttonGBP";
            this.buttonGBP.Size = new System.Drawing.Size(87, 52);
            this.buttonGBP.TabIndex = 11;
            this.buttonGBP.Text = "GBP";
            this.buttonGBP.UseVisualStyleBackColor = true;
            // 
            // buttonEURO
            // 
            this.buttonEURO.Location = new System.Drawing.Point(956, 124);
            this.buttonEURO.Name = "buttonEURO";
            this.buttonEURO.Size = new System.Drawing.Size(87, 52);
            this.buttonEURO.TabIndex = 10;
            this.buttonEURO.Text = "EURO";
            this.buttonEURO.UseVisualStyleBackColor = true;
            // 
            // buttonDKK
            // 
            this.buttonDKK.Location = new System.Drawing.Point(864, 182);
            this.buttonDKK.Name = "buttonDKK";
            this.buttonDKK.Size = new System.Drawing.Size(85, 52);
            this.buttonDKK.TabIndex = 9;
            this.buttonDKK.Text = "DKK";
            this.buttonDKK.UseVisualStyleBackColor = true;
            // 
            // buttonSEK
            // 
            this.buttonSEK.Location = new System.Drawing.Point(863, 124);
            this.buttonSEK.Name = "buttonSEK";
            this.buttonSEK.Size = new System.Drawing.Size(86, 52);
            this.buttonSEK.TabIndex = 8;
            this.buttonSEK.Text = "SEK";
            this.buttonSEK.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSaleList
            // 
            this.dataGridViewSaleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSaleList.Location = new System.Drawing.Point(483, 124);
            this.dataGridViewSaleList.Name = "dataGridViewSaleList";
            this.dataGridViewSaleList.RowTemplate.Height = 24;
            this.dataGridViewSaleList.Size = new System.Drawing.Size(375, 390);
            this.dataGridViewSaleList.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(389, 293);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(85, 52);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(389, 350);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(85, 52);
            this.button.TabIndex = 5;
            this.button.Text = "<<<";
            this.button.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = ">>>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProductList
            // 
            this.dataGridViewProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductList.Location = new System.Drawing.Point(8, 124);
            this.dataGridViewProductList.Name = "dataGridViewProductList";
            this.dataGridViewProductList.RowTemplate.Height = 24;
            this.dataGridViewProductList.Size = new System.Drawing.Size(375, 390);
            this.dataGridViewProductList.TabIndex = 2;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.buttonUpdateSalesPerson);
            this.tabPageEmployee.Controls.Add(this.buttonDeleteSalesPerson);
            this.tabPageEmployee.Controls.Add(this.buttonAddSalesPerson);
            this.tabPageEmployee.Controls.Add(this.textBoxsPhone);
            this.tabPageEmployee.Controls.Add(this.textBoxlastName);
            this.tabPageEmployee.Controls.Add(this.textBoxfirstName);
            this.tabPageEmployee.Controls.Add(this.textBoxspNr);
            this.tabPageEmployee.Controls.Add(this.dataGridView1);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 25);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(1515, 555);
            this.tabPageEmployee.TabIndex = 1;
            this.tabPageEmployee.Text = "Employee administration";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            this.tabPageEmployee.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Location = new System.Drawing.Point(4, 25);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(1515, 555);
            this.tabPageProduct.TabIndex = 2;
            this.tabPageProduct.Text = "Product administration";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // tabPageStatistics
            // 
            this.tabPageStatistics.BackColor = System.Drawing.Color.LightGray;
            this.tabPageStatistics.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageStatistics.Location = new System.Drawing.Point(4, 25);
            this.tabPageStatistics.Name = "tabPageStatistics";
            this.tabPageStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStatistics.Size = new System.Drawing.Size(1515, 555);
            this.tabPageStatistics.TabIndex = 3;
            this.tabPageStatistics.Text = "Statistics";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1523, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(323, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxspNr
            // 
            this.textBoxspNr.Location = new System.Drawing.Point(131, 392);
            this.textBoxspNr.Name = "textBoxspNr";
            this.textBoxspNr.Size = new System.Drawing.Size(198, 22);
            this.textBoxspNr.TabIndex = 1;
            // 
            // textBoxfirstName
            // 
            this.textBoxfirstName.Location = new System.Drawing.Point(131, 421);
            this.textBoxfirstName.Name = "textBoxfirstName";
            this.textBoxfirstName.Size = new System.Drawing.Size(198, 22);
            this.textBoxfirstName.TabIndex = 2;
            // 
            // textBoxlastName
            // 
            this.textBoxlastName.Location = new System.Drawing.Point(131, 450);
            this.textBoxlastName.Name = "textBoxlastName";
            this.textBoxlastName.Size = new System.Drawing.Size(198, 22);
            this.textBoxlastName.TabIndex = 3;
            // 
            // textBoxsPhone
            // 
            this.textBoxsPhone.Location = new System.Drawing.Point(131, 479);
            this.textBoxsPhone.Name = "textBoxsPhone";
            this.textBoxsPhone.Size = new System.Drawing.Size(198, 22);
            this.textBoxsPhone.TabIndex = 4;
            // 
            // buttonAddSalesPerson
            // 
            this.buttonAddSalesPerson.Location = new System.Drawing.Point(349, 391);
            this.buttonAddSalesPerson.Name = "buttonAddSalesPerson";
            this.buttonAddSalesPerson.Size = new System.Drawing.Size(155, 23);
            this.buttonAddSalesPerson.TabIndex = 5;
            this.buttonAddSalesPerson.Text = "Add Sales Person";
            this.buttonAddSalesPerson.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSalesPerson
            // 
            this.buttonDeleteSalesPerson.Location = new System.Drawing.Point(349, 420);
            this.buttonDeleteSalesPerson.Name = "buttonDeleteSalesPerson";
            this.buttonDeleteSalesPerson.Size = new System.Drawing.Size(155, 23);
            this.buttonDeleteSalesPerson.TabIndex = 6;
            this.buttonDeleteSalesPerson.Text = "Delete Sales Person";
            this.buttonDeleteSalesPerson.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateSalesPerson
            // 
            this.buttonUpdateSalesPerson.Location = new System.Drawing.Point(349, 448);
            this.buttonUpdateSalesPerson.Name = "buttonUpdateSalesPerson";
            this.buttonUpdateSalesPerson.Size = new System.Drawing.Size(155, 23);
            this.buttonUpdateSalesPerson.TabIndex = 7;
            this.buttonUpdateSalesPerson.Text = "Update Sales Person";
            this.buttonUpdateSalesPerson.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 618);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPageSale.ResumeLayout(false);
            this.tabPageSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSaleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductList)).EndInit();
            this.tabPageEmployee.ResumeLayout(false);
            this.tabPageEmployee.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNumPad;
        private System.Windows.Forms.Button buttonDELETE;
        private System.Windows.Forms.Button buttonENTER;
        private System.Windows.Forms.Button buttonNPDECIMAL;
        private System.Windows.Forms.Button buttonNP0;
        private System.Windows.Forms.Button buttonNP9;
        private System.Windows.Forms.Button buttonNP8;
        private System.Windows.Forms.Button buttonNP7;
        private System.Windows.Forms.Button buttonNP6;
        private System.Windows.Forms.Button buttonNP5;
        private System.Windows.Forms.Button buttonNP4;
        private System.Windows.Forms.Button buttonNP2;
        private System.Windows.Forms.Button buttonNP3;
        private System.Windows.Forms.Button buttonNP1;
        private System.Windows.Forms.Button buttonNOK;
        private System.Windows.Forms.Button buttonUSD;
        private System.Windows.Forms.Button buttonGBP;
        private System.Windows.Forms.Button buttonEURO;
        private System.Windows.Forms.Button buttonDKK;
        private System.Windows.Forms.Button buttonSEK;
        private System.Windows.Forms.DataGridView dataGridViewSaleList;
        private System.Windows.Forms.Button buttonSearchProduct;
        private System.Windows.Forms.TextBox textBoxSearchProduct;
        private System.Windows.Forms.Label labelSearchProduct;
        private System.Windows.Forms.Button buttonUpdateSalesPerson;
        private System.Windows.Forms.Button buttonDeleteSalesPerson;
        private System.Windows.Forms.Button buttonAddSalesPerson;
        private System.Windows.Forms.TextBox textBoxsPhone;
        private System.Windows.Forms.TextBox textBoxlastName;
        private System.Windows.Forms.TextBox textBoxfirstName;
        private System.Windows.Forms.TextBox textBoxspNr;
        private System.Windows.Forms.DataGridView dataGridView1;


    }
}

