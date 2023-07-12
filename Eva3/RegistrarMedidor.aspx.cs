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
    public partial class VerMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjeto();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargagrilla();
            }
        }

        protected void cargagrilla()
        {
            List<Medidor> medidor = medidorDAL.ObtenerMedidor();
            this.grillaMedidor.DataSource = medidor;
            this.grillaMedidor.DataBind();
        }

        protected void grillaMedidor_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "agregar")
            {

                string nombre = Convert.ToString(e.CommandArgument);
                medidorDAL.Agregar(nombre);
                cargagrilla();
            }
        }
    }
}