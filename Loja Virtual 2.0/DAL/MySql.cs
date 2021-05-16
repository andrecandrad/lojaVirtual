using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Loja_Virtual_2._0.DAL
{
    public class MySql
    {
        private static string server = "localhost";
        private static string database = "lojavirtual";
        private static string user = "root";
        private static string password = "";

        //string de conexão
        private string stringConexao = "SERVIDOR" + server + "; DATABSE=" + database + "; UID" + user + "; PWD=" + password;
        public MySqlConnection conectar;
        private void conexao()
        {
            try
            {
                conectar = new MySqlConnection(conexao);
                conectar.Open();
            } catch (Exception exception)
            {
                throw new Exception("Erro!");
            }
        }

        public DataTable tabelasConsult (string sql)
        {
            conexao();

            try
            {
                MySqlDataAdapter consult = new MySqlDataAdapter(sql, conectar);
                DataTable result = new DataTable();
                consultas.Fill(result);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro!");
            }
            finally
            {
                conectar.Close();
            }
        }

        public void commands (string sql)
        {
            conexao();

            try
            {
                MySqlCommand command = new MySqlCommand(sql, conectar);
                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception("Erro!");
            }

            finally
            {
                conectar.Close();
            }
        }

        }
    }
}