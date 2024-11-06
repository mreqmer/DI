namespace PlacasSolares.Views;

public partial class ReporteView : ContentPage
{
	public ReporteView()
	{
		InitializeComponent();
	}

    
    /// <summary>
    /// Boton Aceptar que cambia el estilo propio y del boton Rechazar
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
    /// <summary>
    /// Boton Rechazar que cambia el estilo propio y del boton Aceptar
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
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
    /// <summary>
    /// Boton que navega a la view del mapa
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToMap(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MapView());
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