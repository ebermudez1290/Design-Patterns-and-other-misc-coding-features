namespace Core.Classes.BuilderModel
{
    public class Ps4Builder: IConsoleBuilder
    {
        Console psConsole;
        public Ps4Builder()
        {
            psConsole = new Console("Play Station 4");
        }
        public void BuildControl()
        {
            psConsole.ControlType = ConsoleParts.ControlType.Dualshock_Four;
        }
        public void BuildCable()
        {
            psConsole.CableType = ConsoleParts.CableType.HDMI;
        }
        public void BuildPowerCord()
        {
            psConsole.PowerCord = ConsoleParts.PowerCord.SixtyFour;
        }
        public Console Console
        {
            get
            {
                return psConsole;
            }
        }
    }
}
