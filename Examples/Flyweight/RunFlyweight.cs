using System;
using System.Collections.Generic;

namespace DesignPatterns.Examples.Flyweight
{
    public class RunFlyweight
    {
        private static List<ISoldier> soldiers = new List<ISoldier>();
        public static void Run()
        {
            Console.WriteLine("===== Flyweight =====");
            Console.WriteLine("\n");

            var startTime = DateTime.Now;
            CreateSoldier(5, "Yuri", 1);
            CreateSoldier(5, "Spy", 1);
            CreateSoldier(3, "Spy", 3);
            CreateSoldier(2, "Yuri", 2);
            var endTime = DateTime.Now;

            var diffInSeconds = (endTime - startTime).TotalSeconds;

            Console.WriteLine("================================");
            Console.WriteLine("startTime : " + startTime);
            Console.WriteLine("endTime : " + endTime);
            Console.WriteLine("Total soldiers made : " + soldiers.Count);
            Console.WriteLine("Total time worked : " + diffInSeconds + " seconds");
            Console.WriteLine("Total type of soldiers made : " + SoldierFactory.GetTotalOfSoldiers());

            Console.WriteLine("\n");
        }

        private static void CreateSoldier(int numberOfSoldier, string soliderName, int numberOfStar)
        {
            for (int i = 1; i <= numberOfSoldier; i++)
            {
                Context star = new Context($"Soldier {(soldiers.Count + 1).ToString()}", numberOfStar);
                ISoldier soldier = SoldierFactory.CreateSoldier(soliderName);
                soldier.Promote(star);
                soldiers.Add(soldier);
            }
        }
    }
}