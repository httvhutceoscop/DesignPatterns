using System;

namespace DesignPatterns.Examples.Observer
{
    public class ConcreteObserverMailer : IObserver
    {
        public void Update(ConcreteSubjectAccount account)
        {
            var state = account.State;
            var data = account.Data;
            if (state == LoginStatus.EXPIRED)
            {
                Console.WriteLine($"Account {data.Email} has expired. Email sent!");
            }
        }
    }
}