using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Atuacao
{
    public partial class AtuacaoList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_atuacoes();
        }

        protected void Load_atuacoes()
        {
            DataSetImdb2TableAdapters.atuacoesTableAdapter tableAdapter = new DataSetImdb2TableAdapters.atuacoesTableAdapter();
            DataSetImdb2.atuacoesDataTable dt = tableAdapter.GetAllAtuacoes();
            GV_Atuacoes.DataSource = dt;
            GV_Atuacoes.DataBind();

        }
    }
}