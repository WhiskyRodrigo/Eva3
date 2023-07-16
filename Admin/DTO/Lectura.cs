using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Admin.DTO
{
    public class Lectura
    {
        private DateTime fecha;
        private string consumo;
        private string codigo;


        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Consumo { get => consumo; set => consumo = value; }
        public string Codigo { get => codigo; set => codigo = value; }
    }
}
