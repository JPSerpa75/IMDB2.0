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
            if (string.IsNullOrEmpty(descricao))
            {
                ExibirErro("O campo Descrição deve ser preenchidos!");
                return;
            }


            try
            {
                int? retorno = 0;
                DataSetImdb2TableAdapters.idiomaTableAdapter ta = new DataSetImdb2TableAdapters.idiomaTableAdapter();
                ta.InsertIdioma(descricao, ref retorno);

                if (retorno == 1)
                {
                    ExibirErro("Já existe um idioma com essa descrição!");
                    return;
                }

                Response.Redirect("~/Paginas/Idioma/IdiomaList.aspx");
            }
            catch (Exception ex)
            {
                ExibirErro("Ocorreu um erro ao salvar o idioma. Detalhes: " + ex.Message);
            }


        }

        private void ExibirErro(string mensagem)
        {
            txtError.Visible = true;
            txtError.InnerText = mensagem;
        }

    }
}