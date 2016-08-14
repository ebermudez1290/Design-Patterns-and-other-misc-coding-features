using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Classes.BuilderModel.ConsoleParts;
namespace Core.Classes.BuilderModel
{
    public class Console
    {
        #region variables
        private string consoleName;
        private ControlType controlType;
        private CableType cableType;
        private PowerCord powerCord;
        #endregion
        #region public properties
        public string ConsoleName
        {
            get { return consoleName; }
        }
        public ControlType ControlType
        {
            get { return controlType; }
            set { controlType = value; }
        }
        public CableType CableType
        {
            get { return cableType; }
            set { cableType = value; }
        }
        public PowerCord PowerCord
        {
            get { return powerCord; }
            set { powerCord = value; }
        }
        #endregion
        public Console(string name)
        {
            consoleName = name;
        }
        public override string ToString()
        {
            return string.Format("Name: {0} Control Type: {1} Cable Style {2}\nPower Cord: {3}",
                ConsoleName, ControlType, CableType);
        }
    }
}
