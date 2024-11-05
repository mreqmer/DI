using PlacasSolares.Models.DAL;

namespace PlacasSolares.Views;

public partial class CitasView : ContentPage
{
	public CitasView()
	{
        InitializeComponent();

        CitasListView.ItemsSource = Listados.ListarCitas();
    }
    private async void OnClickReporte(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ReporteView());
    }
}