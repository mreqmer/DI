using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio01.Models.VM.Utils;
using DAL01;
using Microsoft.Data.SqlClient;

namespace Ejercicio01.Models.VM
{
    internal class VistaConexionVM : clsVMBase
    {
        #region Atributos
        private ClsConexion miConexion;
        private string respuesta;
        private DelegateCommand btnConexionCommand;
        #endregion

        #region Propiedades
        public ClsConexion MiConexion { get { return miConexion; } set { miConexion = value; } }
        public string Respuesta { get { return respuesta; } set { respuesta = value; } }
        public DelegateCommand BtnConexionCommand { get { return btnConexionCommand; } }

        #endregion

        #region Constructores

        public VistaConexionVM()
        {
            
            btnConexionCommand = new DelegateCommand(btnConexionCommand_Execute, btnConexionCommand_CanExecute);
        }

        #endregion

        #region Commands

        /// <summary>
        /// Verifica si se puede habilitar el boton
        /// </summary>
        /// <returns></returns>
        public bool btnConexionCommand_CanExecute()
        {
            //TODO cuando funque ponerlo bien
            return true;
        }
        /// <summary>
        ///Boton que se dedica a hacer una conexion con la BD 
        /// </summary>
        private void btnConexionCommand_Execute()
        {
            SqlConnection miConexion = new SqlConnection();

            try

            {
                miConexion.ConnectionString = ClsConexion.CadenaConexion();
                miConexion.Open();

                respuesta = miConexion.State.ToString();
                OnPropertyChanged("Respuesta");
            }
            catch (Exception ex)
            {
                respuesta = "Hubo un problema";
                OnPropertyChanged("Respuesta");
            }
            finally
            {
                miConexion.Close();
            }
        }



        #endregion


    }
}
