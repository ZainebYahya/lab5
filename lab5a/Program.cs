using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5a
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = ""; int i = 1;
            Console.Write("Welcom to the Grand Circus Casino! Roll the dice?(y/n): ","\n\n");
             answer = Console.ReadLine();
            while (answer == "Y" || answer == "y")
            {

                
                Console.Write("How many sides should each die have?: ");
                int die2 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"Roll{i}:");
                i += 1;



                Console.WriteLine(rollingdice(die2));
                System.Threading.Thread.Sleep(50);

                Console.WriteLine(rollingdice(die2));
                Console.WriteLine("\n" );

                Console.Write("Roll again?(y/n):  " + "\n");

                answer = Console.ReadLine();
                if (answer == "n" || answer == "N") 
                {
                    Console.WriteLine("Bye!");
                    break;
                }
            else
                {
                    continue;
                }
            }
            Console.WriteLine("Bye!");
        }

        public static int rollingdice(int die2)
        {
            Random random = new Random();
            int num = random.Next(1, die2);

            return num;
        }
       


    }
}
