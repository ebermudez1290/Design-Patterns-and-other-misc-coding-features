namespace Core.Classes.BuilderModel
{
    public interface IConsoleBuilder
    {
        void BuildControl();
        void BuildCable();
        void BuildPowerCord();
        Console Console { get; }
    }
}
