﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015.CurrencyConvertor
{
    public partial class FormConvertor : Form
    {
        public FormConvertor()
        {
            InitializeComponent();
        }

        private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void FormConvertor_Load(object sender, EventArgs e)
        {
            this.comboBoxCurrency.SelectedItem = "EUR";
        }

        private void comboBoxCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void ConvertCurrency()
        {
            var originalAmount = this.numericUpDownAmount.Value;

            var convertedAmount = originalAmount;

            if(this.comboBoxCurrency.SelectedItem.ToString() == "EUR")
            {
                convertedAmount = originalAmount / 1.95583m;
            }
            else if(this.comboBoxCurrency.SelectedItem.ToString() == "GBP")
            {
                convertedAmount = originalAmount / 2.54990m;
            }
            else if(this.comboBoxCurrency.SelectedItem.ToString() == "USD")
            {
                convertedAmount = originalAmount / 1.80810m;
            }

            this.labelResult.Text = originalAmount + "лв. = " + Math.Round(convertedAmount, 2) + " " + this.comboBoxCurrency.SelectedItem;
        }
    }
}
