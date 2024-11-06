
using PlacasSolares.Views;

namespace PlacasSolares
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boton que va a citas cuando el usuario está logeado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                await Navigation.PushAsync(new CitasView());
            }

        }


    }

}
