using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
        public string Year { get; set; } = "Generic Year";
        public string Make { get; set; } = "Generic Make";
        public string Model { get; set; } = "Generic Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Driving a vehicle");
        }
    }
}

