/* Definition 01
Write a program to demonstrate use of inheritance.*/

using System;

namespace Program01 {
    class Animal {
        public virtual void Eat() {
            Console.WriteLine("Animal eating");
        }

        public virtual void Sleep() {
            Console.WriteLine("Animal sleeping");
        }
    }

    class Dog : Animal {
        public override void Eat() {
            Console.WriteLine("Dog eating");
        }

        public override void Sleep() {
            Console.WriteLine("Dog sleeping");
        }

        public void Bark() {
            Console.WriteLine("Dog barking");
        }
    }

    internal class Program {
        static void Main(string[] args) {
            Dog dog = new Dog();
            dog.Eat();
            dog.Sleep();
            dog.Bark();
        }
    }
}
