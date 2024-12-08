using System;
using System.Runtime.CompilerServices;
namespace cansoleapp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is a C# console application.");
             while (true)
            {

                Console.WriteLine("Wellcome to my calculator "); 
                Console.WriteLine("press Enter to continue...");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Enter the number1 ");
                double y = 0;
                double.TryParse(Console.ReadLine(), out y);
                Console.Clear();
                Console.WriteLine("Enter the number2 ");
                double z = 0;
                double.TryParse(Console.ReadLine(), out z);
                Console.Clear();
                Console.WriteLine("Enter the number for the calculation \n if you want to + enter number 1 \n if you want to - enter number 2 \n if you want to / enter number 3");
                int x = 0;
                int.TryParse(Console.ReadLine(), out x);
                Console.Clear();
                switch (x)
                {
                    case 1:
                    Console.WriteLine(y + z);
                    break;
                    case 2:
                    Console.WriteLine(y - z);
                    break;
                    case 3:
                    Console.WriteLine(y / z);
                    break;
                    default:
                    Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
                    break;
                }
                 Console.WriteLine("Do you want to restart the program? (yes/no)");
                 string restart = Console.ReadLine();
                 if (restart?.ToLower() != "yes")
                {
                    Console.WriteLine("Exiting program...");
                    break; // Exit the loop and end the program
                }

            }
            
            
        }
    }
}
