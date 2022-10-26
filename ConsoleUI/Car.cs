using System;

namespace ConsoleUI
{
	partial class Program
    {
		public class Car : Vehicle
        {
            public int numberOfDoors = 4;
            public override void DriveAbstract()
            {
				Console.WriteLine("-> Driving car while abstract!");
			}

            public override void PrintProperties()
            {
				Console.WriteLine($" Year: {Year}");
				Console.WriteLine($" Make: {Make}");
				Console.WriteLine($" Model: {Model}");
				Console.WriteLine($" # of Doors: {numberOfDoors}");
			}
        }

	}
}
