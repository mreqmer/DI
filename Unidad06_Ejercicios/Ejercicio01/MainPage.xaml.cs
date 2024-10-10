using Android.Graphics.Fonts;
using Android.Service.VR;
using static Java.Util.Jar.Attributes;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio01
{
    public partial class MainPage : ContentPage
    {
        //controla ssi el boton 3 ha sido ya creado o no
        Boolean btn3Creado = false;

        public MainPage()
        {
            InitializeComponent();
            
        }

        /// <summary>
        /// Clickable del btnBoton2 que crea el btnBoton3 si no se ha creado ya
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCounterClickedBtn02(object sender, EventArgs e)
        {
            
            Button btnBoton3;

            if (!btn3Creado)
            {
                btnBoton3 = new Button
                 {

                     Text = "Boton3",
                     BackgroundColor = Color.FromArgb("aa00bb"),
                     MaximumHeightRequest = 70,
                     MaximumWidthRequest = 200,
                     FontFamily = "Verdana",
                     FontAttributes = FontAttributes.Bold,
                     BorderColor = Color.FromArgb("ffff00"),
                     BorderWidth = 5,
                     Margin = 5
                 };
                btnBoton3.Clicked += OnCounterClickedBtn03;

                VSL.Children.Add(btnBoton3);
                btn3Creado = true;
            }

        }
        /// <summary>
        /// Clickable del btnBoton3 que eleminina el btnBoton1 y cambia el texto del btnBoton2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCounterClickedBtn03(object sender, EventArgs e)
        {
            VSL.Children.Remove(btnBoton1);
            btnBoton2.Text = "Crear controles en tiempo de ejecución mola";
        }
    }

}
