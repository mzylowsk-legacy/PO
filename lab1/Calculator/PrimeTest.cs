using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class PrimeTest
    {
        public bool isFirst;
        public PrimeTest(int value) {
            this.isFirst = true;
            for (int i=2; i<Math.Sqrt(value); i++)
            {
                if (value % i == 0)
                {
                    this.isFirst = false;
                    break;
                }
            }
            ResultManager rm = new ResultManager(6, Convert.ToInt32(this.isFirst));
        }
    }
}
