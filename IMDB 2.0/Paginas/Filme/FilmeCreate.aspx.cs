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

    }
}