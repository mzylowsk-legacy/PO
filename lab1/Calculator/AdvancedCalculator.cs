using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class AdvancedCalculator
    {
        public AdvancedCalculator(int operation, int value)
        {
            if (operation == 6)
            {
                PrimeTest pt = new PrimeTest(value);
            }
        }
    }
}
