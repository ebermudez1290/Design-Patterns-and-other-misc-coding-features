namespace Core.Classes.BuilderModel
{
    public class Manufacturer
    {
        public void Construct(IConsoleBuilder consoleBuilder)
        {
            consoleBuilder.BuildControl();
            consoleBuilder.BuildCable();
            consoleBuilder.BuildPowerCord();
        }
    }
}
