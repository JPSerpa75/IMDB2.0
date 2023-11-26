<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AtorEdit.aspx.cs" Inherits="IMDB_2._0.Paginas.Ator.AtorEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        <h1>Editar atores</h1>
        <p class="lead">Aqui você pode editar as informações dos atores</p>
    </div>

    <div>
        <div class="form-group">
            <label for="txtNome">Nome</label>
            <asp:TextBox ID="txtNome" runat="server" CssClass="form-control w-100" MaxLength="255"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtSobrenome">Sobrenome</label>
            <asp:TextBox ID="txtSobrenome" runat="server" CssClass="form-control w-100" MaxLength="255"></asp:TextBox>
        </div>
    </div>

    <div class="content-end">
        <a runat="server" class="btn btn-primary" href="~/Paginas/Ator/AtorList.aspx">Voltar para lista de atores</a>
        <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-success" Text="Salvar" OnClick="btnSalvar_Click" />
    </div>

    <div id="txtError" class="alert alert-danger" role="alert" runat="server" visible="false"></div>
</asp:Content>
