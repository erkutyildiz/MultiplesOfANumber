using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesOfANumber
{

//    If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

//Find the sum of all the multiples of 3 or 5 below 1000.

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please input a limit to sum natural number until to this limit");
            //according to problem, it should be 1000
            int limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total : {0}", FindMultipleOf3And5(limit));
            Console.ReadLine();
        }

        public static int FindMultipleOf3And5(int limit)
        {
            int total = 0;
            for (int i = 0; i < limit; i++)
            {
                if (i%3 == 0 || i % 5 == 0)
                {
                    total = total + i;
                }
            }
           return total;
        }
    }
}
