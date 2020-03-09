using DesignPatterns.Examples.Decorator;
using DesignPatterns.Examples.Factory;
using DesignPatterns.Examples.Flyweight;
using DesignPatterns.Examples.Observer;
using DesignPatterns.Examples.Singleton;
using DesignPatterns.Examples.Template;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDecorator.Run();
            RunFactory.Run();
            RunSingleton.Run();
            RunObserver.Run();
            RunFlyweight.Run();
            RunTemplate.Run();
        }
    }
}
