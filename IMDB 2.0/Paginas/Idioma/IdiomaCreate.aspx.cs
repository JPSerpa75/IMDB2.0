using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Idioma
{
    public partial class IdiomaCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            txtError.Visible = false;
            String descricao = txtDescricao.Text.Trim();
            if(descricao != null && descricao.Length > 0)
            {
                int? retorno = 0;

                DataSetImdb2TableAdapters.idiomaTableAdapter ta = new DataSetImdb2TableAdapters.idiomaTableAdapter();
                ta.InsertIdioma(descricao, ref retorno);

                if (retorno == 1)
                {
                    txtError.Visible = true;
                    txtError.InnerText = "Esse idioma já foi cadastrado";
                    return;
                }

                Response.Redirect("~/Paginas/Idioma/IdiomaList.aspx");
    
            }
        }
    }
}