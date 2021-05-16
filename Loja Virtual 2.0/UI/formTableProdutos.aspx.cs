using LojaVirtual.BLL;
using LojaVirtual.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LojaVirtual.UI
{
    public partial class formTableProdutos : System.Web.UI.Page
    {
        ProdutoBLL produtoBLL = new ProdutoBLL();
        ProdutoDTO produtoDTO = new ProdutoDTO();


        protected void Page_Load(object sender, EventArgs e)
        {
    
        }

        public void ExibirGridView() {

            string pesquisa = "p.nome like '%" + TextBoxPesq.Text + "%'" ;
            GridProdutos.DataSource = produtoBLL.Pesquisar(pesquisa);
            GridProdutos.DataBind();
        }
        protected void BtnNovo_Click(object sender, EventArgs e)
        {
            Response.Redirect("formCadProduto.aspx");
        }

        protected void BtnPesquisar_Click(object sender, EventArgs e)
        {
            ExibirGridView();
        }
        protected void GridProdutos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            produtoDTO.Id = Convert.ToInt32(GridProdutos.DataKeys[e.RowIndex].Value.ToString());
            produtoBLL.Excluir(produtoDTO);
        }

        protected void GridProdutos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridProdutos.PageIndex = e.NewEditIndex;
            ExibirGridView();
        }

        protected void GridProdutos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridProdutos.EditIndex = -1;
            ExibirGridView();

        }

        protected void GridProdutos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            produtoDTO.Id = Convert.ToInt32(GridProdutos.DataKeys[e.RowIndex].Value.ToString());
            produtoDTO.Nome = e.NewValues[1].ToString();
            produtoDTO.Descricao = e.NewValues[2].ToString();
            produtoDTO.Valor = Convert.ToDouble(e.NewValues[3].ToString());

            //alterar para pegar o id de acordo com o nome do fornecedor
            produtoDTO.FornecedorID = 1;
            produtoDTO.CategoriaID = 1;

            FileUpload fotoProduto = (FileUpload)GridProdutos.Rows[e.RowIndex].FindControl("fileupFoto");

            if (fotoProduto.HasFile) {
                String localImagem = Server.MapPath("~/IMG/Produtos/" + fotoProduto.FileName);
                fotoProduto.SaveAs(localImagem);
                produtoDTO.Foto = fotoProduto.FileName.ToString();
            }

            produtoDTO.QuantidadeEstoque = Convert.ToInt32(e.NewValues[6].ToString());

            produtoBLL.Alterar(produtoDTO);
            GridProdutos.EditIndex = -1;
            ExibirGridView();
        }
    }
}