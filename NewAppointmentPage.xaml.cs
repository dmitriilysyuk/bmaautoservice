using System;
using bmaservise.ViewModels;
using bmaservise.Models;
using Xamarin.Forms;

namespace bmaservise.Views
{	
	public partial class NewAppointmentPage : ContentPage
	{
        public Appointment Appointment { get; set; }

        public NewAppointmentPage ()
		{
			InitializeComponent ();

            // Команда соединяет страницу с соответсвующей ViewModel
            BindingContext = new NewAppointmentViewModel();
		}

        // Команда выводит уведомление об успешной записи и отсылает пользователя на гланую страницу
        async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Поздравляем", "Вы успешно записаны", "OK");
            await Shell.Current.GoToAsync("//MainPage");

            EntryCarModel.Text = "";
            EntryCarNumber.Text = "";
            PickerService.SelectedItem = "";
        }
    }
}


