using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JBS.UI.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Atleta()
        {
            return View();
        }

        public ActionResult DetalheDoAtleta(Guid id)
        {
            return View();
        }
    }
}