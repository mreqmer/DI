namespace HolaMundo
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            
            InitializeComponent();
            
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

            String nombre = txtNombre.Text;
            String apellido = txtApellidos.Text;
            clsPersona Persona;


            if (String.IsNullOrEmpty(nombre) && String.IsNullOrEmpty(apellido))
            {
                txtTexto.TextColor = Colors.Aqua;
                txtTexto.Text = "Error, faltan datos";

            }
            else if(String.IsNullOrEmpty(apellido))
            {
                txtTexto.TextColor = Colors.Aqua;
                txtTexto.Text = "Error, falta apellidos";

            }else if(String.IsNullOrEmpty(nombre))
            {
                txtTexto.TextColor = Colors.Aqua;
                txtTexto.Text = "Error, falta nombre";
            }
            else
            {
                Persona = new clsPersona(nombre, apellido);
                txtTexto.Text = $"Hola, {nombre}  {apellido}";
            }

           


        }
    }

}
