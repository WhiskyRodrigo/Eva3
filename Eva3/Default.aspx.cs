using Eva3;
using Admin.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Eva3
{
    public partial class Default : System.Web.UI.Page
    {
        private IMedidorDAL clienteDAL = new MedidorDALObjetos();
        private ILecturaDAL bebidaDAL = new LecturaDALObjetos();

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            //1. Obtener los datos del fomulario
            string medidor = this.medidortxt.Text.Trim();
            string modelo = this.modelotxt.Text.Trim();

            int nivel = Convert.ToInt32(this.nivelRbl.SelectedItem.Value);
            //2.1 Construir el obejeto Bebida

            List<Bebida> bebidas = bebidaDAL.ObtenerBebidas();
            Bebida bebida = bebidas.Find(b => b.Codigo == this.bebidaDbl.SelectedItem.Value);

            //2.2  Construir el objeto de tipo cliente

            Cliente cliente = new Cliente()
            {
                Nombre = nombre,
                Rut = rut,
                Nivel = nivel,
                Bebidafavorita = bebida
            };
            //3. Llamar al DAL
            clienteDAL.Agregar(cliente);
            //4. Mostrar mensaje de exito
            this.mensajesLbl.Text = "Cliente Guardado correctamente";
            Response.Redirect("VerClientes.aspx");
        }
    }
}