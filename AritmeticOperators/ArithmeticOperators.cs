using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AritmeticOperators
{
    public class ArithmeticOperators
    {
        static void Main(string[] args)
        {
            int friends = 5;

            friends = friends + 1;
            //friends += 1;
            //friends++;

            //friends = friends - 1;
            //friends -= 1;
            //friends--;

            //friends = friends * 2;
            //friends *= 2;

            //friends = friends / 2;
            //friends /= 2;

            //int remainder = friends % 2;
            //Console.WriteLine(remainder);

            Console.WriteLine(friends);

            Console.ReadKey();
        }
    }
}