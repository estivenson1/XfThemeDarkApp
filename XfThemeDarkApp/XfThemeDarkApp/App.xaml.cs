using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XfThemeDarkApp.Views;

namespace XfThemeDarkApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterDetailView();
            //MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
