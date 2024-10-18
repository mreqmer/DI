namespace Ejercicio02.Views;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}

    private async void GoToMain(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}