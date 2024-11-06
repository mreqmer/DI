using PlacasSolares.Models.DAL;

namespace PlacasSolares.Views;

public partial class CitasView : ContentPage
{
	public CitasView()
	{
        InitializeComponent();

        CitasListView.ItemsSource = Listados.ListarCitas();
    }
    /// <summary>
    /// Boton que navega a Reporte
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnClickReporte(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ReporteView());
    }
    /// <summary>
    /// Boton que navega atras
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnClickBack(object sender, EventArgs e)
    {
        
        await Navigation.PopAsync();
    }
}
