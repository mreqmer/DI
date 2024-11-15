using Ejercicio01.Models.ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio01.Models.BL;
using Ejercicio01.Models.VM.Utils;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejercicio01.Models.VM
{
    public class ListadoPersonasVM : INotifyPropertyChanged
    {

        private DelegateCommand btnEliminarCommand;


        private ObservableCollection<ClsPersona> listaPersonas;

        private ClsPersona personaSeleccionada;

        public DelegateCommand BtnEliminarCommand { get { return btnEliminarCommand; } }

        public ObservableCollection<ClsPersona> ListaPersonas { get { return listaPersonas; } }

        public ClsPersona PersonaSeleccionada { 
            get => personaSeleccionada;
            set { 
                personaSeleccionada = value;
                btnEliminarCommand.RaiseCanExecuteChanged();
                OnPropertyChanged("PersonaSeleccionada");
            }
        }

        public ListadoPersonasVM()
        {
            this.listaPersonas = ListadosBl.ObtenerPersonasBl();
            btnEliminarCommand = new DelegateCommand(btnEliminarCommand_Execute, btnEliminarCommand_CanExecute);
        }

        public ListadoPersonasVM(int idPersonaSeleccionada)
        {
            this.listaPersonas = ListadosBl.ObtenerPersonasBl();
            this.personaSeleccionada = ListadosBl.BuscarPersonaPorIdBl(idPersonaSeleccionada, listaPersonas);
            btnEliminarCommand = new DelegateCommand(btnEliminarCommand_Execute, btnEliminarCommand_CanExecute);
        }

        private bool btnEliminarCommand_CanExecute()
        {
            bool canExecute = false;
            if (personaSeleccionada != null)
            {
                canExecute = true;
            }

            return canExecute;
        }

        private void btnEliminarCommand_Execute()
        {
            BL.ListadosBl.BorrarPersonaIdBl(personaSeleccionada.Id, listaPersonas);
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
