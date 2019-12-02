using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterClass.Controllers
{
    public class PlanoController : Controller
    {
        // GET: Plano
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Opcoes()
        {
            return View();
        }
    }
}