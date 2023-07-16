using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DAL
{
    public class LecturasDALObjeto : ILecturasDAL
    {
        //lista de lecturas
        private static List<Lectura> lecturas = new List<Lectura>(); 
        
        // Agregar lectura a la lista
        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);  
        }
        //leer lecturas
        public void Eliminar(string codigo)
        {
            Lectura eliminando = lecturas.Find(c => c.Codigo == codigo);
            lecturas.Remove(eliminando);
        }

        public List<Lectura> ObtenerLectura()
        {
            return lecturas;    
        } 

    }
}
