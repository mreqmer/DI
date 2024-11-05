using Placas.Models.ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacasSolares.Models.DAL
{
    public class Listados
    {
        public static ObservableCollection<Cita> ListarCitas()
        {
            ObservableCollection<Cita> citas = new ObservableCollection<Cita>
    {
            new Cita("1", "Carlos García", "2024-11-05", "10:00"),
            new Cita("2", "María López", "2024-11-06", "14:30"),
            new Cita("3", "Juan Martínez", "2024-11-07", "20:00"),
            new Cita("4", "Ana Fernández", "2024-11-08", "07:00"),
            new Cita("5", "Pedro González", "2024-11-09", "09:30"),
            new Cita("6", "Laura Sánchez", "2024-11-10", "15:00"),
            new Cita("7", "José Rodríguez", "2024-11-11", "13:00"),
            new Cita("8", "Lucía Ramírez", "2024-11-12", "11:30"),
            new Cita("9", "Miguel Torres", "2024-11-13", "16:00"),
            new Cita("10", "Carmen Pérez", "2024-11-14", "18:00"),
            new Cita("11", "Luis Morales", "2024-11-15", "19:00"),
            new Cita("12", "Elena Ortiz", "2024-11-16", "08:00"),
            new Cita("13", "Javier Rubio", "2024-11-17", "10:30"),
            new Cita("14", "Raquel Díaz", "2024-11-18", "21:00"),
            new Cita("15", "Sofía Castro", "2024-11-19", "12:00")
    };

            return citas;
        }
    }
}
