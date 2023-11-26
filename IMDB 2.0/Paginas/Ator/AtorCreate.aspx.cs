using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Ator
{
    public partial class AtorCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;

            if (string.IsNullOrEmpty(nome.Trim()) || string.IsNullOrEmpty(sobrenome.Trim()))
            {
                ExibirErro("Os campos Nome e Sobrenome devem ser preenchidos!");
                return;

            }

            try
            {
                DataSetImdb2TableAdapters.atorTableAdapter ta = new DataSetImdb2TableAdapters.atorTableAdapter();
                ta.InsertAtor(nome, sobrenome);
                Response.Redirect("AtorList.aspx");
            }
            catch (Exception ex)

            {
                ExibirErro("Ocorreu um erro ao salvar o filme. Detalhes: " + ex.Message);
            }
        }

        private void ExibirErro(string mensagem)
        {
            txtError.Visible = true;
            txtError.InnerText = mensagem;
        }
    }
}