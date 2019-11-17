using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Gabriel_TCM.Controllers
{
    public class OrcamentoController : Controller
    {
        // GET: Orcamento
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gerar()
        {
            return View();
        }

        public ActionResult Valor()
        {
            return View();
        }
    }
}