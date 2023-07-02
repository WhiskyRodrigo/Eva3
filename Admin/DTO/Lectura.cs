using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Admin
{
    public class Lectura
    {
        private DateTime fecha;
        private string consumo;

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Consumo { get => consumo; set => consumo = value; }
    }
}
