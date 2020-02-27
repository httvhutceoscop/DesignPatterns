namespace DesignPatterns.Examples.Observer
{
    public interface IObserver
    {
         public void Update(ConcreteSubjectAccount account);
    }
}