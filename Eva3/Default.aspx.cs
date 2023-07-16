using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Admin.DTO;
using Admin.DAL;

namespace Eva3
{
    public partial class Default : System.Web.UI.Page
    {
        private IMedidorDAL medidoresDAL = new MedidorDALObjeto();
        private ILecturasDAL lecturaDAL = new LecturasDALObjeto();
        protected void agregarBtn_Click(object sender, EventArgs e)
        {

            string boleta = this.boletatxt.Text.Trim();

            Medidor medidor = new Medidor()
            {
                Boleta = Convert.ToInt32(boleta)
            };


            medidoresDAL.AgregarMedidor(medidor);

            this.mensajesLbl.Text = "A ingresado un nuevo medidor.";
            Response.Redirect("VisualizarMedidor.aspx");
        }
    }
}