
using ListaTareasDavidAlvarez.MVVM.Modelo;
using ListaTareasDavidAlvarez.MVVM.VistaModelo;
using System.Collections.ObjectModel;

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
    private async void OnDeleteClicked(object sender, EventArgs e)
    {

        bool confirm = await DisplayAlert("Eliminar Tarea", "¿Estás seguro de eliminar esta tarea?", "Sí", "No");
        if (confirm)
        {
            await Navigation.PopAsync(); // Vuelve a la página principal
        }
    }



}
