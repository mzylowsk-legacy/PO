using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class InputManager
    {
        public int menu;
        public int value_a;
        public int value_b;

        public void readOption()
        {
            this.menu = Convert.ToInt32(Console.ReadLine());
        }

        public void readValues()
        {
            this.value_a = Convert.ToInt32(Console.ReadLine());
            this.value_b = Convert.ToInt32(Console.ReadLine());
        }

        public void readValue()
        {
            this.value_a = Convert.ToInt32(Console.ReadLine());
        }
    }
}
