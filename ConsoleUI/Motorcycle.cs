using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
        public bool HasSideCart { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("Driving a motorcycle");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Driving a motorcycle (overridden)");
        }
    }
}

