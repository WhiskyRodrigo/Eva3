using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Admin.DTO;

namespace Admin.DAL
{
    public interface IMedidorDAL
    {
        // obtiene y devuelve la lista de medidores.
        List<Medidor> ObtenerMedidor();   

        //agrega medidor.
        void AgregarMedidor(Medidor medidor);   

    }
}
