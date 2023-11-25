using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Filme
{
    public partial class FilmeView : System.Web.UI.Page
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
                txtAnoLancamento.Text = dt[0].anoLancamento.ToString();
                ddlIdioma.SelectedValue = dt[0].idIdioma.ToString();


            }

        }
    }
}