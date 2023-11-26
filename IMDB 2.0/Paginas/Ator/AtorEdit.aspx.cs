﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Ator
{
    public partial class AtorEdit : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                DataSetImdb2TableAdapters.atorTableAdapter ta = new DataSetImdb2TableAdapters.atorTableAdapter();
                //load_fields(ta.GetFilmeById(id));
            }

        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {

            txtError.Visible = false;
            String nome = txtNome.Text;
            String sobrenome = txtSobrenome.Text;

            try
            {
                DataSetImdb2TableAdapters.atorTableAdapter ta = new DataSetImdb2TableAdapters.atorTableAdapter();
                //ta.UpdateAtor(nome, sobrenome, id);

                Response.Redirect("~/Paginas/Ator/AtorList.aspx");
            }
            catch (Exception ex)

            {
                ExibirErro("Ocorreu um erro ao salvar o ator. Detalhes: " + ex.Message);
            }

        }

        private void load_fields(DataSetImdb2.atorDataTable dt)
        {

            if (dt.Rows.Count > 0)
            {

                // txtNome.Text = dt[0].nome;
                // txtSobrenome.Text = dt[0].sobrenome;

            }

        }

        private void ExibirErro(string mensagem)
        {
            txtError.Visible = true;
            txtError.InnerText = mensagem;
        }
    }
}