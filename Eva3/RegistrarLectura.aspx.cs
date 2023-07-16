using Admin;
using Admin.DAL;
using Admin.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eva3
{
    public partial class RegistrarLectura : System.Web.UI.Page
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
            List<Lectura> lecturas = lecturasDAL.ObtenerLectura();
            this.grillaLectura.DataSource = lecturas;
            this.grillaLectura.DataBind();
        }
        protected void grillaLectura_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "elimina")
            {
                //al crear el boton, este elimina la lectura

                string boleta = Convert.ToString(e.CommandArgument);
                lecturasDAL.Eliminar(boleta);
                cargagrilla();
            }
        }
    }
}
 
    }
}