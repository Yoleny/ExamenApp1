using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenApp.ViewModels
{
    public class CirculoViewModel : INotifyPropertyChanged
    {
        private double radio;
        public double Radio
        {
            get { return radio; }
            set
            {
                if (radio != value)
                {
                    radio = value;
                    OnPropertyChanged();
                }
            }
        }

        private double areaCirculo;
        public double AreaCirculo
        {
            get { return areaCirculo; }
            set
            {
                if (areaCirculo != value)
                {
                    areaCirculo = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CalcularAreaCirculoCommand { get; }
        public ICommand LimpiarCommand { get; }

        public CirculoViewModel()
        {
            CalcularAreaCirculoCommand = new Command(CalcularAreaCirculo);
            LimpiarCommand = new Command(LimpiarCampos);
        }

        private void CalcularAreaCirculo()
        {
            // Validar que el radio no sea 0 o negativo
            if (radio <= 0)
            {
                // Mostrar mensaje de error
                return;
            }

            // Calcular el área del círculo
            double area = Math.PI * Math.Pow(radio, 2);

            AreaCirculo = area;
        }

        private void LimpiarCampos()
        {
            Radio = 0;
            AreaCirculo = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}