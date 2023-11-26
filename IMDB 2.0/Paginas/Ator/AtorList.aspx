<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AtorList.aspx.cs" Inherits="IMDB_2._0.Paginas.Ator.AtorList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        <h1>Atores</h1>
        <p class="lead">Aqui você pode gerenciar seus atores </p>
    </div>

    <div class="content">
        <div class="col-3">
            <p>
                <a runat="server" class="btn btn-lg btn-primary" href="~/Paginas/Ator/AtorCreate.aspx">Cadastrar novo Ator</a>
            </p>
        </div>
    </div>
    <asp:GridView ID="GV_Ator" runat="server" OnRowDataBound="GVAtor_RowDataBound" AutoGenerateColumns="False" CssClass="text-center table table-striped b-none table-hover" GridLines="None" ShowHeaderWhenEmpty="True" ShowHeader="True">
        <Columns>
            <asp:BoundField HeaderStyle-CssClass="text-center" DataField="nome" HeaderText="Nome" SortExpression="nome"></asp:BoundField>
            <asp:BoundField HeaderStyle-CssClass="text-center" DataField="sobrenome" HeaderText="Sobrenome" SortExpression="sobrenome"></asp:BoundField>
            <asp:BoundField HeaderStyle-CssClass="text-center" DataField="link" HeaderText="A&#231;&#245;es" SortExpression="link" HtmlEncode="False"></asp:BoundField>
            <asp:BoundField DataField="idFilme" Visible="false"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
