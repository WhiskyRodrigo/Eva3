using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DAL
{
    public class LecturaDALObjeto : ILecturaDAL
    {
        //lista de lecturas
        private static List<Lectura> lecturaN = new List<Lectura>(); 
        
        // Agregar lectura a la lista
        public void AgregarLectura(Lectura lectura)
        {
            lecturaN.Add(lectura);  
        }
        //leer lecturas
        public List<Lectura> ObtenerLectura()
        {
            return lecturaN;    
        } 

    }
}
