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

        }

        protected void Load_atuacoes()
        {
            DataSetImdb2TableAdapters.atorTableAdapter tableAdapter = new DataSetImdb2TableAdapters.atorTableAdapter();
            DataSetImdb2.atorDataTable dt = tableAdapter.GetAllAtor();
            GV_Atuacoes.DataSource = dt;
            GV_Atuacoes.DataBind();

        }
    }
}