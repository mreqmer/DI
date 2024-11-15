using Ejercicio02.Models.ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio02.Models.BL;
using Ejercicio02.Models.VM.Utils;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejercicio02.Models.VM
{
    /// <summary>
    /// VM para la vista MainPage, implementa INotifyPropertyChanged
    /// </summary>
    public class ListadoPersonasVM : clsVMBase
    {
        #region Atributos
        private DelegateCommand btnEliminarCommand;

        private ObservableCollection<ClsPersona> listaPersonas;

        private ClsPersona personaSeleccionada;
        #endregion

        #region Propiedades
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
        #endregion

        #region Constructores
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
        #endregion

        #region Commands
        /// <summary>
        /// Verifica si se puede ejecutar o no el btn
        /// </summary>
        /// <returns>boolean de comprobación</returns>
        private bool btnEliminarCommand_CanExecute()
        {
            bool canExecute = false;
            if (personaSeleccionada != null)
            {
                canExecute = true;
            }

            return canExecute;
        }
        /// <summary>
        /// Lógica del boton, borra una persona que está seleccionadad de la lista 
        /// </summary>
        private void btnEliminarCommand_Execute()
        {
            BL.ListadosBl.BorrarPersonaIdBl(personaSeleccionada.Id, listaPersonas);
        }
        #endregion
    }
}
