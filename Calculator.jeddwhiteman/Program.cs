using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using CalculatorLibary;

namespace CalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app


            Console.WriteLine("Console Calculator in C#\n");
            Console.WriteLine("------------------------\n");

            Calculator calculator = new Calculator();

            while (!endApp)
            {
                string? numberInputOne = "";
                string? numberInputTwo = "";
                double result = 0;

                Console.WriteLine("Type a number, and then press enter: ");
                numberInputOne = Console.ReadLine();
                double cleanNumberOne = 0;
                while (!double.TryParse(numberInputOne, out cleanNumberOne))
                {
                    Console.WriteLine("This is not valid input. Please enter a numeric value: ");
                    numberInputOne = Console.ReadLine();
                }


                Console.WriteLine("Type in your second number, then press enter: ");
                numberInputTwo = Console.ReadLine();
                double cleanNumberTwo = 0;
                while (!double.TryParse(numberInputTwo, out cleanNumberTwo))
                {
                    Console.WriteLine("This is not a valid input. Please enter a numeric value: ");
                }

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option: ");

                string? op = Console.ReadLine();

                if (op == null || ! Regex.IsMatch(op,"[a|s|m|d]"))
                {
                    Console.WriteLine("ErrorL Unrecognised input.");
                }
                else
                {
                    try
                    {
                        result = calculator.DoOperation(cleanNumberOne, cleanNumberTwo, op);

                        if (double.IsNaN(result))
                        {
                            Console.WriteLine("This operation will result in a mathematical error.\n");
                        }
                        else
                        {
                            Console.WriteLine("Your result: {0:0.##}\n", result);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"The following error occured: ", ex);
                    }
                }
                Console.WriteLine("------------------------\n");
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;
                Console.WriteLine("\n");
            }

            calculator.Finish();
            return;
        }
    }
}
