using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class SimpleCalculator
    {
        private int value_a;
        private int value_b;

        private int result;
        private void addValues() {
            this.result = this.value_a + this.value_b;
        }
        private void diffValues()
        {
            this.result = this.value_a - this.value_b;
        }
        private void mulValues()
        {
            this.result = this.value_a * this.value_b;
        }

        private void divValues()
        {
            this.result = this.value_a / this.value_b;
        }

        private void powerValues()
        {
            this.result = Convert.ToInt32(Math.Pow(Convert.ToDouble(this.value_a), Convert.ToDouble(this.value_b)));
        }

        public void calculate(int calculation, int a, int b)
        {
            this.value_a = a;
            this.value_b = b;

            switch (calculation) {
                case 1: this.addValues();
                    break;
                case 2: this.diffValues();
                    break;
                case 3: this.mulValues();
                    break;
                case 4: this.divValues();
                    break;
                case 5: this.powerValues();
                    break;
            }

            ResultManager rm = new ResultManager(calculation, this.result);
        }
    }
}
