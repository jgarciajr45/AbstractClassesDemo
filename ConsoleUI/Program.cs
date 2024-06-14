using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
           
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car car1 = new Car
            {
                Year = "1984",
                Make = "Ford",
                Model = "Pinto",
                HasTrunk = true
            };
            Motorcycle motorcycle1 = new Motorcycle
            {
                Year = "1984",
                Make = "Honda",
                Model = "Zip",
                HasSideCart = true
            };
            Vehicle vehicle1 = new Car
            {
                Year = "1984",
                Make = "Mazda",
                Model = "ZoomZoom",
                HasTrunk = true
            };
            Vehicle vehicle2 = new Motorcycle
            {
                Year = "1984",
                Make = "Vespa",
                Model = "Piaggio",
                HasSideCart = false
            };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            List<Vehicle> vehicles = new List<Vehicle>
            {
                car1,
                motorcycle1,
                vehicle1,
                vehicle2
            };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
                if (vehicle is Car car)
                {
                    Console.WriteLine($"It has a trunk: {car.HasTrunk}");
                }
                else if (vehicle is Motorcycle motorcylce)
                {
                    Console.WriteLine($"It has a sidecart: {motorcylce.HasSideCart}");
                }
                Console.WriteLine();
            }
            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine("Drive methods for one car:");
            car1.DriveAbstract();
            car1.DriveVirtual();
            Console.WriteLine();
            Console.WriteLine("Drive methods for one motorcycle:");
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();
            #endregion            
            
        }
    }
}
