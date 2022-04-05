using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaDomowa02Tydzień04
{
    class FizzBuzz
    {
        public void Game()
        {
            try
            { 
            Console.WriteLine("Witaj w prostej grze o nazwie FizzBuzz, proszę podaj swoją liczbę:");
            var number = int.Parse(Console.ReadLine());
           
                if ((number % 3) == 0 && (number % 5) != 0)
                    Console.WriteLine("Fizz!");
                else if ((number % 5) == 0 && (number % 3) != 0)
                    Console.WriteLine("Buzz!");
                else if ((number % 3) == 0 && (number % 5) == 0)
                    Console.WriteLine("FizzBuzz!");
                else
                    Console.WriteLine(number);
            } 
            catch (Exception)
            {
                Console.WriteLine("Podałeś niepoprawne dane!");
            }
        }

    }
}
