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
        private Persona persona;
        #endregion

        #region Get/Set
        public Persona Persona
        {
            get => persona;
            set
            {
                if (persona != value)
                {
                    persona = value;
                    OnPropertyChanged("Nombre");
                }
            }
        }
        #endregion

        #region Constructores
        public PersonaVM()
        {
            Persona = new Persona();
        }

        public PersonaVM(string nombre)
        {
            Persona = new Persona(nombre);
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
