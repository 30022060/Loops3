using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAgain
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Select Symbol to use for shape");
            string sym = Console.ReadLine();
            Console.Write("Choose height of shape");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("choose width of shape");
            int width = int.Parse(Console.ReadLine());

            for (int oof = 0; oof < height; oof++)
            {
                for (int eep = 0; eep < width; eep++)
                {
                    Console.Write(sym);
                }
                Console.WriteLine();
                Console.ReadLine();
            }





            //Task 2

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("This Prog will ask for numbers to be added together");

            double total = 0;

            for (int num2 = 1; num2 <= 10; num2++)
                Console.Write($"Enter Number:{num2}");
            total = double.Parse(Console.ReadLine());

            Console.WriteLine($"Total Number is {total}");
            Console.ReadLine();

            //Task 3

            Console.WriteLine("This Prog will show ask for a number and show all even numbers\nthat value is less");
            int num3 = Convert.ToInt32(Console.ReadLine());


                 
        }
    }
}
