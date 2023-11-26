using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Ator
{
    public partial class AtorList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_ator();
        }

        protected void GVAtor_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int idAtor = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "idAtor"));
                string editar = "<a class='link' href = 'AtorEdit?id=" + idAtor + "'><i class='bi bi-pencil'></i></a>";
                string deletar = "<a class='link' href = 'AtorDelete?id=" + idAtor + "'><i class='bi bi-trash'></i></a>";
                e.Row.Cells[2].Text = editar + " " + deletar;

            }

        }

        protected void Load_ator()
        {
            DataSetImdb2TableAdapters.atorTableAdapter tableAdapter = new DataSetImdb2TableAdapters.atorTableAdapter();
            DataSetImdb2.atorDataTable dt = tableAdapter.GetAllAtor();
            GV_Ator.DataSource = dt;
            GV_Ator.DataBind();

        }
    }
}