﻿namespace DividendLiberty
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbAllDividends = new System.Windows.Forms.ListBox();
            this.lbCurrentDividends = new System.Windows.Forms.ListBox();
            this.gpDividendStocks = new System.Windows.Forms.GroupBox();
            this.dtpPayDate = new System.Windows.Forms.DateTimePicker();
            this.btnPayDate = new System.Windows.Forms.Button();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.btnNextPurchase = new System.Windows.Forms.Button();
            this.chkNextBuy = new System.Windows.Forms.CheckBox();
            this.lblSearchAllSymbol = new System.Windows.Forms.Label();
            this.txtSearchAllSymbol = new System.Windows.Forms.TextBox();
            this.lblSearchSymbol = new System.Windows.Forms.Label();
            this.txtSearchSymbol = new System.Windows.Forms.TextBox();
            this.btnAllIndustryPercentages = new System.Windows.Forms.Button();
            this.btnCurrentIndustryPercentage = new System.Windows.Forms.Button();
            this.btnHighlightAll = new System.Windows.Forms.Button();
            this.lblIndustryAll = new System.Windows.Forms.Label();
            this.ddlIndustryAll = new System.Windows.Forms.ComboBox();
            this.btnHighlight = new System.Windows.Forms.Button();
            this.lblIndustry = new System.Windows.Forms.Label();
            this.ddlIndustry = new System.Windows.Forms.ComboBox();
            this.btnDividendPrice = new System.Windows.Forms.Button();
            this.btnGetSharePrice = new System.Windows.Forms.Button();
            this.lblTotalAllDividends = new System.Windows.Forms.Label();
            this.lblTotalPortfolioDividends = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gpDividendStocks.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1571, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // lbAllDividends
            // 
            this.lbAllDividends.BackColor = System.Drawing.Color.AliceBlue;
            this.lbAllDividends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllDividends.ForeColor = System.Drawing.Color.Black;
            this.lbAllDividends.FormattingEnabled = true;
            this.lbAllDividends.ItemHeight = 15;
            this.lbAllDividends.Location = new System.Drawing.Point(6, 39);
            this.lbAllDividends.Name = "lbAllDividends";
            this.lbAllDividends.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbAllDividends.Size = new System.Drawing.Size(736, 289);
            this.lbAllDividends.TabIndex = 1;
            this.lbAllDividends.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbAllDividends_MouseClick);
            this.lbAllDividends.SelectedIndexChanged += new System.EventHandler(this.lbAllDividends_SelectedIndexChanged);
            this.lbAllDividends.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbAllDividends_MouseDoubleClick);
            // 
            // lbCurrentDividends
            // 
            this.lbCurrentDividends.BackColor = System.Drawing.Color.AliceBlue;
            this.lbCurrentDividends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentDividends.ForeColor = System.Drawing.Color.Black;
            this.lbCurrentDividends.FormattingEnabled = true;
            this.lbCurrentDividends.ItemHeight = 15;
            this.lbCurrentDividends.Location = new System.Drawing.Point(805, 39);
            this.lbCurrentDividends.Name = "lbCurrentDividends";
            this.lbCurrentDividends.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbCurrentDividends.Size = new System.Drawing.Size(736, 289);
            this.lbCurrentDividends.TabIndex = 2;
            this.lbCurrentDividends.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbCurrentDividends_MouseClick);
            this.lbCurrentDividends.SelectedIndexChanged += new System.EventHandler(this.chkNextBuy_CheckedChanged);
            this.lbCurrentDividends.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbCurrentDividends_MouseDoubleClick);
            // 
            // gpDividendStocks
            // 
            this.gpDividendStocks.BackColor = System.Drawing.Color.MidnightBlue;
            this.gpDividendStocks.Controls.Add(this.dtpPayDate);
            this.gpDividendStocks.Controls.Add(this.btnPayDate);
            this.gpDividendStocks.Controls.Add(this.lblPayDate);
            this.gpDividendStocks.Controls.Add(this.btnNextPurchase);
            this.gpDividendStocks.Controls.Add(this.chkNextBuy);
            this.gpDividendStocks.Controls.Add(this.lblSearchAllSymbol);
            this.gpDividendStocks.Controls.Add(this.txtSearchAllSymbol);
            this.gpDividendStocks.Controls.Add(this.lblSearchSymbol);
            this.gpDividendStocks.Controls.Add(this.txtSearchSymbol);
            this.gpDividendStocks.Controls.Add(this.btnAllIndustryPercentages);
            this.gpDividendStocks.Controls.Add(this.btnCurrentIndustryPercentage);
            this.gpDividendStocks.Controls.Add(this.btnHighlightAll);
            this.gpDividendStocks.Controls.Add(this.lblIndustryAll);
            this.gpDividendStocks.Controls.Add(this.ddlIndustryAll);
            this.gpDividendStocks.Controls.Add(this.btnHighlight);
            this.gpDividendStocks.Controls.Add(this.lblIndustry);
            this.gpDividendStocks.Controls.Add(this.ddlIndustry);
            this.gpDividendStocks.Controls.Add(this.btnDividendPrice);
            this.gpDividendStocks.Controls.Add(this.btnGetSharePrice);
            this.gpDividendStocks.Controls.Add(this.lblTotalAllDividends);
            this.gpDividendStocks.Controls.Add(this.lblTotalPortfolioDividends);
            this.gpDividendStocks.Controls.Add(this.label2);
            this.gpDividendStocks.Controls.Add(this.label1);
            this.gpDividendStocks.Controls.Add(this.btnCalculate);
            this.gpDividendStocks.Controls.Add(this.btnRemove);
            this.gpDividendStocks.Controls.Add(this.btnAdd);
            this.gpDividendStocks.Controls.Add(this.lbAllDividends);
            this.gpDividendStocks.Controls.Add(this.lbCurrentDividends);
            this.gpDividendStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpDividendStocks.ForeColor = System.Drawing.Color.White;
            this.gpDividendStocks.Location = new System.Drawing.Point(12, 37);
            this.gpDividendStocks.Name = "gpDividendStocks";
            this.gpDividendStocks.Size = new System.Drawing.Size(1547, 366);
            this.gpDividendStocks.TabIndex = 3;
            this.gpDividendStocks.TabStop = false;
            this.gpDividendStocks.Text = "Dividend Stocks";
            // 
            // dtpPayDate
            // 
            this.dtpPayDate.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dtpPayDate.Location = new System.Drawing.Point(871, 333);
            this.dtpPayDate.Name = "dtpPayDate";
            this.dtpPayDate.Size = new System.Drawing.Size(149, 20);
            this.dtpPayDate.TabIndex = 38;
            // 
            // btnPayDate
            // 
            this.btnPayDate.ForeColor = System.Drawing.Color.Black;
            this.btnPayDate.Location = new System.Drawing.Point(1026, 332);
            this.btnPayDate.Name = "btnPayDate";
            this.btnPayDate.Size = new System.Drawing.Size(76, 23);
            this.btnPayDate.TabIndex = 37;
            this.btnPayDate.TabStop = false;
            this.btnPayDate.Text = "Highlight";
            this.btnPayDate.UseVisualStyleBackColor = true;
            this.btnPayDate.Click += new System.EventHandler(this.btnPayDate_Click);
            // 
            // lblPayDate
            // 
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayDate.ForeColor = System.Drawing.Color.White;
            this.lblPayDate.Location = new System.Drawing.Point(802, 337);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(63, 13);
            this.lblPayDate.TabIndex = 36;
            this.lblPayDate.Text = "Pay Date:";
            // 
            // btnNextPurchase
            // 
            this.btnNextPurchase.ForeColor = System.Drawing.Color.Black;
            this.btnNextPurchase.Location = new System.Drawing.Point(236, 333);
            this.btnNextPurchase.Name = "btnNextPurchase";
            this.btnNextPurchase.Size = new System.Drawing.Size(167, 23);
            this.btnNextPurchase.TabIndex = 34;
            this.btnNextPurchase.TabStop = false;
            this.btnNextPurchase.Text = "Highlight Next Purchases";
            this.btnNextPurchase.UseVisualStyleBackColor = true;
            this.btnNextPurchase.Click += new System.EventHandler(this.btnNextPurchase_Click);
            // 
            // chkNextBuy
            // 
            this.chkNextBuy.AutoSize = true;
            this.chkNextBuy.ForeColor = System.Drawing.Color.White;
            this.chkNextBuy.Location = new System.Drawing.Point(107, 338);
            this.chkNextBuy.Name = "chkNextBuy";
            this.chkNextBuy.Size = new System.Drawing.Size(123, 17);
            this.chkNextBuy.TabIndex = 33;
            this.chkNextBuy.Text = "Next to purchase";
            this.chkNextBuy.UseVisualStyleBackColor = true;
            this.chkNextBuy.CheckedChanged += new System.EventHandler(this.chkNextBuy_CheckedChanged);
            // 
            // lblSearchAllSymbol
            // 
            this.lblSearchAllSymbol.AutoSize = true;
            this.lblSearchAllSymbol.ForeColor = System.Drawing.Color.White;
            this.lblSearchAllSymbol.Location = new System.Drawing.Point(435, 338);
            this.lblSearchAllSymbol.Name = "lblSearchAllSymbol";
            this.lblSearchAllSymbol.Size = new System.Drawing.Size(95, 13);
            this.lblSearchAllSymbol.TabIndex = 32;
            this.lblSearchAllSymbol.Text = "Search Symbol:";
            // 
            // txtSearchAllSymbol
            // 
            this.txtSearchAllSymbol.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSearchAllSymbol.ForeColor = System.Drawing.Color.Black;
            this.txtSearchAllSymbol.Location = new System.Drawing.Point(536, 335);
            this.txtSearchAllSymbol.Name = "txtSearchAllSymbol";
            this.txtSearchAllSymbol.Size = new System.Drawing.Size(71, 20);
            this.txtSearchAllSymbol.TabIndex = 31;
            this.txtSearchAllSymbol.TextChanged += new System.EventHandler(this.txtSearchAllSymbol_TextChanged);
            // 
            // lblSearchSymbol
            // 
            this.lblSearchSymbol.AutoSize = true;
            this.lblSearchSymbol.ForeColor = System.Drawing.Color.White;
            this.lblSearchSymbol.Location = new System.Drawing.Point(1114, 338);
            this.lblSearchSymbol.Name = "lblSearchSymbol";
            this.lblSearchSymbol.Size = new System.Drawing.Size(95, 13);
            this.lblSearchSymbol.TabIndex = 30;
            this.lblSearchSymbol.Text = "Search Symbol:";
            // 
            // txtSearchSymbol
            // 
            this.txtSearchSymbol.BackColor = System.Drawing.Color.AliceBlue;
            this.txtSearchSymbol.ForeColor = System.Drawing.Color.Black;
            this.txtSearchSymbol.Location = new System.Drawing.Point(1215, 335);
            this.txtSearchSymbol.Name = "txtSearchSymbol";
            this.txtSearchSymbol.Size = new System.Drawing.Size(59, 20);
            this.txtSearchSymbol.TabIndex = 29;
            this.txtSearchSymbol.TextChanged += new System.EventHandler(this.txtSearchSymbol_TextChanged);
            // 
            // btnAllIndustryPercentages
            // 
            this.btnAllIndustryPercentages.ForeColor = System.Drawing.Color.Black;
            this.btnAllIndustryPercentages.Location = new System.Drawing.Point(613, 332);
            this.btnAllIndustryPercentages.Name = "btnAllIndustryPercentages";
            this.btnAllIndustryPercentages.Size = new System.Drawing.Size(130, 23);
            this.btnAllIndustryPercentages.TabIndex = 28;
            this.btnAllIndustryPercentages.Text = "Show Percentages";
            this.btnAllIndustryPercentages.UseVisualStyleBackColor = true;
            this.btnAllIndustryPercentages.Click += new System.EventHandler(this.btnAllIndustryPercentages_Click);
            // 
            // btnCurrentIndustryPercentage
            // 
            this.btnCurrentIndustryPercentage.ForeColor = System.Drawing.Color.Black;
            this.btnCurrentIndustryPercentage.Location = new System.Drawing.Point(1280, 333);
            this.btnCurrentIndustryPercentage.Name = "btnCurrentIndustryPercentage";
            this.btnCurrentIndustryPercentage.Size = new System.Drawing.Size(122, 23);
            this.btnCurrentIndustryPercentage.TabIndex = 27;
            this.btnCurrentIndustryPercentage.Text = "Show Percentages";
            this.btnCurrentIndustryPercentage.UseVisualStyleBackColor = true;
            this.btnCurrentIndustryPercentage.Click += new System.EventHandler(this.btnCurrentIndustryPercentage_Click);
            // 
            // btnHighlightAll
            // 
            this.btnHighlightAll.ForeColor = System.Drawing.Color.Black;
            this.btnHighlightAll.Location = new System.Drawing.Point(677, 13);
            this.btnHighlightAll.Name = "btnHighlightAll";
            this.btnHighlightAll.Size = new System.Drawing.Size(65, 23);
            this.btnHighlightAll.TabIndex = 26;
            this.btnHighlightAll.TabStop = false;
            this.btnHighlightAll.Text = "Highlight";
            this.btnHighlightAll.UseVisualStyleBackColor = true;
            this.btnHighlightAll.Click += new System.EventHandler(this.btnHighlightAll_Click);
            // 
            // lblIndustryAll
            // 
            this.lblIndustryAll.AutoSize = true;
            this.lblIndustryAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndustryAll.ForeColor = System.Drawing.Color.White;
            this.lblIndustryAll.Location = new System.Drawing.Point(411, 18);
            this.lblIndustryAll.Name = "lblIndustryAll";
            this.lblIndustryAll.Size = new System.Drawing.Size(56, 13);
            this.lblIndustryAll.TabIndex = 25;
            this.lblIndustryAll.Text = "Industry:";
            // 
            // ddlIndustryAll
            // 
            this.ddlIndustryAll.BackColor = System.Drawing.Color.AliceBlue;
            this.ddlIndustryAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlIndustryAll.ForeColor = System.Drawing.Color.Black;
            this.ddlIndustryAll.FormattingEnabled = true;
            this.ddlIndustryAll.Items.AddRange(new object[] {
            "Consumer Discretionary",
            "Consumer Staples",
            "Energy",
            "Financials",
            "Health Care",
            "Industrials",
            "Information Technology",
            "Materials",
            "Telecommunication Services",
            "Utilities"});
            this.ddlIndustryAll.Location = new System.Drawing.Point(473, 14);
            this.ddlIndustryAll.Name = "ddlIndustryAll";
            this.ddlIndustryAll.Size = new System.Drawing.Size(199, 21);
            this.ddlIndustryAll.TabIndex = 24;
            // 
            // btnHighlight
            // 
            this.btnHighlight.ForeColor = System.Drawing.Color.Black;
            this.btnHighlight.Location = new System.Drawing.Point(1255, 13);
            this.btnHighlight.Name = "btnHighlight";
            this.btnHighlight.Size = new System.Drawing.Size(66, 23);
            this.btnHighlight.TabIndex = 23;
            this.btnHighlight.TabStop = false;
            this.btnHighlight.Text = "Highlight";
            this.btnHighlight.UseVisualStyleBackColor = true;
            this.btnHighlight.Click += new System.EventHandler(this.btnHighlight_Click);
            // 
            // lblIndustry
            // 
            this.lblIndustry.AutoSize = true;
            this.lblIndustry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndustry.ForeColor = System.Drawing.Color.White;
            this.lblIndustry.Location = new System.Drawing.Point(964, 19);
            this.lblIndustry.Name = "lblIndustry";
            this.lblIndustry.Size = new System.Drawing.Size(56, 13);
            this.lblIndustry.TabIndex = 22;
            this.lblIndustry.Text = "Industry:";
            // 
            // ddlIndustry
            // 
            this.ddlIndustry.BackColor = System.Drawing.Color.AliceBlue;
            this.ddlIndustry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlIndustry.ForeColor = System.Drawing.Color.Black;
            this.ddlIndustry.FormattingEnabled = true;
            this.ddlIndustry.Items.AddRange(new object[] {
            "Consumer Discretionary",
            "Consumer Staples",
            "Energy",
            "Financials",
            "Health Care",
            "Industrials",
            "Information Technology",
            "Materials",
            "Telecommunication Services",
            "Utilities"});
            this.ddlIndustry.Location = new System.Drawing.Point(1026, 14);
            this.ddlIndustry.Name = "ddlIndustry";
            this.ddlIndustry.Size = new System.Drawing.Size(223, 21);
            this.ddlIndustry.TabIndex = 21;
            // 
            // btnDividendPrice
            // 
            this.btnDividendPrice.ForeColor = System.Drawing.Color.Black;
            this.btnDividendPrice.Location = new System.Drawing.Point(1408, 13);
            this.btnDividendPrice.Name = "btnDividendPrice";
            this.btnDividendPrice.Size = new System.Drawing.Size(133, 23);
            this.btnDividendPrice.TabIndex = 20;
            this.btnDividendPrice.TabStop = false;
            this.btnDividendPrice.Text = "Get Dividend Price";
            this.btnDividendPrice.UseVisualStyleBackColor = true;
            this.btnDividendPrice.Click += new System.EventHandler(this.btnDividendPrice_Click);
            // 
            // btnGetSharePrice
            // 
            this.btnGetSharePrice.ForeColor = System.Drawing.Color.Black;
            this.btnGetSharePrice.Location = new System.Drawing.Point(1327, 13);
            this.btnGetSharePrice.Name = "btnGetSharePrice";
            this.btnGetSharePrice.Size = new System.Drawing.Size(75, 23);
            this.btnGetSharePrice.TabIndex = 19;
            this.btnGetSharePrice.TabStop = false;
            this.btnGetSharePrice.Text = "Get Price";
            this.btnGetSharePrice.UseVisualStyleBackColor = true;
            this.btnGetSharePrice.Click += new System.EventHandler(this.btnGetSharePrice_Click);
            // 
            // lblTotalAllDividends
            // 
            this.lblTotalAllDividends.AutoSize = true;
            this.lblTotalAllDividends.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAllDividends.ForeColor = System.Drawing.Color.White;
            this.lblTotalAllDividends.Location = new System.Drawing.Point(102, 18);
            this.lblTotalAllDividends.Name = "lblTotalAllDividends";
            this.lblTotalAllDividends.Size = new System.Drawing.Size(14, 13);
            this.lblTotalAllDividends.TabIndex = 9;
            this.lblTotalAllDividends.Text = "0";
            // 
            // lblTotalPortfolioDividends
            // 
            this.lblTotalPortfolioDividends.AutoSize = true;
            this.lblTotalPortfolioDividends.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPortfolioDividends.ForeColor = System.Drawing.Color.White;
            this.lblTotalPortfolioDividends.Location = new System.Drawing.Point(862, 21);
            this.lblTotalPortfolioDividends.Name = "lblTotalPortfolioDividends";
            this.lblTotalPortfolioDividends.Size = new System.Drawing.Size(14, 13);
            this.lblTotalPortfolioDividends.TabIndex = 8;
            this.lblTotalPortfolioDividends.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Not In Portfolio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(802, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Portfolio:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.Location = new System.Drawing.Point(1408, 333);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Results";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(751, 235);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(42, 34);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "←";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(751, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "→";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(752, 1);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(100, 23);
            this.pbStatus.TabIndex = 39;
            this.pbStatus.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(663, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(83, 13);
            this.lblStatus.TabIndex = 40;
            this.lblStatus.Text = "Please Wait..";
            this.lblStatus.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1571, 406);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gpDividendStocks);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dividend Liberty";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpDividendStocks.ResumeLayout(false);
            this.gpDividendStocks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpDividendStocks;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ListBox lbAllDividends;
        public System.Windows.Forms.ListBox lbCurrentDividends;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalPortfolioDividends;
        private System.Windows.Forms.Label lblTotalAllDividends;
        private System.Windows.Forms.Button btnDividendPrice;
        private System.Windows.Forms.Button btnGetSharePrice;
        private System.Windows.Forms.ComboBox ddlIndustry;
        private System.Windows.Forms.Button btnHighlight;
        private System.Windows.Forms.Label lblIndustry;
        private System.Windows.Forms.Button btnHighlightAll;
        private System.Windows.Forms.Label lblIndustryAll;
        private System.Windows.Forms.ComboBox ddlIndustryAll;
        private System.Windows.Forms.Button btnCurrentIndustryPercentage;
        private System.Windows.Forms.Button btnAllIndustryPercentages;
        private System.Windows.Forms.TextBox txtSearchSymbol;
        private System.Windows.Forms.Label lblSearchAllSymbol;
        private System.Windows.Forms.TextBox txtSearchAllSymbol;
        private System.Windows.Forms.Label lblSearchSymbol;
        private System.Windows.Forms.CheckBox chkNextBuy;
        private System.Windows.Forms.Button btnNextPurchase;
        private System.Windows.Forms.Button btnPayDate;
        private System.Windows.Forms.Label lblPayDate;
        private System.Windows.Forms.DateTimePicker dtpPayDate;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ProgressBar pbStatus;
    }
}

