using AppXamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace AppXamarin.Views
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