using Admin;
using Admin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eva3
{
    public partial class VerLecturas : System.Web.UI.Page
    {
        private ILecturasDAL lecturasDAL = new LecturasDALObjeto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargagrilla();
            }
        }

        protected void cargagrilla()
        {
            List<Lectura> lectura = lecturaDAL.ObtenerLecturas();
            this.grillaLectura.DataSource = lectura;
            this.grillaLectura.DataBind();
        }

        protected void grillaMedidor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "agregar")
            {

                string nombre = Convert.ToString(e.CommandArgument);
                lecturaDAL.Agregar(nombre);
                cargagrilla();
            }
        }
    }
}