/*
    Definition 06
        Write a program to demonstrate the use of try, catch and finally in C#
*/

using System;

namespace Program06 {
    internal class Program {
        static void Main(string[] args) {
            int[] numbers = { 10, 20, 30 };
            int index = 0;

            try {
                Console.WriteLine("Try block started");
                Console.WriteLine("Enter index value (0-2):");
                index = int.Parse(Console.ReadLine());

                int value = numbers[index];
                Console.WriteLine($"Value at index {index}: {value}");
            } catch (FormatException) {
                Console.WriteLine("Catch: Invalid input format.");
            } catch (IndexOutOfRangeException) {
                Console.WriteLine("Catch: Index out of range exception.");
            } catch (Exception ex) {
                Console.WriteLine($"Catch: Exception occurred: {ex.Message}");
            } finally {
                Console.WriteLine("Finally block executed - cleanup code goes here");
            }

            Console.WriteLine("Program completed successfully.");
        }
    }
}
