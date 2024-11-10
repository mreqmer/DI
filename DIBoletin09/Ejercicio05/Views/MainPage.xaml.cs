using Ejercicio05.Models.ENT;

namespace Ejercicio05.Views
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private async void Seleccion(object sender, ItemTappedEventArgs e)
        {
            //si el elemento seleccionado es distinto de nulo entonces
            if (e.Item != null)
            {
                //el elemento e.Item se pasa a ser una personas con el as
                ClsPersona personaSeleccionada = e.Item as ClsPersona;
                await Navigation.PushAsync(new DetallesPersona(personaSeleccionada));
            }
        }
    }

}
