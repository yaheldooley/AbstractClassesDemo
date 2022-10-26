using System;

namespace ConsoleUI
{
	partial class Program
    {
		public class Motorcycle : Vehicle
		{
			public bool hasSidecar = false;
			public override void DriveAbstract()
			{
				Console.WriteLine("-> Driving motorcycle while abstract!");
			}

            public override void DriveVirtual()
            {
				Console.WriteLine("-> Driving motorcycle virtually!");
			}

            public override void PrintProperties()
            {
				Console.WriteLine($" Year: {Year}");
				Console.WriteLine($" Make: {Make}");
				Console.WriteLine($" Model: {Model}");
				Console.WriteLine($" Has Sidecar: {hasSidecar}");
			}
        }

	}
}
