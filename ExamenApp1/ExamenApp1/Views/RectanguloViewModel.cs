using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenApp1.ViewModels
{
    public class RectanguloViewModel : INotifyPropertyChanged
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

        private double areaRectangulo;
        public double AreaRectangulo
        {
            get { return areaRectangulo; }
            set
            {
                if (areaRectangulo != value)
                {
                    areaRectangulo = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CalcularAreaRectanguloCommand { get; }
        public ICommand LimpiarCommand { get; }

        public RectanguloViewModel()
        {
            CalcularAreaRectanguloCommand = new Command(CalcularAreaRectangulo);
            LimpiarCommand = new Command(LimpiarCampos);
        }

        private void CalcularAreaRectangulo(object obj)
        {
            throw new NotImplementedException();
        }

        private void CalcularareaRectangulo()
        {
            // Validar que el radio no sea 0 o negativo
            if (radio <= 0)
            {
                // Mostrar mensaje de error
                return;
            }

            // Calcular el área del círculo
            double area = Math.PI * Math.Pow(radio, 2);

            AreaRectangulo = area;
        }

        private void LimpiarCampos()
        {
            Radio = 0;
            AreaRectangulo = 0;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}