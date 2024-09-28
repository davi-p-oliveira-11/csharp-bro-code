using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhileLoop
{
    public class WhileLoop
    {
         static void Main(string[] args)
        {

            // while loop = repeats some code while some condition remains true

            String name = "";

            while (name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}