using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JBS.UI.Controllers
{
    public class ErrorPageController : Controller
    {
        // GET: ErrorPage
        public ActionResult ErrorMessage(Exception exception)
        {
            ViewBag.ErrorDescription = exception.Message;
            return View(exception);
        }

        public ActionResult Http404(Exception exception)
        {
            Response.StatusCode = 404;
            Response.ContentType = "text/html";
            ViewBag.ErrorDescription = "Página não encontrada";
            return View(exception);
        }

        public ActionResult Http500(Exception exception)
        {
            Response.StatusCode = 500;
            Response.ContentType = "text/html";
            ViewBag.ErrorDescription = "Erro interno";
            return View(exception);
        }
    }
}