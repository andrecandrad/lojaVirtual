using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LojaVirtual.DTO
{
    public class ProdutoDTO
    {
        private int id, quantidadeEstoque, categoriaID, fornecedorID;
        private string nome, descricao, foto;
        private double valor;

        public int Id { get => id; set => id = value; }
        public int FornecedorID { get => fornecedorID; set => fornecedorID = value; }
        public double Valor { get => valor; set => valor = value; }
        public string Foto { get => foto; set => foto = value; }
   
        public string Nome
        {
            set {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else {

                    throw new Exception("Campo nome é obrigatório!");
                }
            
            }
            get { return this.nome; }
        
        }

        public string Descricao
        {
            set
            {
                if (value != string.Empty)
                {
                    this.descricao = value;
                }
                else
                {

                    throw new Exception("Campo descrição é obrigatório!");
                }

            }
            get { return this.descricao; }

        }

        public int QuantidadeEstoque
        {
            set
            {
                if (value != 0)
                {
                    this.quantidadeEstoque = value;
                }
                else
                {

                    throw new Exception("Campo quantidade de estoque é obrigatório!");
                }

            }
            get { return this.quantidadeEstoque; }

        }
        public int CategoriaID
        {
            set
            {
                if (value != 0)
                {
                    this.categoriaID = value;
                }
                else
                {

                    throw new Exception("Campo categoria é obrigatório!");
                }

            }
            get { return this.categoriaID; }

        }

     
    }
}