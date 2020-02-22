using System;

namespace DesignPatterns.Examples.Decorator
{
    public class RunDecorator
    {
        public static void Run()
        {
            Console.WriteLine("===== Decorator =====");
            Console.WriteLine("\n");

            Computer computer = new Computer();
            computer = new Disk(computer);

            Console.WriteLine("You're getting a " + computer.GetDescription() + ".");
            Console.WriteLine("\n");
        }
    }
}