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
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDALObjeto();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarMedidor();
                cargarHora();
            } 
        }

        //Datos del medidor.
        private void cargarMedidor()
        {
            List<Medidor> medidor = medidorDAL.ObtenerMedidor();
            this.medidorList.DataSource = medidor;
            this.medidorList.DataTextField = "serialNumber";
            this.medidorList.DataBind();
        } 
        protected void guardarLectura_Click(object sender, EventArgs e)
        {
            if (!validateData()) return;

            Medidor medidor = medidorDAL.ObtenerMedidores().Find(m => m.SerialNumber == this.medidoresList.SelectedItem.Value);

            Lectura lectura = new Lectura()
            {

            };

            medidor.Lectura = lectura;

            Response.Redirect("VerMedidores.aspx");
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
        private bool validateData()
        {
            // Validar medidor
            if (medidorList.SelectedValue.Equals("Seleccione un medidor"))
            {
                this.mensajesLbl.Text = "Seleccione un medidor";
                return false;
            }
            this.mensajesLbl.Text = "";

            double consumo;
            // Validar consumo
            if (!double.TryParse(this.MConsumoTxt.Text, out consumo))
            {
                this.MConsumo.Text = "Ingrese un consumo Válido";
                return false;
            }
            this.MConsumoTxt.Text = "";


            return true;
        }
    }
}