using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Classes.BuilderModel
{
    public class ConsoleParts
    {
        public enum ControlType
        {
            Dualshock_Four,
            Dualshock_Three,
            Xbox_threeSixtyCtr,
            Xbox_OneCtr,
            Wii_U,
            Wii,
        };

        public enum CableType
        {
            HDMI,
            AV,
        };

        public enum PowerCord
        {
            SixtyFour,
            Thirtytwo,
        };
    }
}
