using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QueueingForm;
using Queuing_Form;

namespace Queueing_Form
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var thread = new Thread(ThreadStart);
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();

            Application.Run(new Form1(new CashierClass()));
        }

        private static void ThreadStart()
        {
            Application.Run(new CashierWindowQueueForm());
        }

        public static void ThreadStart2()
        {
            Application.Run(new UpdateNext());
        }

        public static void run (Thread thread)
        {
            thread.TrySetApartmentState(ApartmentState.STA)
            thread.Start();
        }
    }
}
