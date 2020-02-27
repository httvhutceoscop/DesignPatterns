namespace DesignPatterns.Examples.Observer
{
    public interface ISubject
    {
        public void Attach(IObserver observer);

        public void Detach(IObserver observer);

        public void Notify();
        bool Process(string email);
    }
}