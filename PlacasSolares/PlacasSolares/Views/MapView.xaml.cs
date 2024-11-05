namespace PlacasSolares.Views;

public partial class MapView : ContentPage
{
	public MapView()
	{
		InitializeComponent();
	}

    private async void OnClickBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

}