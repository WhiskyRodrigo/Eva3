using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.DAL
{
    public interface IMedidorDAL
    {
        List<Medidor> Obtener();
        void Agregar(Medidor cliente);

        //esta eliminara en la BD, por lo cual recibe el RUT
        void Eliminar(string rut);
    }
}
