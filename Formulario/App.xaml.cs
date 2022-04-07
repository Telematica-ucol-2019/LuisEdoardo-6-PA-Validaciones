using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Formulario.View;

namespace Formulario
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new FormularioPage());
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
