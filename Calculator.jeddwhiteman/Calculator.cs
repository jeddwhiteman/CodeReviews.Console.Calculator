﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.jeddwhiteman
{
    internal class Calculator
    {
        public static double Calcualor(double numberOne, double numberTwo, string op)
        {
                double result = 0;
                switch (Console.ReadLine().ToLower())
                {
                    case "a":
                        result = numberOne + numberTwo;
                        Console.WriteLine($"Your result: {numberOne} + {numberTwo} = {result}");
                        break;
                    case "s":
                        result = numberOne - numberTwo;
                        Console.WriteLine($"Your result: {numberOne} - {numberTwo} = {numberOne - numberTwo}");
                        break;
                    case "m":
                        result = numberOne * numberTwo;
                        Console.WriteLine($"Your result: {numberOne} * {numberTwo} = {numberOne * numberTwo}");
                        break;
                    case "d":
                        result = numberOne / numberTwo;
                        if (numberTwo == 0)
                        {
                            Console.WriteLine("Enter a non-zero denominator: ");
                            numberTwo = Convert.ToDouble(Console.ReadLine());
                        }
                        Console.WriteLine($"Your result: {numberOne} / {numberTwo} = {numberOne / numberTwo}");
                        break;

                }

                return result;
        }
    }
}
