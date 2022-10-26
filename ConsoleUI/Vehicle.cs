using System;

namespace ConsoleUI
{
	partial class Program
    {
		public abstract class Vehicle
        {
            public string Year = "1900";
            public string Make = "Unspecified Make";
            public string Model = "Unspecified Model";

            public abstract void DriveAbstract();
            public virtual void DriveVirtual()
            {
                Console.WriteLine("-> Default Driving virtually!");
            }
            public abstract void PrintProperties();


        }

	}
}
