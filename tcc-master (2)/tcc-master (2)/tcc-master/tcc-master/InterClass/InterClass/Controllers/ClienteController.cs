using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio.Entity;
using Negocio.Services;
namespace InterClass.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            return View();
        }
    
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(UsuarioCad usuariocad)
        {
            if (ModelState.IsValid)
            {
                var metodosUsuario = new Cadastrar();
                metodosUsuario.Insert(usuariocad);
                return RedirectToAction("Index", "Home");
            }
            return View(usuariocad);
        }
    }
}