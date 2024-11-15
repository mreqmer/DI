using Ejercicio01.Models.ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Models.BL
{
    internal class ListadosBl
    {
        /// <summary>
        /// Obtiene de la dal el listado de personas
        /// </summary>
        /// <returns>listado de ClsPersona</returns>
        public static ObservableCollection<ClsPersona> ObtenerPersonasBl()
        {
            ObservableCollection<ClsPersona> listadoBl = DAL.ListadosDal.ObtenerPersonasDal();
            return listadoBl;
        }

        /// <summary>
        /// Obtiene de la bl una persona por su id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="personas"></param>
        /// <returns>Objeto ClsPersona</returns>
        public static ClsPersona BuscarPersonaPorIdBl(int id, ObservableCollection<ClsPersona> personas)
        {
            ClsPersona personaEncontrada = DAL.ListadosDal.BuscarPersonaPorId(id, personas);
            return personaEncontrada;
        }

        /// <summary>
        /// Obtiene de la dal una persona por su id y la borra
        /// </summary>
        /// <param name="id"></param>
        /// <param name="personas"></param>
        public static void BorrarPersonaIdBl(int id, ObservableCollection<ClsPersona> personas)
        {
            DAL.ListadosDal.BorrarPersonaPorId(id, personas);
        }

    }
}
