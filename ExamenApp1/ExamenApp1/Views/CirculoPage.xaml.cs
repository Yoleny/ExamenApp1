using ExamenApp1.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenApp1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CirculoPage : ContentPage
    {
        public CirculoPage()
        {
            InitializeComponent();
            BindingContext = new CirculoViewModel();
        }

        
    }

    internal class CirculoViewModel
    {
        public CirculoViewModel()
        {
        }
    }
}