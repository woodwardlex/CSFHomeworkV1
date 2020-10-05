using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomewordV1
{
    class FrootLoops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FrootLoops\n");
            string[] fruits = new string[6];

            fruits[0] = "grape";
            fruits[1] = "apple";
            fruits[2] = "strawberry";
            fruits[3] = "lemon";
            fruits[4] = "pineapple";
            fruits[5] = "melon";

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);

            }

            int a = Array.IndexOf(fruits, "grape");
            Console.WriteLine(a);
            Console.WriteLine();

            int b = Array.IndexOf(fruits, "apple");
            Console.WriteLine(b);
            Console.WriteLine();

            int c = Array.IndexOf(fruits, "strawberry");
            Console.WriteLine(c);
            Console.WriteLine();

            int d = Array.IndexOf(fruits, "lemon");
            Console.WriteLine(d);
            Console.WriteLine();

            int e = Array.IndexOf(fruits, "pineapple");
            Console.WriteLine(e);
            Console.WriteLine();

            int f = Array.IndexOf(fruits, "melon");
            Console.WriteLine(f);
            Console.WriteLine();
        }
    }
}
