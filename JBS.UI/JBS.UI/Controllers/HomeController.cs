using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JBS.UI.Controllers
{
    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sobre Nocaute COMBATE";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contatos";

            return View();
        }

        public ActionResult Evento()
        {
            ViewBag.Message = "Eventos";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Login";

            return View();
        }

        public ActionResult NovoUsuario()
        {
            ViewBag.Message = "Novo usuário";
            return View();
        }
    }
}