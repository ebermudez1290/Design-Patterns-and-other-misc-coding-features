namespace Core.Classes.BuilderModel
{
    public class WiiUBuilder: IConsoleBuilder
    {
        Console wiiUConsole;
        public WiiUBuilder()
        {
            wiiUConsole = new Console("Wii U");
        }
        public void BuildControl()
        {
            wiiUConsole.ControlType = ConsoleParts.ControlType.Wii_U;
        }
        public void BuildCable()
        {
            wiiUConsole.CableType = ConsoleParts.CableType.HDMI;
        }
        public void BuildPowerCord()
        {
            wiiUConsole.PowerCord = ConsoleParts.PowerCord.Thirtytwo;
        }
        public Console Console
        {
            get
            {
                return wiiUConsole;
            }
        }
    }
}
