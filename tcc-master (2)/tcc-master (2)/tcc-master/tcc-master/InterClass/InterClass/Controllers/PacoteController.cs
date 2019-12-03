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
            var metodosusuario = new List();
            var todospacotes = metodosusuario.ListarPacotes(pac);
            if (id == "4")
            {
                var testeee = todospacotes[0].Idpac;
                var valor = todospacotes[0].Valor;
                ViewBag.dublin = testeee;
                ViewBag.valorviagem = valor;
                return View();
            }else if (id == "3")
            {
                var testeee = todospacotes[1].Idpac;
                ViewBag.sidney = testeee;
                return View();
            }
            else if(id == "2")
            {
                var testeee = todospacotes[2].Idpac;
                ViewBag.toronto = testeee;
                return View();
            }
            else if (id == "1")
            {
                var testeee = todospacotes[3].Idpac;
                ViewBag.nw = testeee;
                return View();
            }
            return View();
        }
    }
}