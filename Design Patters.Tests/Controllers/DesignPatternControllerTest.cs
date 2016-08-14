using Core.Classes.BuilderModel;
using Design_Patters.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
namespace Design_Patters.Tests.Controllers
{
    [TestClass]
    public class DesignPatternControllerTest
    {
        [TestMethod]
        public void Index()
        {
            DesignPatternController controller = new DesignPatternController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ValidatePs4()
        {
            Manufacturer manufacturer = new Manufacturer();
            IConsoleBuilder ps4Builder = new Ps4Builder();
            manufacturer.Construct(ps4Builder);
            Assert.IsTrue(ps4Builder.Console.PowerCord == ConsoleParts.PowerCord.SixtyFour);
        }
        [TestMethod]
        public void ValidateWiiU()
        {
            Manufacturer manufacturer = new Manufacturer();
            IConsoleBuilder wiiUBuilder = new WiiUBuilder();
            manufacturer.Construct(wiiUBuilder);
            Assert.IsTrue(wiiUBuilder.Console.ControlType== ConsoleParts.ControlType.Wii_U);
        }
    }
}
