using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2015_07_09_FizzBuzz
{
    class Program
    {
        //for numbers 1 through 100, writes "Fizz" if divisible by 3; "Buzz" if divisible by 5; and "FizzBuzz" if divisible by both (that is, if divisible by 15)

        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.Write("For a 1-to-100 round of FizzBuzz, press <Enter>: ");
            Console.ReadLine();

            for (int x = 1; x <= 100; x++)
            {
                Console.WriteLine();
                Console.Write(x + ": ");

                //if divisible by 15, print "FizzBuzz"

                if (x % 15 == 0)
                    Console.WriteLine("FizzBuzz");

                //if divisible by 3 (but not by 5), print "Fizz"

                else if (x % 3 == 0)
                    Console.WriteLine("Fizz");

                //if divisible by 5 (but not by 3), print "Buzz"

                else if (x % 5 == 0)
                    Console.WriteLine("Buzz");

                else Console.WriteLine("Divisible by neither 3 nor 5.");

            }
            Console.ReadLine();
        }
    }
}
