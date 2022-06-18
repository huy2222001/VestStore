using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VestStore.Controllers
{
    public class VestStoreController : Controller
    {
        // GET: VestStore
        public ActionResult Index()
        {
            return View();
        }
    }
}