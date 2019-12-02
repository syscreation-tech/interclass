using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterClass.Controllers
{
    public class PagamentoController : Controller
    {
        // GET: Pagamento
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Debito()
        {
            return View();
        }

        public ActionResult Credito()
        {
            return View();
        }
    }
}