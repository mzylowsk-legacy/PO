using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class MenuManager
    {
        public void printMenu()
        {
            Console.WriteLine("1. Dodaj dwie liczby");
            Console.WriteLine("2. Odejmij dwie liczby");
            Console.WriteLine("3. Pomnóż dwie liczby");
            Console.WriteLine("4. Podziel dwie liczby");
            Console.WriteLine("5. Podnieś pierwszą liczbę do potęgi drugiej");
            Console.WriteLine("6. Test pierwszości liczby");
            Console.WriteLine("7. Wartość ciągu fibonacciego dla podanego numeru wyrazu");
            Console.WriteLine("8. Wyjście");
        }

    }
}
