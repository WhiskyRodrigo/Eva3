using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DAL
{
    public interface ILecturasDAL
    {
        //Obtenemos las lectura
        List<Lectura> ObtenerLectura();  

        //Agregar lectura
        void AgregarLectura(Lectura lectura);  

    } 
}

