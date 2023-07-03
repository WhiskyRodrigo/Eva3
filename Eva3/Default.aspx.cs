using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eva3
{
    public partial class Default : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidoresDALObjeto();
        private ITipoMedidorDAL tipoMedidorDAL = new TipoMedidorDALObjeto();

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            if (!validateData()) return;
            string serialNumber = this.serialNumberTxt.Text.Trim();  
            string type = this.typeList.SelectedValue;

            Medidor medidor = new Medidor()
            {
                SerialNumber = serialNumber,
                Type = type
            };

            medidorDAL.AgregarMedidores(medidor);

            Response.Redirect("VerMedidores.aspx");

        } 

        private bool validateData()
        {
            if (this.serialNumberTxt.Text == "")
            {
                this.mensajesLbl.Text = "Ingrese un número de Serie";
                return false;
            }
            if (typeList.SelectedValue.Equals("Seleccione una opcion"))
            {
                this.mensajesLbl.Text = "Indique tipo de medidor";
                return false;
            }
            return true;
        }
    }
}