using Loja_Virtual_2._0.DAL;
using Loja_Virtual_2._0.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.EnterpriseServices;
using System.Data;

namespace Loja_Virtual_2._0.BLL
{
    public class CategoriaBLL
    {
        private string query;
        private Conexao conexao = new Conexao();
        public void Criar(CategoriaDTO objetoDTO)
        {
            query = $"insert into categoria(nome, descricao) values ('{objetoDTO.Nome}','{objetoDTO.Descricao}');";
            conexao.commands(query);
        }
        
        public void Alterar (CategoriaDTO objetoDTO)
        {
            query = $"update  categoria set nome = '{objetoDTO.Nome}', descricao = '{objetoDTO.Descricao}' where id = '{objetoDTO.Id}';";
            conexao.commands(query);
        }

        public void Delete(CategoriaDTO objetoDTO)
        {
            query = $"delete from categoria where id = '{objetoDTO.Id}';";
            conexao.commands(query);
        }

        public DataTable Selecionar()
        {
            query = "select * from categoria;";
         return conexao.tabelasConsult(query);
        }
    }
}