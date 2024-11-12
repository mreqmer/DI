using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ENT03
{
    public class Persona 
    {

        #region Atributos
        private string nombre;
        #endregion

        #region Get/Set
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        #endregion

        #region Constuctores
        public Persona()
        {
            nombre = "Marta";
        }

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion


    }
}
