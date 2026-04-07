using System;

namespace Program03 {
    class Circle : Shape {
        double radius;

        public Circle(double radius) {
            this.radius = radius;
        }

        public override double Area() {
            return Math.PI * radius * radius;
        }

        public override void Display() {
            Console.WriteLine($"Circle - Radius: {radius}");
            base.Display();
        }
    }
}
