using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio.Services;
using Negocio.Entity;

namespace InterClass.Controllers
{
    public class OrcamentoController : Controller
    {
        // GET: Orcamento
        public ActionResult Index(Pacotes pacote)
        {
            string identlocal = Request.QueryString["idpasspar"];
            var metodosusuario = new List();
            var todospacotes = metodosusuario.ListarPacotesById(identlocal);

            return View(todospacotes);
        }
        [HttpPost]
        public ActionResult Index2(string teste, string id, Seguros seguros)
        {
            var metodousuario = new List();
            var todosseguros = metodousuario.ListarSeguros(seguros);
            ViewBag.idpacote = id;
            return View(teste,todosseguros);
        }
        [HttpPost]
        public ActionResult Index3(string id, string idseg)
        {
            ViewBag.idpac = id;
            ViewBag.idseg = idseg;
            return View();
        }
        [HttpPost]
        public ActionResult Gerar(int id,int idseg,string dt)
        {
            var metodosusuario = new Cadastrar();
            metodosusuario.InserirAgendas(id, dt);
            ViewBag.idseg = idseg;
            return View();
        }

        public ActionResult Valor()
        {
            return View();
        }
    }
}