using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        CalculatorClass cal = new CalculatorClass();
         double num1;
         double num2;
        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }
               
private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            string selectOperator = cbOperator.SelectedItem.ToString();
            double result = 0;

            switch (selectOperator)
            {
                case "+":
                    //result = cal.GetSum(num1, num2);
                    cal.calculateEvent += new Formula<double>(cal.GetSum);
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.calculateEvent -= new Formula<double> (cal.GetSum);
                    break;

                case "-":
                    // result = cal.GetDiff(num1, num2);
                    cal.calculateEvent += new Formula<double>(cal.GetDiff);
                    lblDisplayTotal.Text = cal.GetDiff(num1, num2).ToString();
                    cal.calculateEvent -= new Formula<double>(cal.GetDiff);
                    break;

                case "*":
                    // result = cal.GetProd(num1, num2);
                    cal.calculateEvent += new Formula<double>(cal.GetProd);
                    lblDisplayTotal.Text = cal.GetProd(num1, num2).ToString();
                    cal.calculateEvent -= new Formula<double>(cal.GetProd);
                    break;

                case "/":
                    // result = cal.GetQout(num1, num2);
                    cal.calculateEvent += new Formula<double>(cal.GetQout);
                    lblDisplayTotal.Text = cal.GetQout(num1, num2).ToString();
                    cal.calculateEvent -= new Formula<double>(cal.GetQout);
                    break;

                default:
                    return;
            }

           // lblDisplayTotal.Text = result.ToString();
    }

        
    }
}
