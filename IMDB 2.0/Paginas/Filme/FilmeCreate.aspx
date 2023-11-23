<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FilmeCreate.aspx.cs" Inherits="IMDB_2._0.Paginas.Filme.FilmeCreate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        <h1>Cadastrar novos filmes</h1>
        <p class="lead">Aqui você pode inserir novos filmes</p>
    </div>

    <div class="form-row">
        <div class="form-group col-md-6">
            <label for="inputEmail4">Email</label>
            <input type="email" class="form-control" id="inputEmail4">
        </div>
        <div class="form-group col-md-6">
            <label for="inputPassword4">Password</label>
            <input type="password" class="form-control" id="inputPassword4">
        </div>
    </div>




    <div class="form-group">
        <label for="txtTitulo">Título</label>
        <asp:TextBox ID="txtTitulo" runat="server" CssClass="form-control w-100" MaxLength="255"></asp:TextBox>
    </div>

    <div class="form-group">
        <label for="txtDescricao">Descrição</label>
        <asp:TextBox ID="txtDescricao" runat="server" CssClass="form-control w-100" MaxLength="255"></asp:TextBox>
    </div>

    <div class="form-row">
        <div class="form-group col-md-6">
            <label for="txtCategoria">Categoria</label>
            <asp:TextBox ID="txtCategoria" runat="server" CssClass="form-control" MaxLength="255"></asp:TextBox>
        </div>
        <div class="form-group col-md-6">
            <label for="txtDescricao">Idioma</label>
            <asp:DropDownList ID="ddlIdioma" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
    </div>




    <div class="form-group col-6">
        <label for="txtClassIndicativa">Classificação Indicativa</label>
        <asp:TextBox ID="txtClassIndicativa" runat="server" CssClass="form-control w-100" TextMode="Number" min="1"></asp:TextBox>
    </div>

    <div class="form-group col-6">
        <label for="txtAnoLancamento">Ano de Lançamento</label>
        <asp:TextBox ID="txtAnoLancamento" runat="server" CssClass="form-control w-100" TextMode="Number" min="1"></asp:TextBox>
    </div>










    <div class="content-end">
        <a runat="server" class="btn btn-primary" href="~/Paginas/Filme/FilmeList.aspx">Voltar para lista de filmes</a>
        <asp:Button ID="btnSalvar" runat="server" CssClass="btn btn-success" Text="Salvar" OnClick="btnSalvar_Click" />
    </div>

    <div id="txtError" class="alert alert-danger" role="alert" runat="server" visible="false"></div>


</asp:Content>
