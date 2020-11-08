using System.ComponentModel;
using Xamarin.Forms;
using BaseApp.ViewModels;

namespace BaseApp.Views
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