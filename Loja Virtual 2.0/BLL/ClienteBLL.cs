using Loja_Virtual_2._0.DAL;
using Loja_Virtual_2._0.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Loja_Virtual_2._0.BLL
{
    public class ClienteBLL
    {
        private MySqlDAL conect = new MySqlDAL();

        public Boolean Autenticar(string email, string senha) {
            string sql = string.Format($@"SELECT * FROM cliente WHERE email= '{email}' and senha='{senha}';");
            DataTable dt = conect.tabelasConsult(sql);
            if (dt.Rows.Count == 1) {
                return true;
            }
            else {
                return false;
            }
        }

        public string RecuperarSenha(string email) {
            string sql = string.Format($@"SELECT * FROM cliente WHERE email= '{email}';");
            DataTable dt = conect.tabelasConsult(sql);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["senha"].ToString();
            }
            else {
                return "Usuário não existe!";
            }
        }
    }
}