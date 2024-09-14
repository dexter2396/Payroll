using QueueingForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queuing_Form
{
    public partial class Form1 : Form
    {
        private CashierClass cashier;
        public Form1(CashierClass cashier) 
        {
            InitializeComponent();
            this.cashier = cashier;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.cashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }
    }
}
