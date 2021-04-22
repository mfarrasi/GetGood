using GetGood.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace GetGood.Views
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