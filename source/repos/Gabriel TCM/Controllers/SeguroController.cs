using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gabriel_TCM.Controllers
{
    public class SeguroController : Controller
    {
        // GET: Seguro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }
    }
}