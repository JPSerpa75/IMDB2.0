<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FilmeList.aspx.cs" Inherits="IMDB_2._0.Paginas.Filme.FilmeList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        <h1>Filmes</h1>
        <p class="lead">Aqui você pode gerenciar seus filmes </p>
    </div>

    <div class="content">
        <div class="col-3">
            <p>
                <a runat="server" class="btn btn-lg btn-primary" href="~/Paginas/Filme/FilmeCreate.aspx">Cadastrar novo filme</a>
            </p>
        </div>
    </div>



    <asp:GridView ID="GV_Filme" runat="server" OnRowDataBound="GVFilme_RowDataBound" AutoGenerateColumns="False" CssClass="text-center table table-striped b-none table-hover" GridLines="None" ShowHeaderWhenEmpty="True" ShowHeader="True">
        <Columns>
            <asp:BoundField HeaderStyle-CssClass="text-center" DataField="titulo" HeaderText="Título" SortExpression="titulo"></asp:BoundField>
            <asp:BoundField HeaderStyle-CssClass="text-center" DataField="anoLancamento" HeaderText="Ano lançamento" SortExpression="anoLancamento"></asp:BoundField>
            <asp:BoundField HeaderStyle-CssClass="text-center" DataField="idioma" HeaderText="Idioma" SortExpression="idioma"></asp:BoundField>
            <asp:BoundField HeaderStyle-CssClass="text-center" DataField="categoria" HeaderText="Categoria" SortExpression="categoria"></asp:BoundField>
            <asp:BoundField HeaderStyle-CssClass="text-center" DataField="link" HeaderText="A&#231;&#245;es" SortExpression="link" HtmlEncode="False"></asp:BoundField>
            <asp:BoundField DataField="idFilme" Visible="false"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
