using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio.Services;
using Negocio.Entity;

namespace InterClass.Controllers
{
    public class PacoteController : Controller
    {
        // GET: Pacote
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Opcoes(Pacotes pac)
        {
            string id = Request.QueryString["id"];
            ViewBag.valor = id;
            if(id == "4")
            {
                var metodosusuario = new List();
                var todospacotes = metodosusuario.ListarPacotes(pac);
                var testeee = todospacotes[0].Idpac;
                ViewBag.dublin = testeee;
                return View();
            }
            return View();
        }
    }
}