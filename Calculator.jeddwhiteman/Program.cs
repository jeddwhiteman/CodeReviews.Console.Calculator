using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace Calculator.jeddwhiteman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberOne = 0, numberTwo = 0;

            Console.WriteLine("Console Calculator in C#\n");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Type a number, and then press enter: ");
            numberTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type in your second number, then press enter: ");
            numberOne = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option: ");



            Console.WriteLine("Press any key to close the calculator app.");
            Console.ReadLine();
        }
    }
}
