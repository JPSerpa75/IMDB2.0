using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Ator
{
    public partial class AtorDelete : System.Web.UI.Page
    {
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                DataSetImdb2TableAdapters.atorTableAdapter ta = new DataSetImdb2TableAdapters.atorTableAdapter();
                DataSetImdb2.atorDataTable dt = ta.GetAtorById(id);
                mensagem.InnerText = "Deseja realmente excluir o Ator " + dt[0].nome + " " + dt[0].sobrenome + "?";
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {

            txtError.Visible = false;

            try
            {
                int? retorno = 0;
                DataSetImdb2TableAdapters.atorTableAdapter ta = new DataSetImdb2TableAdapters.atorTableAdapter();
                ta.DeleteAtor(id, ref retorno);

                if (retorno == 1)
                {
                    ExibirErro("Esse ator não pode ser excluído pois está atrelado a alguma atuação!");
                    return;
                }

                Response.Redirect("~/Paginas/Ator/AtorList.aspx");

            }
            catch (Exception ex)
            {

                ExibirErro("Ocorreu um erro ao deletar o ator. Detalhes: " + ex.Message);
            }


        }


        private void ExibirErro(string mensagem)
        {
            txtError.Visible = true;
            txtError.InnerText = mensagem;
        }
    }
}