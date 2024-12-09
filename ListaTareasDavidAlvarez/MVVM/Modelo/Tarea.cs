using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTareasDavidAlvarez.MVVM.Modelo
{
    public class Tarea : INotifyPropertyChanged
    {
        private string nombre;
        private bool completada;

        public string Nombre
        {
            get => nombre;
            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged(nameof(Nombre));
                }
            }
        }

        public bool Completada
        {
            get => completada;
            set
            {
                if (completada != value)
                {
                    completada = value;
                    OnPropertyChanged(nameof(Completada));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
