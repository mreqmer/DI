using Ejercicio01.Models.ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01.Models.DAL
{
    internal class ListadosDal
    {
        /// <summary>
        /// Carga un ObservableCollection de personas
        /// </summary>
        /// <returns>ObservableCollection de ClsPersona</returns>
        public static ObservableCollection<ClsPersona> ObtenerPersonasDal()
        {

            ObservableCollection<ClsPersona> personas = new ObservableCollection<ClsPersona>();

            personas.Add(new ClsPersona(1, "Juan", "Pérez", "01/01/1990", "https://thispersondoesnotexist.com", "Calle Falsa 123", "555-1234"));
            personas.Add(new ClsPersona(2, "María", "López", "15/05/1985", "https://thispersondoesnotexist.com", "Avenida Siempre Viva 456", "555-5678"));
            personas.Add(new ClsPersona(3, "Carlos", "García", "20/03/1980", "https://thispersondoesnotexist.com", "Calle Real 789", "555-9876"));
            personas.Add(new ClsPersona(4, "Laura", "Martínez", "25/07/1992", "https://thispersondoesnotexist.com", "Calle Luna 101", "555-8765"));
            personas.Add(new ClsPersona(5, "José", "Sánchez", "30/11/1983", "https://thispersondoesnotexist.com", "Avenida Sol 202", "555-1357"));
            personas.Add(new ClsPersona(6, "Ana", "Fernández", "10/09/1995", "https://thispersondoesnotexist.com", "Calle Estrella 303", "555-2468"));
            personas.Add(new ClsPersona(7, "Miguel", "Rodríguez", "05/06/1988", "https://thispersondoesnotexist.com", "Calle Viento 404", "555-3698"));
            personas.Add(new ClsPersona(8, "Isabel", "González", "14/02/1987", "https://thispersondoesnotexist.com", "Calle Fuego 505", "555-7531"));
            personas.Add(new ClsPersona(9, "David", "Jiménez", "09/04/1991", "https://thispersondoesnotexist.com", "Avenida Agua 606", "555-6420"));
            personas.Add(new ClsPersona(10, "Elena", "Díaz", "12/08/1986", "https://thispersondoesnotexist.com", "Calle Tierra 707", "555-9812"));
            personas.Add(new ClsPersona(11, "Pedro", "Ruiz", "22/01/1984", "https://thispersondoesnotexist.com", "Avenida Cielo 808", "555-4321"));
            personas.Add(new ClsPersona(12, "Carmen", "Pérez", "28/11/1990", "https://thispersondoesnotexist.com", "Calle Nubes 909", "555-1843"));
            personas.Add(new ClsPersona(13, "Antonio", "Martín", "17/05/1982", "https://thispersondoesnotexist.com", "Calle Rocío 1010", "555-2569"));
            personas.Add(new ClsPersona(14, "Lucía", "Torres", "13/09/1994", "https://thispersondoesnotexist.com", "Avenida Estrella 1111", "555-4987"));
            personas.Add(new ClsPersona(15, "Rafael", "Hernández", "02/12/1989", "https://thispersondoesnotexist.com", "Calle Mar 1212", "555-7890"));

            return personas;
        }
        /// <summary>
        /// Busca una persona en el Observable collection según su id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="personas"></param>
        /// <returns>objeto ClsPersona</returns>
        public static ClsPersona BuscarPersonaPorId(int id, ObservableCollection<ClsPersona> personas)
        {
            return personas.FirstOrDefault(persona => persona.Id == id);
        }
        /// <summary>
        /// Busca una persona por su id y la borra
        /// </summary>
        /// <param name="id"></param>
        /// <param name="personas"></param>
        public static void BorrarPersonaPorId(int id, ObservableCollection<ClsPersona> personas)
        {
            ClsPersona personaBorrar = BuscarPersonaPorId(id, personas);
            personas.Remove(personaBorrar);
        }

    }
}
