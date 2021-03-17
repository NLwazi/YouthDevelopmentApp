using Xamarin.Forms;
using System;
using OpportunitiesArise.Views;

namespace OpportunitiesArise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
