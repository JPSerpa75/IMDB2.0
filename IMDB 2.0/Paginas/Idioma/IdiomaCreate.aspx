<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IdiomaCreate.aspx.cs" Inherits="IMDB_2._0.Paginas.Idioma.IdiomaCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        <h1>Cadastrar novos idiomas</h1>
        <p class="lead">Aqui você pode inserir novos idiomas </p>
    </div>

    <div>
        <div class="form-group">
            <label for="txtDescricao">Descrição</label>
            <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control col-12" MaxLength="255" placeHolder="Inglês"></asp:TextBox>
        </div>
        <div class="content-end">
            <a runat="server" class="btn btn-primary" href="~/Paginas/Idioma/IdiomaList.aspx">Voltar para lista de idiomas</a>
            <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-success" Text="Salvar" OnClick="btnSalvar_Click" />
        </div>
    </div>

    <div id="txtError" class="alert alert-danger" role="alert" runat="server" visible="false"></div>

</asp:Content>
