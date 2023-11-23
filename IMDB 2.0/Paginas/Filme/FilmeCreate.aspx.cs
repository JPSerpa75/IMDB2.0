using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Filme
{
    public partial class FilmeCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_idiomas();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            txtError.Visible = false;
            String titulo = txtTitulo.Text.Trim();
            String descricao = txtDescricao.Text.Trim();
            String categoria = txtDescricao.Text.Trim();
            int  anoLancamento = Convert.ToInt32(txtAnoLancamento.Text.Trim());
            String classificaoIndicativa = txtClassIndicativa.Text.Trim();
            int idIdioma = Convert.ToInt32(ddlIdioma.SelectedValue);

            if (idIdioma==0)
            {
                txtError.Visible = true;
                txtError.InnerText = "É necessário selecionar algum idioma";
                return;
            }

            if (titulo != null && titulo.Length > 0 && descricao != null && descricao.Length > 0 && categoria != null && categoria.Length > 0)
            {
                int? retorno = 0;

                DataSetImdb2TableAdapters.filmeTableAdapter ta = new DataSetImdb2TableAdapters.filmeTableAdapter();
                ta.(descricao, ref retorno);



                Response.Redirect("~/Paginas/Filme/FilmeList.aspx");

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

        private 

    }
}