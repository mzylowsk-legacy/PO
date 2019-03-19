using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuManager menu = new MenuManager();
            InputManager im = new InputManager();
            SimpleCalculator sc = new SimpleCalculator();
            while (true)
            {
                menu.printMenu();
                im.readOption();
                if (im.menu == 8)
                {
                    break;
                }
                if (im.menu >= 1 && im.menu <= 5) {
                    im.readValues();
                    sc.calculate(im.menu, im.value_a, im.value_b);
                }
                if (im.menu == 6 || im.menu == 7) {
                    im.readValue();
                    AdvancedCalculator ac = new AdvancedCalculator(im.menu, im.value_a);
                }
            }
        }
    }
}