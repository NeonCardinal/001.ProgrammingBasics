namespace _013.EurToBgnGUI
{
    partial class Form1
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
            labelResult = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.DecimalPlaces = 2;
            numericUpDownAmount.Location = new System.Drawing.Point(108, 26);
            numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4);
            numericUpDownAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new System.Drawing.Size(154, 29);
            numericUpDownAmount.TabIndex = 0;
            numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownAmount.ValueChanged += numericUpDownAmount_ValueChanged;
            numericUpDownAmount.KeyUp += numericUpDownAmount_KeyUp;
            // 
            // labelResult
            // 
            labelResult.BackColor = System.Drawing.Color.PaleGreen;
            labelResult.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelResult.Location = new System.Drawing.Point(13, 79);
            labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new System.Drawing.Size(381, 25);
            labelResult.TabIndex = 1;
            labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(13, 28);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 21);
            label2.TabIndex = 2;
            label2.Text = "Convert";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(301, 28);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 21);
            label3.TabIndex = 3;
            label3.Text = "BGN to EUR";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(414, 122);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(labelResult);
            Controls.Add(numericUpDownAmount);
            Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "BGN to EUR";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
