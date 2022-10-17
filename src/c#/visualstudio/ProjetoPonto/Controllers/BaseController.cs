using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPonto.Controllers
{
    public class BaseController : Controller
    {
        private MySqlConnection Conexao;

        /// <summary>
        /// Abre uma conexao com o banco de dados
        /// </summary>
        private void AbrirConexao()
        {
            if (Conexao == null || Conexao.State != ConnectionState.Open)
            {
                string strCon = @"server=127.0.0.1;user id=root;database=pontoalldb;SslMode=none";
                Conexao = new MySqlConnection(strCon);
                Conexao.Open();
            }
        }

        /// <summary>
        /// Retorna o comando com a conexão 
        /// </summary>
        /// <returns></returns>
        public MySqlCommand ObterCommand()
        {
            AbrirConexao();

            MySqlCommand comm = new MySqlCommand();
            comm.Connection = Conexao;
            comm.CommandType = CommandType.Text;

            return comm;
        }

        public void Dispose()
        {
            if (Conexao != null && Conexao.State == ConnectionState.Open)
            {
                Conexao.Close();
            }
        }
    }
}