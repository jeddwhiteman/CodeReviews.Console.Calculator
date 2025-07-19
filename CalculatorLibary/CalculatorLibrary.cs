using System.Diagnostics;
using Newtonsoft.Json;

namespace CalculatorLibary
{
    public class Calculator
    {

        JsonWriter writer;

        public Calculator()
        {
            StreamWriter logFile = File.CreateText("calculator.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();
        }
 
            public double DoOperation(double numberOne, double numberTwo, string op)
            {
                double result = double.NaN;

                writer.WriteStartObject();
                writer.WritePropertyName("Operand1");
                writer.WriteValue(numberOne);
                writer.WritePropertyName("Operand2");
                writer.WriteValue(numberTwo);
                writer.WritePropertyName("Operation");

            switch (op)
                {
                    case "a":
                        result = numberOne + numberTwo;
                        Console.WriteLine($"Your result: {numberOne} + {numberTwo} = {result}");
                        writer.WriteValue("Add");
                        break;
                    case "s":
                        result = numberOne - numberTwo;
                        Console.WriteLine($"Your result: {numberOne} - {numberTwo} = {numberOne - numberTwo}");
                        writer.WriteValue("Subtract");
                    break;
                    case "m":
                        result = numberOne * numberTwo;
                        Console.WriteLine($"Your result: {numberOne} * {numberTwo} = {numberOne * numberTwo}");
                        writer.WriteValue("Multiply");
                    break;
                    case "d":
                        result = numberOne / numberTwo;
                        if (numberTwo == 0)
                        {
                            Console.WriteLine("Enter a non-zero denominator: ");
                            numberTwo = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine($"Your result: {numberOne} / {numberTwo} = {numberOne / numberTwo}");
                        writer.WriteValue("Divide");
                    break;

                    default:
                        break;

                }

                writer.WritePropertyName("Result");
                writer.WriteValue(result);
                writer.WriteEndObject();

                return result;
            }

        public void Finish()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
    }
}

