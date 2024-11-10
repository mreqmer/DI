using Ejercicio05.Models.ENT;

namespace Ejercicio05.Views;

public partial class DetallesPersona : ContentPage
{
    public DetallesPersona(ClsPersona personaSeleccionada)
    {
        InitializeComponent();
        BindingContext = personaSeleccionada;
    }
}