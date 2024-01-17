namespace _015.CurrencyConvertor
{
    partial class FormConvertor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            comboBoxCurrency = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.DecimalPlaces = 2;
            numericUpDownAmount.Location = new System.Drawing.Point(15, 17);
            numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4);
            numericUpDownAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new System.Drawing.Size(154, 29);
            numericUpDownAmount.TabIndex = 0;
            numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmount.ValueChanged += numericUpDownAmount_ValueChanged;
            // 
            // comboBoxCurrency
            // 
            comboBoxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxCurrency.FormattingEnabled = true;
            comboBoxCurrency.Items.AddRange(new object[] { "EUR", "GBP", "USD" });
            comboBoxCurrency.Location = new System.Drawing.Point(298, 15);
            comboBoxCurrency.Margin = new System.Windows.Forms.Padding(4);
            comboBoxCurrency.Name = "comboBoxCurrency";
            comboBoxCurrency.Size = new System.Drawing.Size(154, 29);
            comboBoxCurrency.TabIndex = 1;
            comboBoxCurrency.SelectedIndexChanged += comboBoxCurrency_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(213, 19);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 21);
            label1.TabIndex = 2;
            label1.Text = "BGN";
            // 
            // labelResult
            // 
            labelResult.BackColor = System.Drawing.Color.PaleGreen;
            labelResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelResult.Location = new System.Drawing.Point(15, 75);
            labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new System.Drawing.Size(437, 41);
            labelResult.TabIndex = 3;
            labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConvertor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(469, 125);
            Controls.Add(labelResult);
            Controls.Add(label1);
            Controls.Add(comboBoxCurrency);
            Controls.Add(numericUpDownAmount);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConvertor";
            Text = "Currency Convertor";
            Load += FormConvertor_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelResult;
    }
}
