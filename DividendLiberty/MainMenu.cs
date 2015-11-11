﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DividendLiberty
{
    public partial class MainMenu : Form
    {
        public static Dividends _Dividends;
        public bool CurrentDiv { get; set; }
        public int ID { get; set; }
        public List<int> lstID = new List<int>();
        public bool HighlightActive { get; set; }
        public string Symbol { get; set; }
        public MainMenu()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDividends(false, "", "");
        }

        public void OpenDividends(bool edit, string id, string symbol)
        {
            PleaseWait pw = new PleaseWait();
            pw.Show();
            Application.DoEvents();
            if (_Dividends == null || _Dividends.IsDisposed)
            {
                _Dividends = new Dividends(edit, id, CurrentDiv, symbol);
                _Dividends.Show();
            }
            else
            {
                if (_Dividends.WindowState == FormWindowState.Minimized)
                {
                    _Dividends.WindowState = FormWindowState.Normal;
                }
                else
                {
                    _Dividends.BringToFront();
                }
            }
            pw.Close();
        }

        #region backgroundworkers
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //pbStatus.InvokeEx(x => x.Value = 10);
            //pbStatus.InvokeEx(x => x.Visible = true);
            //lblStatus.InvokeEx(x => x.Visible = true);
            CalculateResults();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
        #endregion

        public void CalculateResults()
        {
            PleaseWait pw = new PleaseWait();
            pw.Show();
            Application.DoEvents();
            decimal TotalDividendCount = 0;
            decimal TotalDividendStockValue = 0;
            decimal YearDiv = 0;
            decimal QuarterDiv = 0;
            decimal MonthlyDiv = 0;
            decimal DividendTotalPercentage = 0;
            decimal MarketTotalPrice = 0;
            DataTable dt = DividendStocks.GetCurrentDividends();
            decimal Purchaseprice = 0;
            string Stocks = Uti.GetMultiSymbols(dt);
            string[] AnnualDiv = Uti.SplitStockData(YahooFinance.GetValues(Stocks, "d", true));
            string[] DivYield = Uti.SplitStockData(YahooFinance.GetValues(Stocks, "y", true));
            // l1 is last trade price, c1 change in price, b is bid price, a is ask price; Ask price is current price as you're asking for a price when selling therefore that is the price of your portfolio
            string[] CurrentStockPrice = Uti.SplitStockData(YahooFinance.GetValues(Stocks, "a", true));
            //decimal val = dt.Rows.Count;
            //decimal StatusVal = 0;
            //val = Math.Round(90 / val, 0);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["id"].ToString();
                Purchaseprice = Convert.ToDecimal(dt.Rows[i]["purchaseprice"]);
                YearDiv += (Convert.ToDecimal(dt.Rows[i]["numberofshares"]) * Convert.ToDecimal(AnnualDiv[i]));
                TotalDividendStockValue += (Convert.ToDecimal(dt.Rows[i]["numberofshares"]) * Purchaseprice);
                TotalDividendCount++;
                DividendTotalPercentage += DivYield[i] == "N/A" ? 0 : Convert.ToDecimal(DivYield[i]);
                if (dt.Rows[i]["symbol"].ToString() == "SIL")
                {
                    DividendTotalPercentage += (decimal).09;
                }
                //if (dt.Rows[i]["symbol"].ToString() == "GDX")
                //{
                //    DividendTotalPercentage -= Convert.ToDecimal(DivYield[i]);
                //    DividendTotalPercentage += (decimal).80;
                //}
                MarketTotalPrice += (Convert.ToDecimal(dt.Rows[i]["numberofshares"]) * Convert.ToDecimal(CurrentStockPrice[i]));
                //StatusVal += val;
                //if (StatusVal < 88)
                //    pbStatus.InvokeEx(x => x.Value = Convert.ToInt32(StatusVal));
            }
            DividendTotalPercentage = DividendTotalPercentage / TotalDividendCount;
            QuarterDiv = (YearDiv / 4);
            MonthlyDiv = (YearDiv / 12);
            //pbStatus.InvokeEx(x => x.Value = 100);
            //pbStatus.InvokeEx(x => x.Visible = false);
            //lblStatus.InvokeEx(x => x.Visible = false);
            pw.Close();
            MessageBox.Show("Cost Basis: $" + Math.Round(TotalDividendStockValue, 2) + "\n\nMarket Value: $" + Math.Round(MarketTotalPrice, 2) + "\n\nAnnual Dividend: $" + Math.Round(YearDiv, 2) + "\n\n" + "Quarterly Dividend: $" + Math.Round(QuarterDiv, 2) + "\n\nMonthly Dividend: $" + Math.Round(MonthlyDiv, 2) + "\n\nPortfolio Dividend Yield: " + Math.Round(DividendTotalPercentage, 2) + "%");
        }

        public void LoadCurrentDividends()
        {
            lbCurrentDividends.SelectedIndexChanged -= lbCurrentDividends_SelectedIndexChanged;
            int totalDividends = 0;
            DividendStocks.LoadDividends(lbCurrentDividends, "true", out totalDividends);
            lblTotalPortfolioDividends.Text = totalDividends.ToString();
            lbCurrentDividends.ClearSelected();
            lbCurrentDividends.SelectedIndexChanged += lbCurrentDividends_SelectedIndexChanged;
        }

        public void LoadAllDividends()
        {
            lbAllDividends.SelectedIndexChanged -= lbAllDividends_SelectedIndexChanged;
            int totalDividends = 0;
            DividendStocks.LoadDividends(lbAllDividends, "false", out totalDividends);
            lblTotalAllDividends.Text = totalDividends.ToString();
            lbAllDividends.ClearSelected();
            lbAllDividends.SelectedIndexChanged += lbAllDividends_SelectedIndexChanged;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ddlIndustry.SelectedIndex = 0;
            ddlIndustryAll.SelectedIndex = 0;
            dtpPayDate.Format = DateTimePickerFormat.Custom;
            dtpPayDate.CustomFormat = "MM/yyyy";
            dtpPayDate.ShowUpDown = true;
            LoadAllDividends();
            LoadCurrentDividends();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (backgroundWorker1.IsBusy)
                {
                    MessageBox.Show("Please wait until data is processed.");
                    return;
                }
                backgroundWorker1.RunWorkerAsync();
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRemoveDividends(lbAllDividends, "true");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            AddRemoveDividends(lbCurrentDividends, "false");
        }

        public void AddRemoveDividends(ListBox lb, string stockActive)
        {
            PleaseWait pw = new PleaseWait();
            pw.Show();
            Application.DoEvents();
            lstID.Clear();
            int selectedItemsCount = lb.SelectedItems.Count;
            if (selectedItemsCount > 1)
            {
                foreach (DataRowView drv in lb.SelectedItems)
                {
                    DividendStocks.UpdateDividendStock(drv.Row["id"].ToString(), stockActive);
                    lstID.Add(Convert.ToInt32(drv.Row["id"]));
                }
            }
            else
            {
                DividendStocks.UpdateDividendStock(lb.SelectedValue.ToString(), stockActive);
            }
            LoadAllDividends();
            LoadCurrentDividends();
            SelectStocks(selectedItemsCount);
            pw.Close();
        }

        public List<int> SaveListBoxItems(ListBox lb)
        {
            List<int> toReturn = new List<int>();
            foreach (DataRowView drv in lb.Items)
            {
                toReturn.Add(Convert.ToInt32(drv.Row["id"]));
            }
            return toReturn;
        }

        public void SelectMultiple(ListBox lb)
        {
            List<int> lst = SaveListBoxItems(lb);
            for (int a = 0; a < lstID.Count; a++)
            {
                for (int b = 0; b < lst.Count; b++)
                {
                    if (lstID[a] == lst[b])
                    {
                        lb.SetSelected(b, true);
                    }
                }
            }
        }

        public void SelectStocks(int selectedItemsCount)
        {
            if (!CurrentDiv)
            {
                CurrentDiv = true;
                lbAllDividends.ClearSelected();
                lbCurrentDividends.SelectedIndexChanged -= lbCurrentDividends_SelectedIndexChanged;
                lbCurrentDividends.ClearSelected();
                if (selectedItemsCount == 1)
                {
                    lbCurrentDividends.SelectedValue = Convert.ToInt32(ID);
                }
                else
                {
                    SelectMultiple(lbCurrentDividends);
                }
                lbCurrentDividends.SelectedIndexChanged += lbCurrentDividends_SelectedIndexChanged;
            }
            else
            {
                CurrentDiv = false;
                lbCurrentDividends.ClearSelected();
                lbAllDividends.SelectedIndexChanged -= lbAllDividends_SelectedIndexChanged;
                lbAllDividends.ClearSelected();
                if (selectedItemsCount == 1)
                {
                    lbAllDividends.SelectedValue = Convert.ToInt32(ID);
                }
                else
                {
                    SelectMultiple(lbAllDividends);
                }
                lbAllDividends.SelectedIndexChanged += lbAllDividends_SelectedIndexChanged;
            }
        }

        private void lbCurrentDividends_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbCurrentDividends.SelectedIndex != -1)
            {
                OpenDividends(true, lbCurrentDividends.SelectedValue.ToString(), Symbol);
            }
        }


        private void lbAllDividends_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbAllDividends.SelectedIndex != -1)
            {
                OpenDividends(true, lbAllDividends.SelectedValue.ToString(), Symbol);
            }
        }

        public string GetStockSymbol(ListBox lb)
        {
            string symbol = lb.Text;
            string[] split = symbol.Split('-');
            return symbol = split[0].Trim();
        }

        public void GetDividendPrice(ListBox lb)
        {
            decimal TotalDividendPrice = 0;
            decimal QuarterlyDividendPrice = 0;
            decimal MonthlyDividendPrice = 0;
            DividendStocks.GetDividendPrice(Symbol, lb.SelectedValue.ToString(), out TotalDividendPrice, out QuarterlyDividendPrice, out MonthlyDividendPrice);
            MessageBox.Show("Yearly: $" + Math.Round(TotalDividendPrice, 2).ToString() + "\n\nQuarterly: $" + Math.Round(QuarterlyDividendPrice, 2) + "\n\nMonthly: $" + Math.Round(MonthlyDividendPrice, 2));
        }

        public void GetSharePrice(ListBox lb)
        {
            decimal totalPrice = 0;
            DividendStocks.GetTotalSharePrice(lb.SelectedValue.ToString(), out totalPrice);
            MessageBox.Show("$" + Math.Round(totalPrice, 2).ToString());
        }

        private void btnGetSharePrice_Click(object sender, EventArgs e)
        {
            if (lbCurrentDividends.SelectedIndex != -1)
            {
                GetSharePrice(lbCurrentDividends);
            }
        }

        private void btnDividendPrice_Click(object sender, EventArgs e)
        {
            if (lbCurrentDividends.SelectedIndex != -1)
            {
                GetDividendPrice(lbCurrentDividends);
            }
        }

        private void btnHighlight_Click(object sender, EventArgs e)
        {
            Highlight(lbCurrentDividends, ddlIndustry, lblTotalPortfolioDividends, true);
        }

        public void SearchSymbol(TextBox tb, ListBox lb)
        {
            bool selectedOne = false;
            lb.ClearSelected();
            for (int i = 0; i < lb.Items.Count; i++)
            {
                DataRowView drv = lb.Items[i] as DataRowView;
                if (drv["symbolName"].ToString().Contains(tb.Text.ToUpper()))
                {
                    selectedOne = true;
                    lb.SelectedIndices.Add(i);
                }
            }
            HighlightActive = false;
            if (!selectedOne)
            {
                MessageBox.Show("Not Found");
                tb.Clear();
            }
        }

        public void Highlight(ListBox lb, ComboBox ddl, Label lbl, bool showMsg)
        {
            lb.ClearSelected();
            decimal count = 0;
            decimal percentage = Convert.ToDecimal(lbl.Text);
            for (int i = 0; i < lb.Items.Count; i++)
            {
                DataRowView drv = lb.Items[i] as DataRowView;
                if (drv["symbolName"].ToString().Contains(ddl.Text))
                {
                    count++;
                    lb.SelectedIndices.Add(i);
                }
            }
            percentage = (count / percentage) * 100;
            HighlightActive = false;
            if (showMsg)
            {
                MessageBox.Show(count + " " + ddl.Text + ": " + Math.Round(percentage, 2) + "%");
            }
        }


        private void btnNextPurchase_Click(object sender, EventArgs e)
        {
            HighlightActive = true;
            HighlightAllNextToBuy(lbAllDividends);
        }

        public void HighlightAllNextToBuy(ListBox lb)
        {
            lb.ClearSelected();
            chkNextBuy.CheckedChanged -= chkNextBuy_CheckedChanged;
            chkNextBuy.Checked = true;
            chkNextBuy.CheckedChanged += chkNextBuy_CheckedChanged;
            int cnt = 0;
            DataTable dt = DividendStocks.GetAllNextToBuy(ID);
            for (int i = 0; i < lb.Items.Count; i++)
            {
                for (int a = 0; a < dt.Rows.Count; a++)
                {
                    DataRowView drv = lb.Items[i] as DataRowView;
                    if (drv["id"].Equals(dt.Rows[a]["id"]))
                    {
                        cnt++;
                        lb.SelectedIndices.Add(i);
                    }
                }
            }
            HighlightActive = false;
            MessageBox.Show(string.Format("{0} results.", cnt));
        }

        public void ShowIndustryPercentages(ListBox lb, Label lbl)
        {
            decimal portfolioCnt = Convert.ToDecimal(lbl.Text);
            decimal percentage = 0;
            List<string> lstIndustries = new List<string>() {"Consumer Discretionary", "Consumer Staples", "Energy", "Financials", "Health Care", "Industrials", "Information Technology", 
                                                            "Materials", "Telecommunication Services", "Utilities", "Equity Precious Metals" };
            List<decimal> count = new List<decimal>();
            decimal cnt = 0;
            for (int i = 0; i < lstIndustries.Count; i++)
            {
                for (int a = 0; a < lb.Items.Count; a++)
                {
                    DataRowView drv = lb.Items[a] as DataRowView;
                    if (drv["symbolName"].ToString().Contains(lstIndustries[i].ToString()))
                    {
                        cnt++;
                    }
                }
                percentage = cnt == 0 ? 0 : (cnt / portfolioCnt) * 100;
                count.Add(percentage);
                cnt = 0;
            }
            string msg = "";
            for (int i = 0; i < lstIndustries.Count; i++)
            {
                msg += lstIndustries[i] + ": " + Math.Round(count[i], 2) + "%" + "\n\n";
            }
            msg = msg.Substring(0, msg.Length - 2);
            MessageBox.Show(msg);
        }

        private void btnHighlightAll_Click(object sender, EventArgs e)
        {
            HighlightActive = true;
            Highlight(lbAllDividends, ddlIndustryAll, lblTotalAllDividends, false);
        }

        private void btnCurrentIndustryPercentage_Click(object sender, EventArgs e)
        {
            ShowIndustryPercentages(lbCurrentDividends, lblTotalPortfolioDividends);
        }

        private void btnAllIndustryPercentages_Click(object sender, EventArgs e)
        {
            ShowIndustryPercentages(lbAllDividends, lblTotalAllDividends);
        }

        private void txtSearchSymbol_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchSymbol.Text != "")
            {
                SearchSymbol(txtSearchSymbol, lbCurrentDividends);
            }
            else
            {
                lbCurrentDividends.ClearSelected();
            }
        }

        private void txtSearchAllSymbol_TextChanged(object sender, EventArgs e)
        {
            HighlightActive = true;
            if (txtSearchAllSymbol.Text != "")
            {
                SearchSymbol(txtSearchAllSymbol, lbAllDividends);
            }
            else
            {
                lbAllDividends.ClearSelected();
            }
        }

        private void lbCurrentDividends_MouseClick(object sender, MouseEventArgs e)
        {
            Symbol = GetStockSymbol(lbCurrentDividends);
            lbAllDividends.ClearSelected();
            CurrentDiv = true;
        }

        private void lbAllDividends_MouseClick(object sender, MouseEventArgs e)
        {
            Symbol = GetStockSymbol(lbAllDividends);
            lbCurrentDividends.ClearSelected();
            CurrentDiv = false;
        }

        private void lbAllDividends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAllDividends.SelectedIndex != -1)
            {
                ID = Convert.ToInt32(lbAllDividends.SelectedValue);
                if (!HighlightActive)
                {
                    LoadNextToBuy();
                }
            }
        }

        public void LoadNextToBuy()
        {
            chkNextBuy.CheckedChanged -= chkNextBuy_CheckedChanged;
            chkNextBuy.Checked = DividendStocks.LoadNextPurchase(ID) == 1 ? true : false;
            chkNextBuy.CheckedChanged += chkNextBuy_CheckedChanged;
        }

        private void lbCurrentDividends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCurrentDividends.SelectedIndex != -1)
            {
                ID = Convert.ToInt32(lbCurrentDividends.SelectedValue);
            }
        }

        private void chkNextBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNextBuy.Checked)
            {
                DividendStocks.SaveNextPurchase(ID, 1);
            }
            else
            {
                DividendStocks.SaveNextPurchase(ID, 0);
            }
        }

        private void btnPayDate_Click(object sender, EventArgs e)
        {
            HighlightPayDate(lbCurrentDividends);
        }

        public void HighlightPayDate(ListBox lb)
        {
            PleaseWait pw = new PleaseWait();
            pw.Show();
            Application.DoEvents();
            lb.ClearSelected();
            decimal totalDiv = 0;
            decimal quarterlyDiv = 0;
            int cnt = 0;
            string monthYear = "";
            string dtpMonthYear = "";
            string individualDivData = "";
            DataTable dt = DividendStocks.GetCurrentDividends();
            for (int i = 0; i < lb.Items.Count; i++)
            {
                DataRowView drv = lb.Items[i] as DataRowView;
                string[] date = drv["symbolName"].ToString().Split('*');
                string[] symbolSplit = date[0].Split('-');
                string symbol = symbolSplit[0].Trim();
                if (date.Length == 2)
                {
                    monthYear = date[1].ToString();
                    if (monthYear != "N/A")
                    {
                        date = monthYear.Split('/');
                        monthYear = date[0].Trim() + "/" + date[2];
                        dtpMonthYear = dtpPayDate.Value.ToString("MM/yyyy");
                        //string dividendInterval = GetDividendInterval(Convert.ToInt32(drv["id"]), dt);
                        //if (dividendInterval == "Monthly")
                        //{
                        //    lb.SelectedIndices.Add(i);
                        //    totalDiv += GetDiv(Convert.ToInt32(drv["id"]), dt);
                        //    individualDivData += symbol + ": $" + Math.Round((GetDiv(Convert.ToInt32(drv["id"]), dt) / 4), 2) + "\n\n";
                        //}
                        if (monthYear == dtpMonthYear)
                        {
                            lb.SelectedIndices.Add(i);
                            totalDiv += GetDiv(Convert.ToInt32(drv["id"]), dt);
                            individualDivData += symbol + ": $" + Math.Round((GetDiv(Convert.ToInt32(drv["id"]), dt) / 4), 2) + "\n\n";
                            cnt++;
                        }
                    }
                }
            }
            HighlightActive = false;
            quarterlyDiv = totalDiv / 4;
            pw.Close();
            if (cnt != 0)
            {
                MessageBox.Show(string.Format("{0} results\n\n" + "{1} \n\n" + individualDivData + "Total: ${2}\n\n", cnt, "Dividends for " + dtpMonthYear + ":",  Math.Round(quarterlyDiv, 2)));
            }
            else
            {
                MessageBox.Show(string.Format("No Results for {0}", dtpMonthYear));
            }
        }

        public string GetDividendInterval(int id, DataTable dt)
        {
            string divInterval = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i]["id"]) == id)
                {
                    divInterval = dt.Rows[i]["dividendinterval"].ToString();
                }
            }
            return divInterval;
        }

        public decimal GetDiv(int id, DataTable dt)
        {
            decimal div = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i]["id"]) == id)
                {
                    div = Convert.ToDecimal(YahooFinance.GetValues(dt.Rows[i]["symbol"].ToString(), "d", false)) * Convert.ToDecimal(dt.Rows[i]["numberofshares"]);
                }
            }
            return div;
        }
    }
}
