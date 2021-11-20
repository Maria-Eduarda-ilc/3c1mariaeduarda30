using _3c1mariaeduarda30.code.dal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3c1mariaeduarda30.code.bll.loginbll
{
    class loginbll
    {
        acesso_banco_de_dados conexao = new acesso_banco_de_dados();
        string tabela = "tbl_Login";
        private object update;

        public bool RealizarLogin(loginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarGerenciamento(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public string RetornarSenha(loginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.Email}'";
            DataTable dt = conexao.ExecutarGerenciamento(sql);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["senha"].ToString();
            else
                return "false";
        }
    }
}
