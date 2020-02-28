using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Examples.Observer
{
    public class ConcreteSubjectAccount : ISubject
    {
        public LoginStatus State { get; set; }
        public List<IObserver> Storage;
        public LoginRequestModel Data { get; set; }
        public ConcreteSubjectAccount()
        {
            Storage = new List<IObserver>();
        }

        /// <summary>
        /// Attach 1 Observer
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(IObserver observer)
        {
            var isContain = Storage.Contains(observer);

            if (isContain == false)
            {
                Storage.Add(observer);
            }
        }

        /// <summary>
        /// Xóa 1 Observer ra khỏi danh sách
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(IObserver observer)
        {
            Storage = Storage.Where(s => s != observer).ToList();
        }

        /// <summary>
        /// Gửi thông báo update tới tất cả các observers trong hệ thống
        /// </summary>
        public void Notify()
        {
            foreach (var observer in Storage)
            {
                observer.Update(this);
            }
        }

        public void Login(LoginRequestModel loginRequest)
        {
            Data = loginRequest;

            if (loginRequest.Email.Equals("viet.nguyen@fujitechjsc.com") && loginRequest.IP.Equals("127.0.0.1"))
            {
                State = LoginStatus.INVALID;
            }
            else
            {
                var login = Process(loginRequest.Email);

                State = login ? LoginStatus.SUCCESS : LoginStatus.FAILURE;
            }

            Notify();
        }

        public void Save()
        {
            Notify();
        }

        public bool Process(string email) => email.Equals("viet.nguyen@fujitechjsc.com");

    }
}