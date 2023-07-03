using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    public class Medidor
    {
        private int boleta;
        private int numCliente;
        private int numMedidor;
        public int Boleta { get => boleta; set => boleta = value; }
        public int NumCliente { get => numCliente; set => numCliente = value; }
        public int NumMedidor { get => numMedidor; set => numMedidor = value; }
    }
}
