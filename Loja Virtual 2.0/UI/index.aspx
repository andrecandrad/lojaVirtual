<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LojaVirtual.UI.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Loja Virtual</title>
    <link rel="stylesheet" href="..//assets/css/bootstrap.min.css" />

</head> 
<body>
    <form id="form1" runat="server">
        <nav>
        <div>
                <ul>
                    <li>
                        <asp:HyperLink ID="HyperLinkInicial" NavigateUrl="~/UI/index.aspx" Text="Inicial" runat="server"></asp:HyperLink>
                    </li>
                    <li>
                    <asp:HyperLink ID="HyperLinkProdutos" NavigateUrl="~/UI/formTableProdutos.aspx" Text="Produtos" runat="server"></asp:HyperLink>
                    </li>
                     <li>
                    <asp:HyperLink ID="HyperLinkFornecedores" NavigateUrl="~/UI/formTableFornecedores.aspx" Text="Fornecedores" runat="server"></asp:HyperLink>
                    </li>
                    <li>
                    <asp:HyperLink ID="HyperLinkLogin" NavigateUrl="~/UI/formLogin.aspx" Text="Login" runat="server"></asp:HyperLink>
                    </li>
                </ul>
        </div>
        </nav>
       <main>
           <asp:Image ImageUrl="~/IMG/game.jpg" AlternateText="Imagem não carregada." runat="server"/>
       </main>
        
        <footer>

            Copyright &copy; Desenvolvido por Rafaela. Todos os direitos reservados.
 
       </footer>
       
    </form>
</body>
</html>
