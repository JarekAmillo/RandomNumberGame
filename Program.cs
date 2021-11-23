using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tydz3ZadDom2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tydzień trzeci, zadanie domowe numer 2");
            Console.ResetColor();

            var counter = 0;
            var rnd = new Random();
            var number = rnd.Next(0, 100);
            bool game = true;
          
            try
            {
                while (game)
                {
                    counter++;
                    Console.WriteLine("\nWylosowano liczbę z zakresu od 0 do 100. Zgdanij jaka to liczba całkowita. ");
                    int userNumber = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"\nW próbie numer {counter} wskazałeś liczbę {userNumber}.");

                    if (number == userNumber)
                    {
                        Console.Clear();
                        Console.WriteLine($"Super! Liczbę {userNumber} zgadłeś w {counter} próbie.");
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Game Over, naciśnij ENTER aby wyjść z gry.");
                        game = false;
                        Console.ReadLine();

                    }
                    else if (number < userNumber)
                    {
                        Console.WriteLine("Za dużo");

                    }
                    else
                    {
                        Console.WriteLine("Za mało");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
