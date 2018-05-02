using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestBllEF;
using TestEntities;

namespace TestMVC.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult PersonsList()
        {
            Bll bll = new Bll();
            return Json(bll.GetAllPersonsProc(), JsonRequestBehavior.AllowGet);
        }

        public JsonResult PersonsByStatus(PersonView p)
        {
            //if (ModelState.IsValid)
            //{
                Bll bll = new Bll();
                return Json(bll.GetPersonByStatusProc(p), JsonRequestBehavior.AllowGet);
            //}
        }
    }
}