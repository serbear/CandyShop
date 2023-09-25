using System;
using System.Globalization;
using System.Windows.Forms;

namespace CandyShop
{
    public partial class Form1 : Form
    {
        private readonly decimal _lollipopPrice = 11.37M;
        private readonly decimal _chocolatePrice = 15.17M;
        private readonly decimal _fishPrice = 4.20M;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set prices for goods.
            tbLollipopTotal.Text = _lollipopPrice.ToString("C2", CultureInfo.CurrentCulture);
            tbChocolateTotal.Text = _chocolatePrice.ToString("C2", CultureInfo.CurrentCulture);
            tbFishTotal.Text = _fishPrice.ToString("C2", CultureInfo.CurrentCulture);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbLollipop.Text = @"0";
            tbChocolate.Text = @"0";
            tbFish.Text = @"0";
            tbLollipopTotal.Text = "";
            tbChocolateTotal.Text = "";
            tbFishTotal.Text = "";
            tbSumma.Text = "";
            tbLollipop.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            int lollipopAmount; 
            int chocolateAmount;
            int fishAmount;
            
            try
            {
                lollipopAmount = GetValueFromTextbox(tbLollipop);
                chocolateAmount = GetValueFromTextbox(tbChocolate);
                fishAmount = GetValueFromTextbox(tbFish);
            }
            catch (MyFormatException)
            {
                return;
            }

            var lollipopTotal = lollipopAmount * _lollipopPrice;
            var chocolateTotal = chocolateAmount * _chocolatePrice;
            var fishTotal = fishAmount * _fishPrice;
            var totalCost = lollipopTotal + chocolateTotal + fishTotal;

            tbLollipopTotal.Text = lollipopTotal.ToString("C2", CultureInfo.CurrentCulture);
            tbChocolateTotal.Text = chocolateTotal.ToString("C2", CultureInfo.CurrentCulture);
            tbFishTotal.Text = fishTotal.ToString("C2", CultureInfo.CurrentCulture);
            tbSumma.Text = totalCost.ToString("C2", CultureInfo.CurrentCulture);
        }

        private static int GetValueFromTextbox(TextBoxBase textBox)
        {
            if (textBox.Text.Equals(""))
            {
                var  msg = "Field '" + textBox.Name.Replace("tb", "") + "' cannot be empty.";
                MessageBox.Show(msg, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
                throw new MyFormatException();
            }
            
            int retVal;
            try
            {
                retVal= int.Parse(textBox.Text);
            }
            catch (FormatException)
            {
                var msg = "";
                if (textBox.Text != null)
                {
                    msg = "Field '" + textBox.Name.Replace("tb", "") + "' cannot have such value.";
                }
                MessageBox.Show(msg, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.SelectAll();
                textBox.Focus();
                throw new MyFormatException();
            }
            return retVal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}