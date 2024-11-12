using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.VM
{
    internal class TrolleoVM : INotifyPropertyChanged
    {

        private string nombre;
        private string apellido;

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                if (nombre.Contains("n"))
                {
                    apellido = "";
                    OnPropertyChanged("Apellido");
                }
                
            }
        }

        public string Apellido {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;

                if (apellido.Contains("n"))
                {
                    nombre = "";
                    OnPropertyChanged("Nombre");  
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
            
}

