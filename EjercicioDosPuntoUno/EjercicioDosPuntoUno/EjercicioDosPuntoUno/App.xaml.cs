using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EjercicioDosPuntoUno.Views;

namespace EjercicioDosPuntoUno
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CountriesPage());
            
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
