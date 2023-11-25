﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Filme
{
    public partial class FilmeEdit : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                DataSetImdb2TableAdapters.filmeTableAdapter ta = new DataSetImdb2TableAdapters.filmeTableAdapter();
                load_idiomas();
                load_fields(ta.GetFilmeById(id));
            }

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            txtError.Visible = false;
            String titulo = txtTitulo.Text.Trim();
            String descricao = txtDescricao.Text.Trim();
            String categoria = txtCategoria.Text.Trim();
            String classificaoIndicativa = txtClassIndicativa.Text.Trim();
            int? idIdioma = Convert.ToInt32(ddlIdioma.SelectedValue);
            String anoLancamentotxt = txtAnoLancamento.Text.Trim();


            int? anoLancamento = null;
            if (anoLancamentotxt != null && anoLancamentotxt.Length > 0)
            {
                anoLancamento = Convert.ToInt32(anoLancamentotxt);
            }


            if (idIdioma == 0)
            {
                ExibirErro("É necessário selecionar algum idioma");
                return;
            }

            if (string.IsNullOrEmpty(titulo) || string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(categoria))
            {
                ExibirErro("Os campos Título, Descrição e categoria devem ser preenchidos!");
                return;

            }

            try
            {
                DataSetImdb2TableAdapters.filmeTableAdapter ta = new DataSetImdb2TableAdapters.filmeTableAdapter();
                ta.UpdateFilme(titulo, descricao, categoria, classificaoIndicativa, anoLancamento, idIdioma, id);

                Response.Redirect("~/Paginas/Filme/FilmeList.aspx");
            }
            catch (Exception ex)

            {
                ExibirErro("Ocorreu um erro ao salvar o filme. Detalhes: " + ex.Message);
            }

        }


        private void load_idiomas()
        {
            DataSetImdb2TableAdapters.idiomaTableAdapter ta = new DataSetImdb2TableAdapters.idiomaTableAdapter();
            DataSetImdb2.idiomaDataTable dt = ta.GetAllIdioma();

            ddlIdioma.DataSource = dt;
            ddlIdioma.DataTextField = "descricao";
            ddlIdioma.DataValueField = "idIdioma";
            ddlIdioma.DataBind();

            ddlIdioma.Items.Insert(0, new ListItem("Selecione um idioma", "0"));
        }

        private void load_fields(DataSetImdb2.filmeDataTable dt)
        {

            if (dt.Rows.Count > 0)
            {

                txtTitulo.Text = dt[0].titulo;
                txtDescricao.Text = dt[0].descricao;
                txtCategoria.Text = dt[0].categoria;
                txtClassIndicativa.Text = dt[0].classificacaoIndicativa;
                ddlIdioma.SelectedValue = dt[0].idIdioma.ToString();
                txtAnoLancamento.Text = dt[0].anoLancamento.ToString();

            }

        }

        private void ExibirErro(string mensagem)
        {
            txtError.Visible = true;
            txtError.InnerText = mensagem;
        }


    }
}