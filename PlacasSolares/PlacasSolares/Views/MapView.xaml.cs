namespace PlacasSolares.Views;

public partial class MapView : ContentPage
{
	public MapView()
	{
		InitializeComponent();
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