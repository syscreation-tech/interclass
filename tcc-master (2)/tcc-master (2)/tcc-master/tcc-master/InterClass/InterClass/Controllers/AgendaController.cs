using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterClass.Controllers
{
    public class AgendaController : Controller
    {
        // GET: Agenda
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Selecionar()
        {
            return View();
        }

        public ActionResult Realizado()
        {
            return View();
        }
        public ActionResult Agendamentos()
        {
            return View();
        }

        public ActionResult Confirmar()
        {
            return View();
        }
    }
}