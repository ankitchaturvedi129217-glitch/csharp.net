using System;

namespace Program03 {
    class Rectangle : Shape {
        double length;
        double width;

        public Rectangle(double length, double width) {
            this.length = length;
            this.width = width;
        }

        public override double Area() {
            return length * width;
        }

        public override void Display() {
            Console.WriteLine($"Rectangle - Length: {length}, Width: {width}");
            base.Display();
        }
    }
}
