namespace PlacasSolares.Views;

public partial class ReporteView : ContentPage
{
	public ReporteView()
	{
		InitializeComponent();
	}

    private void OnClickAceptar(object sender, EventArgs e)
    {
        if (BtnAceptar.BackgroundColor.ToHex() == "#023E8A")
        {
            BtnAceptar.BackgroundColor = Color.FromArgb("#FFFFFF");
            BtnAceptar.BorderColor = Color.FromArgb("#023E8A");
            BtnAceptar.TextColor = Color.FromArgb("#023E8A");

            BtnRechazar.BackgroundColor = Color.FromArgb("#023E8A");
            BtnRechazar.BorderColor = Color.FromArgb("#023E8A");
            BtnRechazar.TextColor = Color.FromArgb("#FFFFFF");

        }
        else
        {
            BtnAceptar.BackgroundColor = Color.FromArgb("#023E8A");
            BtnAceptar.BorderColor = Color.FromArgb("#023E8A");
            BtnAceptar.TextColor = Color.FromArgb("#FFFFFF");

            BtnRechazar.BackgroundColor = Color.FromArgb("#FFFFFF");
            BtnRechazar.BorderColor = Color.FromArgb("#023E8A");
            BtnRechazar.TextColor = Color.FromArgb("#023E8A");
        }
    }

    private void OnClickRechazar(object sender, EventArgs e)
    {
        if (BtnRechazar.BackgroundColor.ToHex() == "#023E8A")
        {
            BtnRechazar.BackgroundColor = Color.FromArgb("#FFFFFF");
            BtnRechazar.BorderColor = Color.FromArgb("#023E8A");
            BtnRechazar.TextColor = Color.FromArgb("#023E8A");

            BtnAceptar.BackgroundColor = Color.FromArgb("#023E8A");
            BtnAceptar.BorderColor = Color.FromArgb("#023E8A");
            BtnAceptar.TextColor = Color.FromArgb("#FFFFFF");
        }
        else
        {
            BtnRechazar.BackgroundColor = Color.FromArgb("#023E8A");
            BtnRechazar.BorderColor = Color.FromArgb("#023E8A");
            BtnRechazar.TextColor = Color.FromArgb("#FFFFFF");

            BtnAceptar.BackgroundColor = Color.FromArgb("#FFFFFF");
            BtnAceptar.BorderColor = Color.FromArgb("#023E8A");
            BtnAceptar.TextColor = Color.FromArgb("#023E8A");
        }
        
    }
    private async void GoToMap(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MapView());
    }
    private async void OnClickBack(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}