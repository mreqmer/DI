using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENT01;
using Microsoft.Data.SqlClient;

namespace DAL01
{
    public class ListadosDal
    {
        /// <summary>
        /// Conecta con la base de datos para devolver un listado de personas
        /// </summary>
        /// <returns></returns>
        public static List<ClsPersona> ObtieneListadoPersonasDal()
        {
            SqlConnection miConexion = new SqlConnection();
            List<ClsPersona> listadoPersonas = new List<ClsPersona>();
            SqlCommand miComando = new SqlCommand();
            SqlDataReader miLector;
            ClsPersona oPersona;
            miConexion.ConnectionString = ClsConexion.CadenaConexion();

            try
            {
                miConexion.Open();
                miComando.CommandText = "SELECT * FROM personas";
                miComando.Connection = miConexion;
                miLector = miComando.ExecuteReader();

                if (miLector.HasRows)
                {

                    while (miLector.Read())
                    {
                        oPersona = new ClsPersona();
                        oPersona.Id = (int)miLector["ID"];
                        oPersona.Nombre = (string)miLector["Nombre"];
                        oPersona.Apellidos = (string)miLector["Apellidos"];
                        oPersona.Telefono = (string)miLector["Telefono"];
                        oPersona.Direccion = (string)miLector["Direccion"];
                        oPersona.Foto = (string)miLector["Foto"];
                        oPersona.FechaNacimiento = (DateTime)miLector["FechaNAcimiento"];
                        oPersona.IDDepartamento = (int)miLector["IDDepartamento"];

                        listadoPersonas.Add(oPersona);
                    }
                    miLector.Close();
                    miConexion.Close();
                }
            }
            catch (SqlException exSql)
            { 
                throw exSql;

            }
            return listadoPersonas;

        }
    }
}
