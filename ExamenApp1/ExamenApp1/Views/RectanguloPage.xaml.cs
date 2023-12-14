using ExamenApp.ViewModels;
using ExamenApp1.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RectanguloPage : ContentPage
    {
        public RectanguloPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.RectanguloViewModel();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}