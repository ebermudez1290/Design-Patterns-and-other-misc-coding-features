using Core.Classes.BuilderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Design_Patters.Controllers
{
    public class DesignPatternController : Controller
    {
        // GET: DesignPattern
        public ActionResult Index()
        {
            return View();
        }
        // GET: DesignPattern
        public ActionResult BuildPs4()
        {
            Manufacturer manufacturer = new Manufacturer();
            IConsoleBuilder ps4Builder = new Ps4Builder();
            manufacturer.Construct(ps4Builder);
            return Json(ps4Builder, JsonRequestBehavior.AllowGet);
        }
        // GET: DesignPattern
        public ActionResult BuildWiiU()
        {
            Manufacturer manufacturer = new Manufacturer();
            IConsoleBuilder wiiUBuilder = new WiiUBuilder();
            manufacturer.Construct(wiiUBuilder);
            return Json(wiiUBuilder, JsonRequestBehavior.AllowGet);
        }
    }
}