using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;

            while (restart)
            {
                Console.WriteLine("Welcome To The Console Project (Calculator)");

                int number1 = GetNumberFromUser("Input the first number");
                int number2 = GetNumberFromUser("Input the second number");

                Console.WriteLine("What do you want to do?");
                Console.WriteLine("[A]dd numbers");
                Console.WriteLine("[S]ubtract numbers");
                Console.WriteLine("[M]ultiply numbers");
                Console.WriteLine("[D]ivide numbers");

                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (char.ToUpper(choice))
                {
                    case 'A':
                        PrintFinalEquation(number1, number2, number1 + number2, "+");
                        break;
                    case 'S':
                        PrintFinalEquation(number1, number2, number1 - number2, "-");
                        break;
                    case 'M':
                        PrintFinalEquation(number1, number2, number1 * number2, "*");
                        break;
                    case 'D':
                        if (number2 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero!");
                        }
                        else
                        {
                            PrintFinalEquation(number1, number2, number1 / (double)number2, "/");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }

                Console.WriteLine("Press 'R' to restart or any other key to exit.");
                restart = Console.ReadKey().Key == ConsoleKey.R;
                Console.WriteLine();
            }
        }

        static int GetNumberFromUser(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.");
                return GetNumberFromUser(message);
            }
            return number;
        }

        static void PrintFinalEquation(double number1, double number2, double result, string @operator)
        {
            Console.WriteLine($"{number1} {@operator} {number2} = {result}");
        }
    }
}
