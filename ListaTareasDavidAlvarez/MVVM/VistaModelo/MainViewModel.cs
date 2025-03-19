using ListaTareasDavidAlvarez.MVVM.Modelo;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ListaTareasDavidAlvarez.MVVM.VistaModelo
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Tarea> ListaTareas { get; set; } = new ObservableCollection<Tarea>();

        private Tarea tareaSeleccionada;
        public Tarea TareaSeleccionada
        {
            get => tareaSeleccionada;
            set
            {
                tareaSeleccionada = value;
                OnPropertyChanged();
            }
        }

        public ICommand AgregarTareaCommand { get; }
        public ICommand EliminarTareaCommand { get; }

        public MainViewModel()
        {
            AgregarTareaCommand = new Command(AgregarTarea);
            EliminarTareaCommand = new Command<Tarea>(EliminarTarea);
        }

        private void AgregarTarea()
        {
            ListaTareas.Add(new Tarea { Nombre = "Nueva Tarea", Completada = false });
        }

        private void EliminarTarea(Tarea tarea)
        {
            if (tarea != null)
                ListaTareas.Remove(tarea);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Refresh()
        {
            OnPropertyChanged(nameof(ListaTareas));
        }
    }
}
