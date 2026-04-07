/*
    Definition 05
        Write a program to demonstrate the use of try and catch in C#
*/

using System;

namespace Program05 {
    internal class Program{
        static void Main(string[] args) {
            try {
                Console.WriteLine("Enter first number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                int num2 = int.Parse(Console.ReadLine());

                int result = num1 / num2;
                Console.WriteLine($"Division result: {result}");
            } catch (FormatException) {
                Console.WriteLine("Invalid input. Please enter valid integers.");
            } catch (DivideByZeroException) {
                Console.WriteLine("Cannot divide by zero.");
            } catch (Exception ex) {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("Program executed successfully.");
        }
    }
}
