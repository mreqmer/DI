using Ejercicio05UI.Models.ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ejercicio05UI.Models.DAL
{   
    class ListadoPersonas
    {
        public static ObservableCollection<ClsPersona> ListarPersonas()
        {
            ObservableCollection<ClsPersona> personas = new ObservableCollection<ClsPersona>
            {
                new ClsPersona { Nombre = "John", Descripcion = "A friendly neighbor", Foto = "def.png" },
                new ClsPersona { Nombre = "Sarah", Descripcion = "Loves painting", Foto = "def.png" },
                new ClsPersona { Nombre = "Michael", Descripcion = "Tech enthusiast", Foto = "def.png" },
                new ClsPersona { Nombre = "Emma", Descripcion = "Avid reader", Foto = "def.png" },
                new ClsPersona { Nombre = "David", Descripcion = "Enjoys hiking", Foto = "def.png" },
                new ClsPersona { Nombre = "Olivia", Descripcion = "Coffee lover", Foto = "def.png" },
                new ClsPersona { Nombre = "James", Descripcion = "Football fan", Foto = "def.png" },
                new ClsPersona { Nombre = "Sophia", Descripcion = "Animal lover", Foto = "def.png" },
                new ClsPersona { Nombre = "Daniel", Descripcion = "Musician", Foto = "def.png" },
                new ClsPersona { Nombre = "Isabella", Descripcion = "Fashion enthusiast", Foto = "def.png" }
            };


            return personas;
        }
    }
}
