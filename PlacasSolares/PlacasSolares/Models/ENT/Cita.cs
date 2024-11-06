using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Models.ENT
{
    public class Cita
    {
        #region Atributos
        private string id;
        private string nombre;
        private string fecha;
        private string hora;
        #endregion

        #region Constructores
        public Cita(string id, string nombre, string fecha, string hora)
        {
            this.id = id;
            this.nombre = nombre;
            this.fecha = fecha;
            this.hora = hora;
        }
        #endregion

        #region Getters Setter
        public string Id
        {
            get { return id; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }
        #endregion
    }
}
