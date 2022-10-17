using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPonto.Controllers
{
    public class PontoController : BaseController
    {
        public ActionResult Index()
        {
            var userLogado = "";

            if (Session["nomeUsuarioLogado"] != null)
            {
                userLogado = Session["nomeUsuarioLogado"].ToString(); ;
            }

            if (!String.IsNullOrEmpty(userLogado))
            {
                ViewBag.UserLogado = userLogado;

                return View();
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
        }
    }
}