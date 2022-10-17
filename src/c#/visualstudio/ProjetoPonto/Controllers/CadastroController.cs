using ProjetoPonto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPonto.Controllers
{
    public class CadastroController : Controller
    {
        public ActionResult Index()
        {
            // Redireciona pra pagina de ponto caso estiver logado
            if (Session["admin"] == null || !Session["admin"].Equals("Y"))
            {
                return RedirectToAction("Index", "Home");
            }

            // Pendente listar usuarios cadastrados e colocar no viewbag pra gerar a listagem no frontend

            return View();
        }

        public ActionResult Adicionar()
        {
            // Redireciona pra pagina de ponto caso estiver logado
            if (Session["admin"] == null || !Session["admin"].Equals("Y"))
            {
                return RedirectToAction("Index", "Home");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Adicionar(Cadastro cad)
        {
            // Redireciona pra pagina de ponto caso estiver logado
            if (Session["admin"] == null || !Session["admin"].Equals("Y"))
            {
                return RedirectToAction("Index", "Home");
            }

            // Pendente salvar os dados, fazer igualzinho faz a tela de login....

            return View();
        }
    }
}