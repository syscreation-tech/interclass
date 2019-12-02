using Negocio.Entity;
using Negocio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InterClass.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Cadastrar()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Cadastrar(Usuario usuario)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var metodosUsuario = new Cadastrar();
        //        metodosUsuario.Insert(usuario);
        //        return RedirectToAction("Index", "Home");
        //    }
        //    return View(usuario);
        //}

        public ActionResult Produtos()
        {
            return View();
        }

        public ActionResult ProdutosComCompraOnline()
        {
            if ((Session["usuarioLogado"] == null) || (Session["senhaLogado"] == null))
            {
                return RedirectToAction("semAcesso", "Home");
            }

            return View();
        }

        public ActionResult Pacotes(Pacotes pac)
        {
            var metodosusuario = new List();
            var todosPacotes = metodosusuario.ListarPacotes(pac);
            return View(todosPacotes);
        }

        public ActionResult Seguros(Seguros seg)
        {
            var metodosusuario = new List();
            var todosSeguros = metodosusuario.ListarSeguros(seg);
            return View(todosSeguros);
        }

        public ActionResult Planos()
        {
            return View();
        }

        public ActionResult InformacoesDoCartao()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InformacoesDoCartao(Produto produto)
        {
            if (ModelState.IsValid)
            {
                var meotodosUsuario = new Cadastrar();
                meotodosUsuario.InsereDadosCartao(produto);
                return RedirectToAction("Index", "Usuario");
            }
            return View(produto);
        }
    }
}