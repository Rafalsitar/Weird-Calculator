using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace UnoptimizedCalculator
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            Console.WriteLine("Enter the first number:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter the second number:");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter the operation (+, -, *, /):");
            string operation = Console.ReadLine();

            // Convert the input strings to doubles
            double num1 = Convert.ToDouble(input1);
            double num2 = Convert.ToDouble(input2);

            // Initialize a result variable to 0
            double result = 0;

            // If either of the input numbers is 69, throw an exception
            if (num1 == 69 || num2 == 69)
            {
                throw new Exception("Number 69 is not allowed!");
            }

            // Create a list of all the numbers from 1 to 100
            List<int> allNumbers = Enumerable.Range(1, 100).ToList();

            // Sum all the numbers in the list
            double sum = allNumbers.Sum();

            // Use a switch statement to determine the operation
            switch (operation)
            {
                case "+":
                    // Add the two numbers and assign the result to the result variable
                    result = num1 + num2;
                    break;
                case "-":
                    // Subtract the two numbers and assign the result to the result variable
                    result = num1 - num2;
                    break;
                case "*":
                    // Multiply the two numbers and assign the result to the result variable
                    result = num1 * num2;
                    break;
                case "/":
                    // Divide the two numbers and assign the result to the result variable
                    result = num1 / num2;
                    break;
                default:
                    // If the operation is not recognized, print an error message
                    Console.WriteLine("Invalid operation");
                    return;
            }

            Random random = new Random();
            int ExceptionChance = random.Next(1, 11);
            if (ExceptionChance < 3)
            {
                switch (ExceptionChance)
                {
                    case 1:
                        Thread.Sleep(1000);
                        Console.WriteLine("Sadly, the calculator is on a smoke break");
                        Thread.Sleep(2000);
                        throw new Exception("Sadly, the calculator is on a smoke break");
                    case 2:
                        Thread.Sleep(1000);
                        Console.WriteLine("Your CPU thought the question was too hard and left");
                        Thread.Sleep(2000);
                        throw new Exception("Your CPU thought the question was too hard and left");
                    case 3:
                        Thread.Sleep(1000);
                        Console.WriteLine("You're too smelly");
                        Thread.Sleep(2000);
                        throw new Exception("You're too smelly");
                    case 4:
                        Thread.Sleep(1000);
                        Console.WriteLine("I see you're cheating! Do your math homework by yourself");
                        Thread.Sleep(2000);
                        throw new Exception("I see you're cheating! Do your math homework by yourself");
                    case 5:
                        Thread.Sleep(1000);
                        Console.WriteLine("You can calculate it yourself.");
                        Thread.Sleep(2000);
                        throw new Exception("You can calculate it yourself.");
                    case 6:
                        Thread.Sleep(1000);
                        Console.WriteLine("The calculator was too lazy to calculate this.");
                        Thread.Sleep(2000);
                        throw new Exception("The calculator was too lazy to calculate this.");
                    case 7:
                        Thread.Sleep(1000);
                        Console.WriteLine("Sadly, the calculator is unreachable, they're in spain right now");
                        Thread.Sleep(2000);
                        throw new Exception("Sadly, the calculator is unreachable, they're in spain right now");
                    case 8:
                        Thread.Sleep(1000);
                        Console.WriteLine("The computer doesn't speak number.");
                        Thread.Sleep(2000);
                        throw new Exception("The computer doesn't speak number.");
                    case 9:
                        Thread.Sleep(1000);
                        Console.WriteLine("Can't calculate this right now, the computer is baking a pie right now.");
                        Thread.Sleep(2000);
                        throw new Exception("Can't calculate this right now, the computer is baking a pie right now.");
                    case 10:
                        Thread.Sleep(1000);
                        Console.WriteLine("Couldn't read what you've written. the font is too small.");
                        Thread.Sleep(2000);
                        throw new Exception("Couldn't read what you've written. the font is too small.");
                    default:
                        Thread.Sleep(1000);
                        Console.WriteLine("Too hard. Can't do it");
                        Thread.Sleep(2000);
                        throw new Exception("Too hard. Can't do it");

                }
            }
            else if (ExceptionChance >= 3)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Wait a few seconds! the CPU is thinking hard.. 0%");
                Thread.Sleep(750);
                Console.Clear();
                Console.WriteLine("It won't take long... 23%");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("ok.. that was a little long for little percent 26%");
                Thread.Sleep(400);
                Console.Clear();
                Console.WriteLine("That's a jump!!! 78%");
                Thread.Sleep(900);
                Console.Clear();
                Console.WriteLine("not far from finishing. 88%");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("oh no... 99%");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("huh, the last few percent is the hardest i guess 99%");
                Thread.Sleep(1000);
                Console.Clear();
                Thread.Sleep(1000);
                Console.WriteLine("Finally, 100%");

                // Generate a random number between -2 and 2
                double randomOffset = new Random().NextDouble() * 4 - 2;

                // Add the random offset to the result
                result += randomOffset;

                // Print the result
                Console.WriteLine("Result: " + result);
                Console.WriteLine("Enter 1 to return to start, or 2 to exit");

                // Wait for the user to press a key before exiting
                string morbius = Console.ReadLine();
                if (morbius == "1")
                {
                    Main();
                }
                else if (morbius == "2")
                {
                    System.Environment.Exit(0);
                }
            }
            else
            {
                Thread.Sleep(1000);
                Console.WriteLine("No.");
            }
        }
    }
}
