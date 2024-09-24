using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Variables
{
    public class Variables
    {
        static void Main(string[] args)
        {
            int x; // declaration
            x = 123; // initialization

            int y = 321; // declaration + initialization

            int z = x + y;

            int age = 21.5; // whole integer
            double height = 300.5; // decimal
            bool alive = false; // boolean
            char symbol = '@'; // character
            string name "John" // String

            
            Console.WriteLine("Your age is " + age );
            Console.WriteLine("Your height is " + height + " cm" );
            Console.WriteLine("Are you alive" + alive );
            Console.WriteLine("Your symbol is" + symbol );

            String userName = symbol + name;

            Console.WriteLine("Your username is: " + userName)

            Console.ReadKey();
        }
    }
}