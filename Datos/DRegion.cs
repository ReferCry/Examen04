using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class DRegion
    {
        public void Insertar(Region region)
        {
            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("USP_InsertRegion", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RegionName", SqlDbType.VarChar, 50);
                parameter.Value = region.RegionName;
                command.Parameters.Add(parameter);

                /*
                SqlParameter parameter2 = new SqlParameter("@Enabled", SqlDbType.Bit);
                parameter2.Value = Activo;
                command.Parameters.Add(parameter2);
                */

                command.ExecuteNonQuery();

            }
        }
        public List<Region> Listar(string Nombre)
        {
            List<Region> regions = new List<Region>();

            using (var connection = new SqlConnection(Conexion.cadena))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SP_ReadRegions", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                //Enviar los parámetros
                /*
                SqlParameter parameter = new SqlParameter("RegionName", SqlDbType.VarChar, 50);
                parameter.Value = Nombre;
                cmd.Parameters.Add(parameter);
                */

                
                SqlDataReader reader = cmd.ExecuteReader();

                //Recorrer el data reader
                while (reader.Read())
                {

                    int RegionId = reader["RegionId"] != DBNull.Value ? Convert.ToInt32(reader["RegionId"]) : 0;
                    string RegionName = reader["RegionName"] != DBNull.Value ? Convert.ToString(reader["RegionName"]) : "";

                    regions.Add(new Region { RegionId = RegionId, RegionName = RegionName });


                }
                reader.Close();
            }
            return regions;

        }
    }
}
