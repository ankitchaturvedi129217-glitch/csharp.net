/*Definition 02
Write a program to illustrate the use of abstract class.*/

using System;

namespace Program02 {
    abstract class Vehicle {
        public abstract void Start();
        public abstract void Stop();

        public void Drive() {
            Console.WriteLine("Vehicle is driving");
        }
    }

    class Car : Vehicle {
        public override void Start() {
            Console.WriteLine("Car starting");
        }

        public override void Stop() {
            Console.WriteLine("Car stopping");
        }
    }

    class Bike : Vehicle {
        public override void Start() {
            Console.WriteLine("Bike starting");
        }

        public override void Stop() {
            Console.WriteLine("Bike stopping");
        }
    }

    internal class Program {
        static void Main(string[] args) {
            Car car = new Car();
            car.Start();
            car.Drive();
            car.Stop();

            Console.WriteLine();

            Bike bike = new Bike();
            bike.Start();
            bike.Drive();
            bike.Stop();
        }
    }
}
