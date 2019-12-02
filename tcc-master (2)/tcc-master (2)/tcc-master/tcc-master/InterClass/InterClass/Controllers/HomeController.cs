using Negocio.Entity;
using Negocio.Services;
using System.Web.Mvc;
using System.Web.Security;

namespace InterClass.Controllers
{
    public class HomeController : Controller
    {
        LoginService ac = new LoginService();
        public ActionResult Login(Login verLogin)
        {

            ac.TestarUsuario(verLogin);
            ViewBag.mensagem = "Digite o usuário e senha";

            if (verLogin.Usuario != null && verLogin.Senha != null && verLogin.Tipo != null)
            {
                FormsAuthentication.SetAuthCookie(verLogin.Usuario, false);
                Session["usuarioLogado"] = verLogin.Usuario.ToString();
                Session["senhaLogado"] = verLogin.Senha.ToString();
                Session["tipoLogado"] = verLogin.Tipo;

                LoginService.mail = Session["usuarioLogado"].ToString();
                if (verLogin.Tipo == "g")
                {
                    return RedirectToAction("Area51", "Home");
                }
                else if (verLogin.Tipo == "s")
                {
                    return RedirectToAction("Gerente", "Home");
                }
                else
                {
                    return RedirectToAction("Index", "Usuario");
                }
            }
            return View();

        }
        Login log = new Login();


        public ActionResult Index()
        {
            Usuario p = new Usuario();
            return View(p);
        }

    }
}