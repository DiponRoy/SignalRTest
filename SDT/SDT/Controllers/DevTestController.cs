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
            var db = new SdtDbDropCreateDatabaseIfModelChanges();
            db.LoadDb();
            return View();
        }
    }
}
