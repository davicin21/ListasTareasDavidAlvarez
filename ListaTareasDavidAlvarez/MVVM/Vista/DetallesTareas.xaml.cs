
using ListaTareasDavidAlvarez.MVVM.Modelo;
using ListaTareasDavidAlvarez.MVVM.VistaModelo;

namespace ListaTareasDavidAlvarez.MVVM.Vista;

public partial class DetallesTareas : ContentPage
{
    private readonly MainViewModel _viewModel;
    private readonly Tarea _tarea;
    private Tarea tareaTemporal;
    public DetallesTareas(MainViewModel viewModel, Tarea tarea)
    {
        InitializeComponent();
        _viewModel = viewModel;
        _tarea = tarea;
        tareaTemporal = new Tarea
        {
            Nombre = tarea.Nombre,
            Completada = tarea.Completada
        };
        BindingContext = tareaTemporal;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void OnSaveClicked(object sender, EventArgs e)
    {
        _tarea.Nombre= tareaTemporal.Nombre;
        _tarea.Completada= tareaTemporal.Completada;

        _viewModel.Refresh();
        await Navigation.PopAsync();
    }
}
