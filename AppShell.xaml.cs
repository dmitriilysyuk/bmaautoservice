using bmaservise.Views;
using Xamarin.Forms;

namespace bmaservise
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            // Здесь регистрируются пути к страницам, которые не отображаются с таб-баре
            InitializeComponent();
            Routing.RegisterRoute(nameof(AppointmentDetail), typeof(AppointmentDetail));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(ContactsPage), typeof(ContactsPage));
            Routing.RegisterRoute(nameof(ArticlePage), typeof(ArticlePage));
        }
    }
}

