<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="IMDB_2._0._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron text-center">
        <h1>Bem-vindo ao IMDB 2.0</h1>
        <p class="lead">Aqui você pode cadastrar seus filmes e atores preferidos</p>
    </div>

    <div class="row">
        <div class="col-md-3">
            <p>
                <a runat="server" class="btn btn-lg btn-primary" href="~/Paginas/Ator/AtorList.aspx">Atores</a>
            </p>
        </div>
        <div class="col-md-3">
            <p>
                <a runat="server" class="btn btn-lg btn-primary" href="~/Paginas/Atuacao/AtuacaoList.aspx">Atuações</a>
            </p>
        </div>
        <div class="col-md-3">
            <p>
                <a runat="server" class="btn btn-lg btn-primary" href="~/Paginas/Filme/FilmeList.aspx">Filmes</a>
            </p>
        </div>
        <div class="col-md-3">
            <p>
                <a runat="server" class="btn btn-lg btn-primary" href="~/Paginas/Idioma/IdiomaList.aspx">Idiomas</a>
            </p>
        </div>
    </div>

</asp:Content>
