using ListaTareasDavidAlvarez.MVVM.Modelo;
using ListaTareasDavidAlvarez.MVVM.VistaModelo;

namespace ListaTareasDavidAlvarez.MVVM.Vista;

public partial class Principal : ContentPage
{
    private readonly MainViewModel _viewModel;
    public Principal(MainViewModel viewModel)
	{
        InitializeComponent();
		BindingContext = _viewModel = viewModel;
        
    }
    private async void OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is Tarea tareaSeleccionada)
        {
            await Navigation.PushAsync(new DetallesTareas(_viewModel, tareaSeleccionada));
        }
    }
}