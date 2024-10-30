using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tema09.ViewModels
{
    internal class EdadVM : INotifyPropertyChanged
    {
        #region Atributos
        private DateTime fechaNac;
        private int edad;
        #endregion

        #region Propiedades Publicas
        public DateTime FechaNac {
            get { return fechaNac; }
            set { fechaNac = value; edad = DateTime.Now.Year - value.Year; NotifyPropertyChanged("Edad"); }
        }
        public int Edad
        {
            get { return edad; }
        }
        #endregion


        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;


        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")

        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        }
        #endregion
    }
}
