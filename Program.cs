using DesignPatterns.Examples.Decorator;
using DesignPatterns.Examples.Factory;
using DesignPatterns.Examples.Singleton;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDecorator.Run();
            RunFactory.Run();
            RunSingleton.Run();
        }
    }
}
