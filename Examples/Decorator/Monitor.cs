namespace DesignPatterns.Examples.Decorator
{
    public class Monitor : ComponentDecorator
    {
        Computer _computer;
        public Monitor(Computer computer)
        {
            _computer = computer;
        }

        public override string GetDescription() => _computer.GetDescription() + " and a monitor";
    }
}