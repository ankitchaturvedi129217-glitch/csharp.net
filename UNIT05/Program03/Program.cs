/*
    Definition 03
        Describe an abstract class called Shape which has three
        subclasses say Triangle, Rectangle, and Circle. Define one
        method area () in the abstract class and override this area
        () in these three subclasses to calculate for specific objects
        i.e., area () of Triangle subclass should calculate area of
        triangle etc. Same for Rectangle and Circle
*/

using System;

namespace Program03
{
    internal class Program {
        static void Main(string[] args) {
            Triangle triangle = new Triangle(10, 15);
            triangle.Display();

            Console.WriteLine();

            Rectangle rectangle = new Rectangle(20, 25);
            rectangle.Display();

            Console.WriteLine();

            Circle circle = new Circle(7);
            circle.Display();
        }
    }
}
