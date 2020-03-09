using System;

namespace DesignPatterns.Examples.Template
{
    /// <summary>
    /// Concrete classes have to implement all abstract operations of the base
    /// class. They can also override some operations with a default
    /// implementation.
    /// </summary>
    public class ConcreteClass1 : BaseAbstractClass
    {
        protected override void RequiredOperations1()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation1");
        }

        protected override void RequiredOperation2()
        {
            Console.WriteLine("ConcreteClass1 says: Implemented Operation2");
        }

        
    }
}