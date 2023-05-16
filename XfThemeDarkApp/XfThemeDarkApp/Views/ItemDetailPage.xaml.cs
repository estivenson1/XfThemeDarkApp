using System.ComponentModel;
using Xamarin.Forms;
using XfThemeDarkApp.ViewModels;

namespace XfThemeDarkApp.Views
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