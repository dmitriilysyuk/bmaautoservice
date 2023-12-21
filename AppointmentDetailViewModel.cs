using System;
using System.Diagnostics;
using Xamarin.Forms;

// ViewModel для страницы описания прошедшей записи "AppointmentDetail"

namespace bmaservise.ViewModels
{
    [QueryProperty(nameof(AppointmentId), nameof(AppointmentId))]
    public class AppointmentDetailViewModel : BaseViewModel
	{
        // Объявление строк
        private string date;
        private string servicename;
        private string carnumber;
        private string comment;
        private string carmodel;
        private string appointmentId;
        public string Id { get; set; }

        // В данной части кода присваиваются значения соответсвующим строкам
        public string Date
        {
            get => date;
            set => SetProperty(ref date, value);
        }

        public string ServiceName
        {
            get => servicename;
            set => SetProperty(ref servicename, value);
        }

        public string CarNumber
        {
            get => carnumber;
            set => SetProperty(ref carnumber, value);
        }

        public string Comment
        {
            get => comment;
            set => SetProperty(ref comment, value);
        }

        public string CarModel
        {
            get => carmodel;
            set => SetProperty(ref carmodel, value);
        }

        public string AppointmentId
        {
            get
            {
                return appointmentId;
            }
            set
            {
                appointmentId = value;
                LoadAppointmentId(value);
            }
        }

        // Команда для вызова определенного объявления из коллекции
        public async void LoadAppointmentId(string appointmentId)
        {
            try
            {
                var appointment = await DataStore.GetAppointmentAsync(appointmentId);
                Id = appointment.Id;
                Date = appointment.Date;
                ServiceName = appointment.ServiceName;
                CarNumber = appointment.CarNumber;
                Comment = appointment.Comment;
                CarModel = appointment.CarModel;
            }
            catch (Exception)
            {
                Debug.WriteLine("Не удалось загрузить запись");
            }
        }
    }
}

