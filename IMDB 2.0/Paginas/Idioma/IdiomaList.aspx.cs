using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IMDB_2._0.Paginas.Idioma
{
    public partial class IdiomaList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Load_idioma();
        }

        protected void GVIdioma_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if(e.Row.RowType == DataControlRowType.DataRow)
            {
                int idIdioma = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "idIdioma"));
                string editar = "<a class='link' href = 'IdiomaEdit?id=" + idIdioma + "'><i class='bi bi-pencil'></i></a>";
                string deletar = "<a class='link' href = 'IdiomaDelete?id=" + idIdioma + "'><i class='bi bi-trash'></i></a>";
                e.Row.Cells[1].Text = editar + " " + deletar;

            }

        }

        protected void Load_idioma()
        {
            DataSetImdb2TableAdapters.idiomaTableAdapter tableAdapter = new DataSetImdb2TableAdapters.idiomaTableAdapter();
            DataSetImdb2.idiomaDataTable dt = tableAdapter.GetAllIdioma();
            GV_Idioma.DataSource = dt;
            GV_Idioma.DataBind();
                
        }
    }
}