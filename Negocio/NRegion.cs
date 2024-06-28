using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Negocio
{
    public class NRegion
    {
        DRegion datos = new DRegion();
        public List<Region> Listar(string Nombre)
        {
            List<Region> result = new List<Region>();

            result = datos.Listar(Nombre);
            return result;
        }
    }
}
