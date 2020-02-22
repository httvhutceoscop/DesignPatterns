namespace DesignPatterns.Examples.Decorator
{
    public class Disk : ComponentDecorator
    {
        Computer _computer;
        public Disk(Computer computer)
        {
            _computer = computer;
        }

        public override string GetDescription() => _computer.GetDescription() + " and a disk";
    }
}