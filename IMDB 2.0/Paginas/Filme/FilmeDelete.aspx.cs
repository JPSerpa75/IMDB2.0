using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Filme
{
    public partial class FilmeDelete : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                DataSetImdb2TableAdapters.filmeTableAdapter ta = new DataSetImdb2TableAdapters.filmeTableAdapter();
                DataSetImdb2.filmeDataTable dt = ta.GetFilmeById(id);
                mensagem.InnerText = "Deseja realmente excluir o filme " + dt[0].titulo + "?";
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

            txtError.Visible = false;

            try
            {
                int? retorno = 0;
                DataSetImdb2TableAdapters.filmeTableAdapter ta = new DataSetImdb2TableAdapters.filmeTableAdapter();
                ta.DeleteFilme(id, ref retorno);

                if (retorno == 1)
                {
                    ExibirErro("Esse Filme não pode ser excluído pois está atrelado a alguma atuação!");
                    return;
                }

                Response.Redirect("~/Paginas/Filme/FilmeList.aspx");

            }
            catch (Exception ex)
            {

                ExibirErro("Ocorreu um erro ao deletar o filme. Detalhes: " + ex.Message);
            }


        }


        private void ExibirErro(string mensagem)
        {
            txtError.Visible = true;
            txtError.InnerText = mensagem;
        }
    }
}