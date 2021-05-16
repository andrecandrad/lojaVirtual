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
    public partial class formCadProduto : System.Web.UI.Page
    {

        ProdutoDTO produtoDTO = new ProdutoDTO();
        ProdutoBLL produtoBLL = new ProdutoBLL();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Salvar_Click(object sender, EventArgs e)
        {
            try {
                produtoDTO.Nome = nome.Text;
                produtoDTO.Descricao = descricao.Text;
                produtoDTO.Valor = Convert.ToDouble(valor.Text);
                produtoDTO.CategoriaID = Convert.ToInt32(categoria.SelectedValue.ToString());
                produtoDTO.FornecedorID = Convert.ToInt32(fornecedor.SelectedValue.ToString());
                produtoDTO.QuantidadeEstoque = Convert.ToInt32(quantidade.Text);
                produtoDTO.Foto = imagem.FileName.ToString();
                produtoBLL.Inserir(produtoDTO);
                //Upload da imagem para o porjeto
                string localFoto = Server.MapPath("/IMG/Produtos/" +produtoDTO.Foto);
                imagem.SaveAs(localFoto);

                // alert
                string mensagem = "Produto inserido com sucesso!";
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), Guid.NewGuid().ToString(), "alert('" + mensagem + "')", true);
               
            }
            catch (Exception ex) {
                msgErro.Visible = true;
                msgErro.Text = ex.Message;
            }

        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            nome.Text = "";
            descricao.Text = "";
            categoria.SelectedIndex = -1;
            // completar
        }

    }
}