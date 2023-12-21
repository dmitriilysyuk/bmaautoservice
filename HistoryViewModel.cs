using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using bmaservise.Models;
using bmaservise.Views;
using System.Diagnostics;
using System.Threading.Tasks;

// ViewModel для страницы "HistoryPage" - страница с прошедшими записями

namespace bmaservise.ViewModels
{
	public class HistoryViewModel : BaseViewModel
	{
        // Объявление команд
        private Appointment _selectedAppointment;
        public ObservableCollection<Appointment> Appointments { get; }
        public Command LoadAppointmentsCommand { get; }
        public Command<Appointment> AppointmentTapped { get; }

        public HistoryViewModel()
		{
            // Командам присваиваются значения
            Appointments = new ObservableCollection<Appointment>();
            LoadAppointmentsCommand = new Command(async () => await ExecuteLoadAppointmentsCommand());
            AppointmentTapped = new Command<Appointment>(OnAppointmentSelected);           
        }

        // Функция для команды загрузки коллекции прошедших записей "LoadAppointmentCommand"
        async Task ExecuteLoadAppointmentsCommand()
        {
            IsBusy = true;

            try
            {
                Appointments.Clear();
                var appointments = await DataStore.GetAppointmentsAsync(true);
                foreach (var appointment in appointments)
                {
                    Appointments.Add(appointment);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            SelectedAppointment = null;
        }

        public Appointment SelectedAppointment
        {
            get => _selectedAppointment;
            set
            {
                SetProperty(ref _selectedAppointment, value);
                OnAppointmentSelected(value);
            }
        }

        // Функция для команды выбора записи "AppointmentTapped"
        async void OnAppointmentSelected(Appointment appointment)
        {
            if (appointment == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(AppointmentDetail)}?{nameof(AppointmentDetailViewModel.AppointmentId)}={appointment.Id}");
        }
    }
}

