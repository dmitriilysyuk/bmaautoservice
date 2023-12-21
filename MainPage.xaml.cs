using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace bmaservise.Views
{	
	public partial class MainPage : ContentPage
	{	
		public MainPage ()
		{
			InitializeComponent ();
		}

        // Следующие команды отсылают пользователя на соответсвующие страницы
        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(ArticlePage)}");
        }

        async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(ContactsPage)}");
        }

        async void ImageButton_Clicked_2(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync($"{nameof(AboutPage)}");
        }

        // Команда отсылает пользователя на интернет-ресурс с прайс-листом
        async void ImageButton_Clicked_3(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://disk.yandex.ru/i/PvRykoPKf7uvOA");
        }
    }
}


