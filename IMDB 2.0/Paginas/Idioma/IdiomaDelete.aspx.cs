using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Idioma
{
    public partial class IdiomaDelete : System.Web.UI.Page
    {

        int id;
        protected void Page_Load(object sender, EventArgs e)
        {

            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                DataSetImdb2TableAdapters.idiomaTableAdapter ta = new DataSetImdb2TableAdapters.idiomaTableAdapter();
                DataSetImdb2.idiomaDataTable dt = ta.GetIdiomaById(id);
                mensagem.InnerText = "Deseja realmente excluir o idioma " + dt.Rows[0][1] + "?";
            }

        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            txtError.Visible = false;

            try
            {
                int? retorno = 0;
                DataSetImdb2TableAdapters.idiomaTableAdapter ta = new DataSetImdb2TableAdapters.idiomaTableAdapter();
                ta.DeleteIdioma(id, ref retorno);

                if (retorno == 1)
                {
                    ExibirErro("Esse idioma não pode ser excluído pois está em uso");
                    return;
                }

                Response.Redirect("~/Paginas/Idioma/IdiomaList.aspx");

            }
            catch (Exception ex)
            {

                ExibirErro("Ocorreu um erro ao deletar o idioma. Detalhes: " + ex.Message);
            }


        }



        private void ExibirErro(string mensagem)
        {
            txtError.Visible = true;
            txtError.InnerText = mensagem;
        }

    }
}