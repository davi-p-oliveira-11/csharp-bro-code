using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserInput
{
    public class Userinput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name ?");
            String name = Console.ReadLine();

            Console.WriteLine("What's your age ?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You're " + age + " years old");

            Console.ReadLine();
            
        }
    }
}