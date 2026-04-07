using System;

namespace Program03 {
    abstract class Shape {
        public abstract double Area();

        public virtual void Display() {
            Console.WriteLine($"Area: {Area()}");
        }
    }
}
