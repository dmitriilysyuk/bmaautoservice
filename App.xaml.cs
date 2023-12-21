using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using bmaservise.Services;
using bmaservise.Views;

namespace bmaservise
{
    public partial class App : Application
    {

        public App ()
        {
            InitializeComponent();

            DependencyService.Register<AppointmentService>();
            MainPage = new AppShell();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

