using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DAL
{
    public interface ILecturaDAL
    {
        //Obtenemos las lecturas
        List<Lectura> ObtenerLectura();  

        //Agregar lecturas
        void AgregarLectura(Lectura lectura);  

    } 
}

