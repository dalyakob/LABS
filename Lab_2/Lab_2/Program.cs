using System;

namespace Lab_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string condition;

            Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!\n");

            do
            {
                float length, width;
                while (true) {
                    try
                    {
                        Console.Write("Enter Length: ");
                        length = float.Parse(Console.ReadLine());

                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Length, Please Try Again!");
                    }
                }
                while (true)
                {
                    try
                    {
                        Console.Write("Enter width: ");
                        width = float.Parse(Console.ReadLine());

                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid Width, Please Try Again!");
                    }
                }

                Console.WriteLine("\nPerimeter: " + (2*(width + length)));

                Console.WriteLine("Area: " + (width * length));

                Console.WriteLine();

                Console.WriteLine("Would you like to measure another room? (y/n)");
                condition = Console.ReadLine().ToLower();

                } while (condition == "y");

            Console.WriteLine("\nThanks for using this our Room Detail Generator, goodbye!!! :)");
        }
    }
}
