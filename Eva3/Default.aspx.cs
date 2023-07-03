using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Admin;

namespace Eva3
{
    public partial class Default : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjeto();
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

            medidorDAL.AgregarMedidor(medidor);

            Response.Redirect("VerMedidor.aspx");

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