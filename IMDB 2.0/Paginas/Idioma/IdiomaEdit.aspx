<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IdiomaEdit.aspx.cs" Inherits="IMDB_2._0.Paginas.Idioma.IdiomaEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-center">
        <h1>Editar idiomas</h1>
        <p class="lead">Aqui você pode editar os idiomas</p>
    </div>

    <div>
        <form>
            <div class="form-group w-100">
                <label for="txtDescricao">Descrição</label>
                <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control w-100" MaxLength="255" placeHolder="Inglês"></asp:TextBox>
            </div>
            <div class="content-end">
                <a runat="server" class="btn btn-primary" href="~/Paginas/Idioma/IdiomaList.aspx">Voltar para lista de idiomas</a>
                <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-success" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
        </form>
    </div>

    <p>
        <div id="txtError" class="alert alert-danger" role="alert" runat="server" visible="false"></div>
    </p>

</asp:Content>
