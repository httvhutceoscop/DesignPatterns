namespace DesignPatterns.Examples.Decorator
{
    public class CD : ComponentDecorator
    {
        Computer _computer;
        public CD(Computer computer)
        {
            _computer = computer;
        }

        public override string GetDescription() => _computer.GetDescription() + " and a CD";
    }
}