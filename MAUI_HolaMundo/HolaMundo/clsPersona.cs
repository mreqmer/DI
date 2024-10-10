using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class clsPersona
    {
        #region: Atributos

        public String Nombre { get; set; }
        public String Apellido { get; set; }

        #endregion

        #region: Constructor

        public clsPersona()
        {
        }

        public clsPersona(String nombre, String apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }
        #endregion



    }
}
