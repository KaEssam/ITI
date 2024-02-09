using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_C__Advanced
{
    public class FirstInterface
    {
        public static void Main(string[] args)
        {
            Car car = new Car(0);

            // Using IVehicle methods
            int fuel = int.Parse(Console.ReadLine());
            if (car.Refuel(fuel))
            {
                car.Drive();
            }

            // Using IDrivable methods
            IDrivable drivableCar = new Car(20);
            drivableCar.Move();
            drivableCar.Accelerate();
            drivableCar.Drive();

            Console.ReadLine();
        }


        // Create IVehicle interface
        public interface IVehicle
        {
            void Drive();
            bool Refuel(int amount);
        }

        // Create IDrivable interface 
        public interface IDrivable
        {
            void Move();
            void Accelerate();
            void Drive();
        }



        //2- create a Car class 
        public class Car : IVehicle, IDrivable
        {
            public int Fuel { get; set; }

            // Constructor
            public Car(int fuel)
            {
                Fuel = fuel;
            }

            // IVehicle Interface Implementation
            public void Drive()
            {
                if (Fuel > 0)
                {
                    Console.WriteLine("Car is Driving");
                }
                else
                {
                    Console.WriteLine("Out of fuel");
                }
            }

            public bool Refuel(int amount)
            {
                if (amount < 0)
                {
                    Console.WriteLine("Invalid amount for refueling");
                    return false;
                }

                Fuel += amount;
                return true;
            }

            // IDrivable Interface Implementation
            void IDrivable.Move()
            {
                Console.WriteLine("Car is Moving");
            }

            void IDrivable.Accelerate()
            {
                Console.WriteLine("Car is Accelerating");
            }

            void IDrivable.Drive()
            {
                Console.WriteLine("Car is Driven");
            }
        }

    }

}




