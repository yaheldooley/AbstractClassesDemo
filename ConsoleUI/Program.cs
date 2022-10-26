using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleUI
{
    partial class Program
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
            List<Vehicle> vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car car = new Car();
            car.Year = "1998";
            car.Make = "Honda";
            car.Model = "Civic";

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Year = "2001";
            motorcycle.Make = "Kawasaki";
            motorcycle.Model = "Ninja";

            Vehicle vehicle1 = new Car();
            Vehicle vehicle2 = new Motorcycle();

			/*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

			// Call each of the drive methods for one car and one motorcycle
			vehicles.Add(car);
			vehicles.Add(motorcycle);
			vehicles.Add(vehicle1);
			vehicles.Add(vehicle2);
            foreach(Vehicle v in vehicles)
            {
				Console.WriteLine("------------------------------------");
                v.PrintProperties();
                Console.WriteLine();
                v.DriveVirtual();
                v.DriveAbstract();
				Console.WriteLine();
			}
			#endregion
			Console.ReadLine();
        }

	}
}
