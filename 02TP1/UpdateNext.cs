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
    public partial class UpdateNext : Form
    {
        System.Windows.Forms.Timer timer;
        string currentServing;
        public UpdateNext()
        {
            InitializeComponent();

            timer = new System.Windows.Forms.Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_tick);
            timer.Start();
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            UpdateNextQueue();
        }

        private void UpdateNextQueue()
        {
            if(CashierClass.cashierQueue.Count > 0)
            {
                currentServing = CashierClass.cashierQueue.Peek();
            }
            else
            {
                currentServing = " ";
            }
            
        }

        private void updateServing_click(object sender, EventArgs e)
        {

        }

        private void UpdateNext_Load(object sender, EventArgs e)
        {

        }
    }
}
