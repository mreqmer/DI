
using PlacasSolares.Views;

namespace PlacasSolares
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUsuario.Text) && !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                await Navigation.PushAsync(new CitasView());
            }

        }


    }

}
