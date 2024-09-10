using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
 
        public delegate T Formula<T>(T x, T y);

    public class CalculatorClass
    {
        public Formula<double> formula;
        public event Formula<double> CalculateEvent;

        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetDiff(double x, double y)
        {
            return x - y;
        }

        public double GetProd(double x, double y)
        {
            return x * y;

        }

        public double GetQout(double x, double y)
        {
            return x / y;

        }

        public event Formula<double> calculateEvent
        {
            add
            {
                Console.WriteLine("Added the Delegate");
                
            }

            remove
            {
                Console.WriteLine("Remove the Delegate");
                
            }
        }


        
    }
}
