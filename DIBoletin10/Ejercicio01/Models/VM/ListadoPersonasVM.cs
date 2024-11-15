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
    /// <summary>
    /// VM para la vista MainPage, implementa INotifyPropertyChanged
    /// </summary>
    public class ListadoPersonasVM : clsVMBase
    {
        #region Atributos
        private DelegateCommand btnBuscarCommand;

        private DelegateCommand btnEliminarCommand;

        private string busqueda = "";

        private ObservableCollection<ClsPersona> listaOriginal;
        private ObservableCollection<ClsPersona> lista;


        private ClsPersona personaSeleccionada;
        #endregion

        #region Propiedades
        public DelegateCommand BtnBuscarCommand { get { return btnBuscarCommand;}}
        public DelegateCommand BtnEliminarCommand { get { return btnEliminarCommand; } }

        public string Busqueda 
        {
            get { return busqueda;} 
            set {
                busqueda = value;
                btnBuscarCommand.RaiseCanExecuteChanged();
                OnPropertyChanged("Busqueda");
                if (!btnBuscarCommand_CanExecute())
                {
                    lista = listaOriginal;
                    OnPropertyChanged("Lista");
                }
                
                
            } 
        }


        public ObservableCollection<ClsPersona> Lista 
        {
            get { return lista; }
           
        }

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
            this.listaOriginal = ListadosBl.ObtenerPersonasBl();
            this.lista = listaOriginal;
            btnEliminarCommand = new DelegateCommand(btnEliminarCommand_Execute, btnEliminarCommand_CanExecute);
            btnBuscarCommand = new DelegateCommand(btnBuscarCommand_Execute, btnBuscarCommand_CanExecute);
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
        /// Verifica si se puede ejecutar o no el boton para la busqueda
        /// </summary>
        /// <returns></returns>
        private bool btnBuscarCommand_CanExecute()
        {
            bool canExecute = false;
            if (busqueda.Length>0)
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
            listaOriginal.Remove(personaSeleccionada);
            lista.Remove(personaSeleccionada);
        }
        /// <summary>
        /// Logica del boton para filtrar personas
        /// </summary>
        private void btnBuscarCommand_Execute()
        {
            
            lista = ListadosBl.FiltrarPorNombreBl(ref listaOriginal, busqueda);
            OnPropertyChanged("Lista");

        }
        #endregion
    }
}
