using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SEMANA6VK
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Vista();
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
