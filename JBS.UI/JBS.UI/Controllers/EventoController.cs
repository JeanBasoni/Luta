using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JBS.UI.Controllers
{
    public class EventoController : Controller
    {
        // GET: Evento
        public ActionResult Evento()
        {
            ViewBag.Message = "Eventos";

            return View();
        }

        public ActionResult DetalheDoEvento(Guid id)
        {
            return View();
        }

        public ActionResult Checagem(Guid id)
        {
            var nomeEvento = "";

            ViewBag.Titulo = "Checagem " + nomeEvento; 
            return View();
        }

        
    }
}