using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENT01
{
    public class ClsPersona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Foto { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IDDepartamento { get; set; }

        public ClsPersona()
        {
        }
            public ClsPersona(string nombre, string apellidos, string telefono, string direccion, string foto, DateTime fechaNacimiento, int idDepartamento)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Telefono = telefono;
            Direccion = direccion;
            Foto = foto;
            FechaNacimiento = fechaNacimiento;
            IDDepartamento = idDepartamento;
        }

    }
}
