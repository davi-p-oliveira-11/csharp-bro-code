using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contants
{
    public class Constants
    {
       static void Main(string[] args)
       {
         // constants = immutable values which are known at the compile time
         //           =  and do noy change for the life of the program

         const double pi = 3.14;

         //pi = 320;

         Console.WriteLine(pi);


         Console.ReadKey();
       }   
    }
}