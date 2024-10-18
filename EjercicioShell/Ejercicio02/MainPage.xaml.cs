

namespace Ejercicio02
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoToTab(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaTabbed());
        }
    }

}
