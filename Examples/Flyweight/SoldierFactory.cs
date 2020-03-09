using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Examples.Flyweight
{
    /// <summary>
    /// Flyweight Factory
    /// </summary>
    public class SoldierFactory
    {
        private static Dictionary<string, ISoldier> soldiers = new Dictionary<string, ISoldier>();
        private SoldierFactory()
        {
            throw new Exception("Fuck man");
        }

        public static ISoldier CreateSoldier(string name)
        {
            ISoldier soldier = soldiers.GetValueOrDefault(name);

            if (soldier == null)
            {
                WaitingForCreateASoldier();
                soldier = new Soldier(name);
                soldiers.Add(name, soldier);
            }

            return soldier;
        }

        public static int GetTotalOfSoldiers() => soldiers.Count;

        private static void WaitingForCreateASoldier()
        {
            try
            {
                Console.WriteLine("Sleep for 3000 seconds");
                Thread.Sleep(3000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}