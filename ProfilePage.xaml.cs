using Xamarin.Forms;

// Страница профиля

namespace bmaservise.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        // Команда выходит из аккаунта и отсылает пользователя на страницу входа
        async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}

