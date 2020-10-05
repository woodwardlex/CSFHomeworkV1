using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomewordV1
{
    class MadLib
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mad Lib\n");
            Console.Write("Give a noun: ");
            string noun1 = Console.ReadLine();

            Console.Write("Give a verb: ");
            string verb1 = Console.ReadLine();

            Console.Write("Give an adjective: ");
            string adjective1 = Console.ReadLine();

            Console.Write("Give another noun: ");
            string noun2 = Console.ReadLine();

            Console.Write("Give another verb: ");
            string verb2 = Console.ReadLine();

            Console.Write("Give another ajective: ");
            string adjective2 = Console.ReadLine();

            Console.WriteLine($"The {noun1} had {verb1} a {adjective1} {noun2} in the {verb2} of the {adjective2} castle.");
        }
    }
}
