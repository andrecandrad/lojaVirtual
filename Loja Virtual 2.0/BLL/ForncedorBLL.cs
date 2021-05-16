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
    public class ForncedorBLL
    {


        private string query;
        private conect conexao = new conect();
        public void Criar(FornecedorDTO objetoDTO)
        {
            query = $"insert into fornecedores(nome, cnpj, email, telefone, nomeRepresentante, telefoneRepresentante) values ('{objetoDTO.Nome}','{objetoDTO.Cnpj}','{objetoDTO.Email}','{objetoDTO.Telefone}','{objetoDTO.NomeResponsavel}','{objetoDTO.TelefoneResponsavel}');";
            conexao.commands(query);
        }

        public void Alterar(FornecedorDTO objetoDTO)
        {
            query = $"update  fornecedores set nome = '{objetoDTO.Nome}', cnpj = '{objetoDTO.Cnpj}',email = '{objetoDTO.Email}', telefone = '{objetoDTO.Telefone}', nomeRepresentante = '{objetoDTO.NomeResponsavel}',telefoneRepresentante = '{objetoDTO.TelefoneResponsavel}' where id = '{objetoDTO.Id}';";
            conexao.commands(query);
        }

        public void Delete(FornecedorDTO objetoDTO)
        {
            query = $"delete from fornecedores where id = '{objetoDTO.Id}';";
            conexao.commands(query);
        }

        public DataTable select()
        {
            query = "select * from fornecedores;";
            return conexao.tabelasConsult(query);
        }
    }
}