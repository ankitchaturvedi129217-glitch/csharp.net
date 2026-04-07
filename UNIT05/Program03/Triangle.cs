using System;

namespace Program03 {
    class Triangle : Shape {
        double baseLength;
        double height;

        public Triangle(double baseLength, double height) {
            this.baseLength = baseLength;
            this.height = height;
        }

        public override double Area() {
            return (baseLength * height) / 2;
        }

        public override void Display() {
            Console.WriteLine($"Triangle - Base: {baseLength}, Height: {height}");
            base.Display();
        }
    }
}
