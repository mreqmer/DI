using Ejercicio05Ent;
using System.Collections.ObjectModel;

namespace Ejercicio05UI
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection <clsPersona> personas = new ObservableCollection<clsPersona>();
        public ObservableCollection<clsPersona> Persona { get { return personas; } }

        public MainPage()
        {
            InitializeComponent();
            personas.Add(new clsPersona() { Nombre = "John", Descripcion = "A friendly neighbor", Foto = "def.png" });
            personas.Add(new clsPersona() { Nombre = "Sarah", Descripcion = "Loves painting", Foto = "def.png" });
            personas.Add(new clsPersona() { Nombre = "Michael", Descripcion = "Tech enthusiast", Foto = "def.png" });
            personas.Add(new clsPersona() { Nombre = "Emma", Descripcion = "Avid reader", Foto = "def.png" });
            personas.Add(new clsPersona() { Nombre = "David", Descripcion = "Enjoys hiking", Foto = "def.png" });
            personas.Add(new clsPersona() { Nombre = "Olivia", Descripcion = "Coffee lover", Foto = "def.png" });
            personas.Add(new clsPersona() { Nombre = "James", Descripcion = "Football fan", Foto = "def.png" });
            personas.Add(new clsPersona() { Nombre = "Sophia", Descripcion = "Animal lover", Foto = "def.png" });
            personas.Add(new clsPersona() { Nombre = "Daniel", Descripcion = "Musician", Foto = "def.png" });
            personas.Add(new clsPersona() { Nombre = "Isabella", Descripcion = "Fashion enthusiast", Foto = "def.png" });
            PersonaListView.ItemsSource = personas;
        }

        
    }

}
