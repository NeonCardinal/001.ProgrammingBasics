using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _007.Sumator
{
    public partial class SumatorForm : Form
    {
        public SumatorForm()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal a = decimal.Parse(textBox1.Text);
                decimal b = decimal.Parse(textBox2.Text);
                decimal result = a + b;
                textBoxSum.Text = result.ToString();
            }
            catch
            {
                textBoxSum.Text = "Error";
            }
        }
    }
}
