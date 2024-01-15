using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CRITICOGRAFO_MVVM_ASA.Vistas;

namespace CRITICOGRAFO___MVVM_ASA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new VistaPrincipal());
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
