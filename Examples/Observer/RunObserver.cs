using System;

namespace DesignPatterns.Examples.Observer
{
    public class RunObserver
    {
        public static void Run()
        {
            Console.WriteLine("===== Observer, Chain of Responsibility =====");
            Console.WriteLine("\n");

            var account = new ConcreteSubjectAccount();
            var security = new ConcreteObserverSecurity();
            var logger = new ConcreteObserverLogger();
            var mailer = new ConcreteObserverMailer();

            // Attach các observer vào subject 
            account.Attach(security);
            account.Attach(logger);
            account.Attach(mailer);

            // Login
            account.Login(new LoginRequestModel
            {
                Email = "tienvietnguyen1110@gmail.com",
                IP = "192.168.0.1"
            });

            // Change state
            account.State = LoginStatus.EXPIRED;
            account.Save();

            // Login again
            account.Login(new LoginRequestModel
            {
                Email = "viet.nguyen@fujitechjsc.com",
                IP = "127.0.0.1"
            });

            // Xóa security observer
            account.Detach(security);
            account.Login(new LoginRequestModel
            {
                Email = "viet.nguyen@fujitechjsc.com",
                IP = "127.0.0.2"
            });

            Console.WriteLine("\n");
        }
    }
}