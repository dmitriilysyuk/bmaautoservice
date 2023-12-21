using bmaservise.ViewModels;
using Xamarin.Forms;

// Страница "Детали записи"

namespace bmaservise.Views
{	
	public partial class AppointmentDetail : ContentPage
	{	
		public AppointmentDetail ()
		{
			InitializeComponent ();

            // Команда соединяет страницу с соответсвующей ViewModel
            BindingContext = new AppointmentDetailViewModel();
        }
	}
}

