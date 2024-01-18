using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Custom_Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool enterValue = false;    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMathOperator(object sender, EventArgs e)
        {
            if (result != 0) btnEual.PerformClick();
            else result = Double.Parse(txtDisplay1.Text);

            Button button = (Button)sender;
            operation = button.Text;
            enterValue = true;
            if (txtDisplay1.Text != "0")
            {
                txtDisplay2.Text = fstNum = $"{result}{operation}";
                txtDisplay1.Text = string.Empty;
            }
        }

        private void btnEual_Click(object sender, EventArgs e)
        {
            secNum = txtDisplay1.Text;
            txtDisplay2.Text = $"{txtDisplay2.Text}{txtDisplay1.Text} =";
            if(txtDisplay1.Text != string.Empty)
            {
                if(txtDisplay1.Text == "0")txtDisplay2.Text = string.Empty;
                switch(operation)
                {
                    case "+":
                        txtDisplay1.Text = (result + Double.Parse(txtDisplay1.Text)).ToString();
                        break;
                    case "-":
                        txtDisplay1.Text = (result - Double.Parse(txtDisplay1.Text)).ToString();
                        break;
                    case "×":
                        txtDisplay1.Text = (result * Double.Parse(txtDisplay1.Text)).ToString();
                        break;
                    case "÷":
                        txtDisplay1.Text = (result / Double.Parse(txtDisplay1.Text)).ToString();
                        break;
                    default: txtDisplay2.Text = $"{txtDisplay1.Text} =";
                        break;
                }

                result = Double.Parse(txtDisplay1.Text);
                operation = string.Empty;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
            txtDisplay2.Text = string.Empty;
            result = 0; 
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay1.Text = "0";
        }

        private void btnBS_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text.Length > 0)
                txtDisplay1.Text = txtDisplay1.Text.Remove(txtDisplay1.Text.Length -1,1);
            if (txtDisplay1.Text == string.Empty) txtDisplay1.Text = "0";
        }

        private void btnPer_Click(object sender, EventArgs e)
        {
            txtDisplay2.Text = $"%({txtDisplay1.Text})";
            txtDisplay1.Text = Convert.ToString(Convert.ToDouble(txtDisplay1.Text) / Convert.ToDouble(100));
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (txtDisplay1.Text == "0" || enterValue) txtDisplay1.Text = string.Empty;

            enterValue = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (txtDisplay1.Text.Contains("."))
                    txtDisplay1.Text = txtDisplay1.Text + button.Text;
            }
            else txtDisplay1.Text = txtDisplay1.Text + button.Text;
        }


    }
}
