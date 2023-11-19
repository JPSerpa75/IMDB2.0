using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Filme
{
    public partial class FilmeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_filme();
        }

        protected void GVFilme_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int idFilme = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "idFilme"));
                string editar = "<a class='link' href = 'FilmeEdit?id=" + idFilme + "'><span class='glyphicon glyphicon-pencil' aria-hidden='true'></span></a>";
                string deletar = "<a class='link' href = 'FilmeDelete?id=" + idFilme + "'><span class='glyphicon glyphicon-trash' aria-hidden='true'></span></a>";
                e.Row.Cells[4].Text = editar + " " + deletar;

            }

        }

        protected void Load_filme()
        {
            DataSetImdb2TableAdapters.filmeTableAdapter tableAdapter = new DataSetImdb2TableAdapters.filmeTableAdapter();
            DataSetImdb2.filmeDataTable dt = tableAdapter.GetAllFilme();
            GV_Filme.DataSource = dt;
            GV_Filme.DataBind();

        }
    }
}