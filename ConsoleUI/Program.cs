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
           var vehicles = new List<Vehicle>();

            var Car1 = new Car()
            {
                HasTrunk = true,
                Year = "2017",
                Make = "Chevy",
                Model = "Malibu",
            };


            var Motorcycle1 = new Motorcycle()
            {
                HasSideCart = true,
                Year = "2009",
                Make = "Kawasaki",
                Model = "Thunder",

            };


            Vehicle vehicle1 = new Car()
            {
                HasTrunk = true,
                Year = "2019",
                Make = "Ford",
                Model = "Raptor",
            };


            Vehicle vehicle2 = new Motorcycle()
            {
                HasSideCart = false,
                Year = "2020",
                Make = "Yamaha",
                Model = "Lightning",
            };

            vehicles.Add(Car1);
            vehicles.Add(Motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
                Console.WriteLine();
            }


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
             * 
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

                #endregion
            
        }
    }
}
