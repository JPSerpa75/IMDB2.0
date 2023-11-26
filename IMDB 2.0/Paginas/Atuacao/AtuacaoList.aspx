<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AtuacaoList.aspx.cs" Inherits="IMDB_2._0.Paginas.Atuacao.AtuacaoList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron text-center">
        <h1>Atuações</h1>
    </div>

    <asp:GridView ID="GV_Atuacoes" runat="server" AutoGenerateColumns="False" CssClass="text-center table table-striped b-none table-hover" GridLines="None" ShowHeaderWhenEmpty="True" ShowHeader="True">
        <Columns>
            <asp:BoundField HeaderStyle-CssClass="text-center" DataField="nomeAtor" HeaderText="Ator" SortExpression="nomeAtor"></asp:BoundField>
            <asp:BoundField HeaderStyle-CssClass="text-center" DataField="nomeFilme" HeaderText="Filme" SortExpression="nomeFilme"></asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
