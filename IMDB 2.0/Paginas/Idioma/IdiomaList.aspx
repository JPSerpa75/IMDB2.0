<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IdiomaList.aspx.cs" Inherits="IMDB_2._0.Paginas.Idioma.IdiomaList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron text-center">
        <h1>Idiomas</h1>
        <p class="lead">Aqui você pode gerenciar seus idiomas </p>
    </div>

    <div class="content">
        <div class="col-3">
            <p>
                <a runat="server" class="btn btn-lg btn-primary" href="~/Paginas/Idioma/IdiomaCreate.aspx">Cadastrar novo idioma</a>
            </p>
        </div>
    </div>



    <asp:GridView ID="GV_Idioma" runat="server" OnRowDataBound="GVIdioma_RowDataBound" AutoGenerateColumns="False" CssClass="text-center table table-striped b-none table-hover" GridLines="None" ShowHeaderWhenEmpty="True">
        <Columns>
            <asp:BoundField HeaderStyle-CssClass="text-center"  DataField="descricao" HeaderText="Descri&#231;&#227;o" SortExpression="descricao"></asp:BoundField>
            <asp:BoundField HeaderStyle-CssClass="text-center" DataField="link" HeaderText="A&#231;&#245;es" SortExpression="link" HtmlEncode="False"></asp:BoundField>
            <asp:BoundField DataField="idIdioma" Visible="false"></asp:BoundField>
        </Columns>
    </asp:GridView>

</asp:Content>
