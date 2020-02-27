using System;

namespace DesignPatterns.Examples.Observer
{
    public class ConcreteObserverLogger : IObserver
    {
        public void Update(ConcreteSubjectAccount account)
        {
            var state = account.State;
            var data = account.Data;
            if (state == LoginStatus.SUCCESS)
            {
                Console.WriteLine($"User {data.Email} vừa online");
            }
        }
    }
}