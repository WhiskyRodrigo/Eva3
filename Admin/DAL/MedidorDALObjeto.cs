﻿using Admin.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Admin.DAL
{
    public class MedidorDALObjeto : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();

        public void AgregarMedidor(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public List<Medidor> ObtenerMedidor()
        {
            return medidores;
        }
    }
}

