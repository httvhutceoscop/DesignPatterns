using System;

namespace DesignPatterns.Examples.Flyweight
{
    /// <summary>
    /// Concrete Flyweight
    /// </summary>
    public class Soldier : ISoldier
    {
        private readonly string _name; // Intrinsic state

        public Soldier(string name)
        {
            _name = name;
            Console.WriteLine($"Soldier is created! - {_name}");
        }

        public void Promote(Context context)
        {
            Console.WriteLine($"{_name} {context.GetId().ToString()} promoted {context.GetStar()}");
        }
    }
}