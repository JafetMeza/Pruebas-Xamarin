using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BeautifulUI.Services;
using BeautifulUI.Views;

namespace BeautifulUI
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            //MainPage = new AppShell();
            MainPage = new SciodeskPage();
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
