/*
    Definition 04
        Write a program to illustrate the use of static constructor.
*/

using System;

namespace Program04 {
    class Counter {
        public static int count = 0;
        public int id;

        static Counter() {
            Console.WriteLine("Static constructor called");
        }

        public Counter() {
            count++;
            id = count;
            Console.WriteLine($"Instance constructor called, Count: {count}");
        }

        public void Display() {
            Console.WriteLine($"Object ID: {id}, Total Count: {count}");
        }
    }

    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Creating first object:");
            Counter obj1 = new Counter();
            obj1.Display();

            Console.WriteLine("\nCreating second object:");
            Counter obj2 = new Counter();
            obj2.Display();

            Console.WriteLine("\nCreating third object:");
            Counter obj3 = new Counter();
            obj3.Display();
        }
    }
}
