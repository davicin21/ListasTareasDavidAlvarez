
using ListaTareasDavidAlvarez.MVVM.Modelo;
using ListaTareasDavidAlvarez.MVVM.VistaModelo;

namespace ListaTareasDavidAlvarez.MVVM.Vista;

public partial class DetallesTareas : ContentPage
{
    private Tarea tareaOriginal; 
    private Tarea tareaTemporal;
    public DetallesTareas(Tarea tareaSeleccionada)
    {
        InitializeComponent();
        tareaOriginal = tareaSeleccionada;
        tareaTemporal = new Tarea
        {
            Nombre = tareaSeleccionada.Nombre,
            Completada = tareaSeleccionada.Completada
        };
        BindingContext = tareaTemporal;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    private async void OnSaveClicked(object sender, EventArgs e)
    {
        tareaOriginal.Nombre = tareaTemporal.Nombre;
        tareaOriginal.Completada = tareaTemporal.Completada;
        await Navigation.PopAsync();
    }



}
