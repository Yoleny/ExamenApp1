using ExamenApp1.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ExamenApp1.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}