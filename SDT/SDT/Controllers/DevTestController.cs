using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SDT.Db;

namespace SDT.Controllers
{
    public class DevTestController : Controller
    {
        //
        // GET: /DevTest/

        public ActionResult Index()
        {
            var db = new SdtDbCreateIfNotExistsContext();
            db.LoadDb();
            return View();
        }

        public ActionResult List()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Update(int id)
        {
            return View();
        }

    }
}
