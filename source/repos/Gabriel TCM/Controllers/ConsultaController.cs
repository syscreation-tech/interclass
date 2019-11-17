using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gabriel_TCM.Controllers
{
    public class ConsultaController : Controller
    {
        // GET: Consulta
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Fechamento()
        {
            return View();
        }
    }
}