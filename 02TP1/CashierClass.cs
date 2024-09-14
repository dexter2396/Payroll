using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueingForm
{
    public class CashierClass
    {
        private int x;
        public static string getNumberInQueue = "";
        public static Queue<string> cashierQueue;
        public CashierClass()
        {
            x = 10000;
            cashierQueue = new Queue<string>();
        }

        public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }
}
