using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ResultManager
    {
        public ResultManager(int calculation, int result)
        {
            switch (calculation)
            {
                case 1:
                    Console.WriteLine("Wynik dodawania to {0}", result);
                    break;
                case 2:
                    Console.WriteLine("Wynik odejmowania to {0}", result);
                    break;
                case 3:
                    Console.WriteLine("Wynik mnożenia to {0}", result);
                    break;
                case 4:
                    Console.WriteLine("Wynik dzielenia to {0}", result);
                    break;
                case 5:
                    Console.WriteLine("Wynik potęgowania to {0}", result);
                    break;
                case 6:
                    if (result != 0)
                    {
                        Console.WriteLine("Liczba jest pierwsza", result);
                    }
                    else {
                        Console.WriteLine("Liczba NIE jest pierwsza", result);
                    }
                    break;

            }
        }
    }
}
