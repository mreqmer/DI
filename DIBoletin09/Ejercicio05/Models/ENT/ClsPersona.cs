using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05.Models.ENT
{
    public class ClsPersona
    {
        #region Atributos
        private int id;
        private string nombre;
        private string apellidos;
        private string fechaNac;
        private string foto;
        private string direccion;
        private string telefono;
        #endregion
        #region Get/Set
        public int Id
        {
            get { return id; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string NombreCompleto
        {
            get { return $"{nombre} {apellidos}"; }
        }
        #endregion
        #region Constructores
        public ClsPersona()
        {

        }

        public ClsPersona(int id, string nombre, string apellidos, string fechaNac, string foto, string direccion, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fechaNac = fechaNac;
            this.foto = foto;
            this.direccion = direccion;
            this.telefono = telefono;
        }
        #endregion
    }
}
