using System;

namespace DesignPatterns.Examples.Observer
{
    public class ConcreteObserverSecurity : IObserver
    {
        public void Update(ConcreteSubjectAccount account)
        {
            var state = account.State;
            var data = account.Data;
            if (state == LoginStatus.INVALID)
            {
                Console.WriteLine($"Account {data.Email} with ip {data.IP} are trying to hack our system");
            }
        }
    }
}