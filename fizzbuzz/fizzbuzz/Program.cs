using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main()
        {

            for (int counter = 1; counter <= 50; counter++)
            {
                if (counter % 15 == 0)
                    Console.Write("FizzBuzz");

                else if (counter % 3 == 0)
                    Console.Write("Fizz");

                else if (counter % 5 == 0)
                    Console.Write("Buzz");            

                else
                    Console.Write(counter);
                Console.ReadLine();
            }
        }

        //public class FizzBuzz
        //{

        //    public int Fizz(int result)
        //    {

        //        for (int counter = 0; counter <= 50; counter++)
        //        {
        //            if (counter % 3 == 0)
        //                Console.Write("Fizz");
        //            else if (counter % 5 == 0)
        //                Console.Write("Buzz");
        //            else if (counter % 3 == 0 || counter % 5 == 0)
        //                Console.Write("FizzBuzz");
        //            else
        //                return counter;

        //        }
            }
        }
    
