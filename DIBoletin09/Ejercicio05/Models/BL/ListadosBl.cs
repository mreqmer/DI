using Ejercicio05.Models.ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05.Models.BL
{
    internal class ListadosBl
    {

        public static ObservableCollection<ClsPersona> ObtenerPersonasBl()
        {
            ObservableCollection<ClsPersona> listadoBl = DAL.ListadosDal.ObtenerPersonasDal();
            return listadoBl;
        }

        public static ClsPersona BuscarPersonaPorIdBl(int id, ObservableCollection<ClsPersona> personas)
        {
            ClsPersona personaEncontrada = DAL.ListadosDal.BuscarPersonaPorId(id, personas);
            return personaEncontrada;
        }

    }
}
