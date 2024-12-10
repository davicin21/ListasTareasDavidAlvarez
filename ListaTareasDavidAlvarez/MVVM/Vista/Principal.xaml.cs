using ListaTareasDavidAlvarez.MVVM.Modelo;
using ListaTareasDavidAlvarez.MVVM.VistaModelo;

namespace ListaTareasDavidAlvarez.MVVM.Vista;

public partial class Principal : ContentPage
{
    private MainViewModel MainViewModel { get; set; }
    public Principal(MainViewModel viewModel)
    {
        InitializeComponent();
        BindingContext  = viewModel;

    }
    private async void OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Tarea tareaSeleccionada)
        {
            await Navigation.PushAsync(new DetallesTareas(tareaSeleccionada));
        }
    }
    

    
}