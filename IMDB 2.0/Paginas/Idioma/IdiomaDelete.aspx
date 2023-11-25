<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IdiomaDelete.aspx.cs" Inherits="IMDB_2._0.Paginas.Idioma.IdiomaDelete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row mt content">
        <div class="col-sm-6 col-md-4 col-xl-6 text-center">
            <div class="thumbnail">
                <img class="img" src="../../imgs/info.png" alt="Alerta" />
                <div class="caption">
                    <h3>Excluir Idioma</h3>
                    <p id="mensagem" runat="server">Deseja realmente excluir o idioma?</p>
                    <p class="content">
                        <asp:Button ID="btnExcluir" runat="server" CssClass="btn btn-danger" Text="Excluir" OnClick="btnExcluir_Click" />
                        <a href="~/Paginas/Idioma/IdiomaList.aspx" runat="server" class="btn btn-primary">Cancelar</a>
                    </p>
                </div>
            </div>
        </div>
    </div>

    <div id="txtError" class="alert alert-danger" role="alert" runat="server" visible="false"></div>

</asp:Content>
