using System;
namespace ConsoleUI
{
	public class Car : Vehicle 
	{
        public bool HasTrunk { get; set; } = true;

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a car");
        }
    }
}

