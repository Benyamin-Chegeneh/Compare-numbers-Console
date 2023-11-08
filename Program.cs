using System;
namespace Compare_the_numbers___Console
{
    internal class Program
    {
        public static void Main()
        {
            try
            {
                int a;
                int b;
                string help_app;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Enter your Number for Compare : ");
                Console.ForegroundColor = ConsoleColor.Blue;
                help_app = Console.ReadLine();
                a = int.Parse(help_app);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Enter your Number for Compare : ");
                Console.ForegroundColor = ConsoleColor.Blue;
                help_app = Console.ReadLine();
                b = int.Parse(help_app);
                int Result = Biggest(a, b);
                if (a == b)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("---------------------------------------\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Both numbers are the same");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n---------------------------------------\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("---------------------------------------\n");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Biggest Number is " + Result);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n---------------------------------------\n");
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Are you repeat a Task ? (y/n) : ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string yn = Console.ReadLine();
                switch (yn)
                {
                    case "y":
                        System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
                        System.Environment.Exit(0);
                        break;
                    case "n":
                        System.Environment.Exit(0);
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }
            }
            catch (Exception)
            {
                System.Environment.Exit(0);
            }
        }
        public static int Biggest(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
    }
}
