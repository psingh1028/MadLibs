using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace madLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Mad Libs app!");

            string[][] madlibs =
            {
                new string [] {"lawyer","the lawyer was {0} when his client {1} on the table","adjective","verb"},
                new string [] {"Basketball Player","The basketball player {0} because he was {1}","verb","adjective"}
            };

            for(int i =0;i<madlibs.Length;i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, madlibs[i][0]);
            }
            Console.WriteLine("Please enter the number corresponding to the story");
            int choice = int.Parse(Console.ReadLine());

            if(choice==1)
            {
                Console.WriteLine("Please enter an adjective");
                string adjective1 = Console.ReadLine();
                Console.WriteLine("Please enter a verb");
                string verb1 = Console.ReadLine();
                string finaltext = string.Format(madlibs[0][1], adjective1, verb1);
                Console.WriteLine(finaltext);
            }
            else if(choice ==2)
            {
                Console.WriteLine("Please enter a verb");
                string adjective2 = Console.ReadLine();
                Console.WriteLine("Please enter a verb");
                string verb2 = Console.ReadLine();
                string finaltext = string.Format(madlibs[1][1], adjective2, verb2);
                Console.WriteLine(finaltext);

            }
            Console.ReadKey();
        }
    }
}
