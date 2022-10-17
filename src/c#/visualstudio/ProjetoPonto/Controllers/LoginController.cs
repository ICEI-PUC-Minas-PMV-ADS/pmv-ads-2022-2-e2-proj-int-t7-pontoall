using ProjetoPonto.Models;
using System.Web.Mvc;

namespace ProjetoPonto.Controllers
{
    public class LoginController : BaseController
    {
        public ActionResult Index()
        {
            // Redireciona pra pagina de ponto caso estiver logado
            if (Session["nomeUsuarioLogado"] != null)
            {
                return RedirectToAction("Index", "Ponto");
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(Usuario u)
        {
            // Redireciona pra pagina de ponto caso estiver logado
            if (Session["nomeUsuarioLogado"] != null)
            {
                return RedirectToAction("Index", "Ponto");
            }

            if (ModelState.IsValid) //verifica se é válido
            {
                var conn = ObterCommand();
                // tabela tem pelo menos 4 campos... 
                // id, login, senha, nome
                conn.CommandText = "select id_colaborador, nome, admin from colaborador where email = '" + u.Email + "' and senha = '" + u.Senha + "'";
                var retorno = conn.ExecuteReader();

                while (retorno.Read())
                {
                    Session["nomeUsuarioLogado"] = retorno["nome"].ToString();
                    Session["id_colaborador"] = retorno["id_colaborador"].ToString();
                    Session["admin"] = retorno["admin"].ToString();

                    // action / controller
                    return RedirectToAction("Index", "Ponto");
                }

                ViewBag.Message = "Usuário e/ou senha inválidos";
            }

            return View(u);
        }

        public ActionResult Logout()
        {
            Session["nomeUsuarioLogado"] = null;
            return RedirectToAction("Index", "Login");
        }
    }
}