using Xamarin.Forms;
using bmaservise.ViewModels;

// Cтраница "История записей"

namespace bmaservise.Views
{	
	public partial class HistoryPage : ContentPage
	{
        HistoryViewModel _viewModel;

        public HistoryPage ()
		{
			InitializeComponent ();

            // Команда соединяет страницу с соответсвующей ViewModel
            BindingContext = _viewModel = new HistoryViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    
    }
}

