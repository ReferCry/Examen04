using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos;
using Entidad;


namespace Negocio
{
    public class NRegion
    {
        DRegion dRegion = new DRegion();

        public void Insertar(Region region)
        {

            dRegion.Insertar(region);
        }

        public List<Region> Listar(string Nombre)
        {
            List<Region> result = new List<Region>();

            result = dRegion.Listar(Nombre);
            return result;
        }
    }
}
