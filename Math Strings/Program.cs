using System;
using System.Collections.Generic;

namespace Math_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are gonna do some maths! What operation would you like to do? Your choices are multiply, square, add, divide or average.");
            var operation = Console.ReadLine();
            

            switch (operation.ToLower())
            {
                case "multiply":
                    Console.WriteLine("Please enter a list of numbers, separated by commas. (No spaces. ie: 2,56,4,7)");
                    var multNumbers = Console.ReadLine();
                    var numbersToMultiply = multNumbers.Split(',');
                    var product = 1;
                    foreach (var num in numbersToMultiply)
                    {
                        var numberInList = Int32.Parse(num);
                        product = numberInList * product;
                    }
                    Console.WriteLine(product);
                    break;
                case "square":
                    Console.WriteLine("Please enter a list of numbers, separated by commas. (No spaces. ie: 2,56,4,7) Then I will square each number in turn.");
                    var squareNumbers = Console.ReadLine();
                    var numbersToSquare = squareNumbers.Split(',');
                    var squares = "";
                    foreach (var num in numbersToSquare)
                    {
                        var numberToSquare = Int32.Parse(num);
                        var squaredNumber = numberToSquare * numberToSquare;
                        squares += squaredNumber.ToString() + ',';
                    }
                    Console.WriteLine(squares.TrimEnd(','));
                    break;
                case "add":
                    Console.WriteLine("Please enter a list of numbers to add together, separated by commas. (No spaces. ie: 2,56,4,7)");
                    var addNumbers = Console.ReadLine();
                    var numbersToAdd = addNumbers.Split(',');
                    var sum = 0;
                    foreach (var num in numbersToAdd)
                    {
                        var numberToAdd = Int32.Parse(num);
                        sum = sum + numberToAdd;
                    }
                    Console.WriteLine(sum);
                    break;
                case "divide":
                    Console.WriteLine("Please enter a dividend and divisor, separated by a comma. (No space. ie: 45,5) I will give you the quotient.");
                    var divideNumbers = Console.ReadLine();
                    var numbersToDivide = divideNumbers.Split(',');
                    var dividend = Int32.Parse(numbersToDivide[0]);
                    var divisor = Int32.Parse(numbersToDivide[1]);
                    var quotient = dividend / divisor;
                    Console.WriteLine(quotient);
                    break;
                case "average":
                    Console.WriteLine("Please enter a list of numbers to average, separated by a comma. (No spaces. ie: 2,56,99,4)");
                    var averageNumbers = Console.ReadLine();
                    var numbersToAverage = averageNumbers.Split(',');
                    var total = 0;
                    foreach (var num in numbersToAverage)
                    {
                        var numberToAdd = Int32.Parse(num);
                        total = total + numberToAdd;
                    }
                    var average = total / numbersToAverage.Length;
                    Console.WriteLine(average);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
    }
}
