using System;

namespace DesignPatterns.Examples.Template
{
    public class RunTemplate
    {
        public static void Run()
        {
            Console.WriteLine("===== Template =====");
            Console.WriteLine("\n");

            Console.WriteLine("Same client code can work with different subclasses:");

            Client.ClientCode(new ConcreteClass1());

            Console.Write("\n");
            
            Console.WriteLine("Same client code can work with different subclasses:");
            Client.ClientCode(new ConcreteClass2());

            Console.WriteLine("\n");
        }
    }
}