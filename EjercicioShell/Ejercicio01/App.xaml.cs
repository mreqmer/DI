using Ejercicio01.Views;

namespace Ejercicio01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaTabbed();
        }
    }
}
