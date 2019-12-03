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
            if ((Session["usuarioLogado"] == null) || (Session["senhaLogado"] == null))

            {

                return RedirectToAction("semacesso", "Home");

            }
            else
            {
                ViewBag.teste = Session["tipoLogado"];


                string identlocal = Request.QueryString["idpasspar"];
                string valorlocal = Request.QueryString["preco"];
                var metodosusuario = new List();
                if (valorlocal != null)
                {
                    var todospacotes = metodosusuario.ListarPacotesById(identlocal);
                    ViewBag.valortrab = valorlocal;
                    return View(todospacotes);
                }
                else
                {
                    var todospacotes = metodosusuario.ListarPacotesById(identlocal);
                    return View(todospacotes);
                }
            }
            
        }
        [HttpPost]
        public ActionResult Index2(string id, string trab ,Seguros seguros)
        { 
            var metodousuario = new List();
            if (trab == null) { 
                var todosseguros = metodousuario.ListarSeguros(seguros);
                ViewBag.idpacote = id;
                return View(todosseguros);
            }else{
                var todosseguros = metodousuario.ListarSeguros(seguros);
                ViewBag.idpacote = id;
                ViewBag.vlrtrab = trab;
                return View(todosseguros);
            }
        }
        [HttpPost]
        public ActionResult Index3(string id, string idseg, string vlr)
        {
            ViewBag.idpac = id;
            ViewBag.idseg = idseg;
             ViewBag.vlrtrab = vlr;

            return View();
        }

        //public ActionResult Gerar()
        //{
        //    return View();
        //}
        [HttpPost]
        public ActionResult Gerar(int id, int idseg, string dt)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Teste(string dt, string idpacote, int idseguro, string vlrtrab)
        {
            ViewBag.data = dt;
            if (vlrtrab == null)
            {
                var metodosusuario = new Cadastrar();
                var lista = new List();
                var testa = false;
                metodosusuario.InserirAgendas(idpacote, dt,testa);
                var valorpac = lista.ListarPacotesById(idpacote);
                var valorseg = lista.ListarVlrSeguroById(idseguro);
                var valores = valorpac[0].Valor;
                var valoresseg = valorseg[0].Valorseg;
                decimal total = valores + valoresseg;
                ViewBag.total = total;
                return View();
            }
            else
            {
                var metodosusuario = new Cadastrar();
                var lista = new List();
                var testa = true;
                int convert = Convert.ToInt32(vlrtrab);
                metodosusuario.InserirAgendas(idpacote, dt, testa);
                var valorseg = lista.ListarVlrSeguroById(idseguro);
                var valoresseg = valorseg[0].Valorseg;
                decimal total = convert + valoresseg;
                ViewBag.total = total;
                return View();
            }
        }
        public ActionResult Valor()
        {
            return View();
        }
    }
}