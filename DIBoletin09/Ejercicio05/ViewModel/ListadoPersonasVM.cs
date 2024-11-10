using Ejercicio05.Models.ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio05.Models.BL;

namespace Ejercicio05.ViewModel
{
    internal class ListadoPersonasVM
    {

        private ObservableCollection<ClsPersona> listaPersonas;

        public ObservableCollection<ClsPersona> ListaPersonas { get { return listaPersonas; } }

        public ListadoPersonasVM()
        {
            this.listaPersonas = ListadosBl.ObtenerPersonasBl();
        }        

    }
}
