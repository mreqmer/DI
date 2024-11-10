using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Models
{
    internal class ClsPersona : INotifyPropertyChanged
    {
        private string nombre;

        public ClsPersona()
        {
            Nombre = "Marta";
        }

        public string Nombre {
            get => nombre;
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        
        }

       
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
