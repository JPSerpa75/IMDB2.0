using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Idioma
{
    public partial class IdiomaEdit : System.Web.UI.Page
    {

        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                DataSetImdb2TableAdapters.idiomaTableAdapter ta = new DataSetImdb2TableAdapters.idiomaTableAdapter();
                DataSetImdb2.idiomaDataTable dt = ta.GetIdiomaById(id);
                txtDescricao.Text = dt[0].descricao;
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            txtError.Visible = false;
            String descricao = txtDescricao.Text.Trim();
            if (descricao != null && descricao.Length > 0)
            {
                int? retorno = 0;

                DataSetImdb2TableAdapters.idiomaTableAdapter ta = new DataSetImdb2TableAdapters.idiomaTableAdapter();
                ta.UpdateIdioma(descricao, id, ref retorno);

                if (retorno == 1)
                {
                    txtError.Visible = true;
                    txtError.InnerText = "Já existe um idioma com essa descrição!";
                    return;
                }

                Response.Redirect("~/Paginas/Idioma/IdiomaList.aspx");

            }
        }

    }
}