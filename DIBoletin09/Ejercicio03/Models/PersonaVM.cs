using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ENT03;

namespace Ejercicio03.Models
{
    public class PersonaVM : INotifyPropertyChanged
    {
        #region Atributos
        private string nombre;
        
        #endregion

        #region Get/Set
        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }
        #endregion

        #region Constructores
        public PersonaVM()
        {
            nombre = "Marta";
        }

        #endregion

        #region PropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
