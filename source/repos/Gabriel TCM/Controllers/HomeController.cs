using Regra_de_Negocios.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Regra_de_Negocios.Services;
using System.Web.Security;

namespace Gabriel_TCM.Controllers
{
    public class HomeController : Controller
    { 
        LoginService ac = new LoginService();
        public ActionResult Index()
        {
            USUARIO p = new USUARIO();
            return View(p);
        }
        public ActionResult Ferias()
        {
            return View();
        }
        public ActionResult Canada()
        {
            return View();
        }
        public ActionResult EUA()
        {
            return View();
        }
        public ActionResult Irlanda()
        {
            return View();
        }
        public ActionResult Login(Login verLogin) 
        {

            ac.TestarUsuario(verLogin);
            ViewBag.mensagem = "Digite o usuário e senha";

            if (verLogin.usuario != null && verLogin.Senha != null && verLogin.tipo != null)
            {
                FormsAuthentication.SetAuthCookie(verLogin.usuario, false);
                Session["usuarioLogado"] = verLogin.usuario.ToString();
                Session["senhaLogado"] = verLogin.Senha.ToString();
                Session["tipoLogado"] = verLogin.tipo;

                LoginService.mail = Session["usuarioLogado"].ToString();
                if (verLogin.tipo == "1")
                {
                    return RedirectToAction("Area51", "Home");
                }
                else if (verLogin.tipo == "2")
                {
                    return RedirectToAction("Gerente", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Usuario");
                }
            }

            else
            {
                return View();

            }

        }
        Login log = new Login();

    }
}