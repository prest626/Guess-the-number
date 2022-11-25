using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random rand = new Random();
            int num = rand.Next(1, 25);
            Console.Write("Guess a number between 1 and 25\n");
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != num) {
                if (choice >=num+ 5)
                    {
                        Console.WriteLine("A little Lower ");
                    }
                else if (choice <= num - 5)
                    {
                        Console.WriteLine("A little Higher ");
                    }
                else
                {
                    break;
                }
            
                Console.Write("Guess ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("WINNER");
            
            */
            Console.Write("Enter your range of numbers\n");
            int min = Convert.ToInt32(Console.ReadLine());
            int max = Convert.ToInt32(Console.ReadLine());
            numgues(min, max);
            Console.Read();
        }
   public static void numgues(int min, int max)
        {
            Random rand = new Random();
            int num = rand.Next(min, max);
            Console.Write(String.Format("Guess a number between {0} and {1}\n",min,max));
            int choice = Convert.ToInt32(Console.ReadLine());

            while (choice != num)
            {
                if (choice >= num + 5)
                {
                    Console.WriteLine("A little Lower ");
                }
                else if (choice <= num - 5)
                {
                    Console.WriteLine("A little Higher ");
                }
                else
                {
                    break;
                }

                Console.Write("Guess ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("WINNER");
        }
    }
}
