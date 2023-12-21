using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using bmaservise.Models;
using System.Linq;

/* В данном файле создается коллекция прошедших записей 
   и прописываются команды по выводу конкретной записи и выводу целой коллекции */

namespace bmaservise.Services
{
	public class AppointmentService : IDataStore<Appointment>
	{
        readonly List<Appointment> appointments;

        // Создается коллекцию прошедших записей
        public AppointmentService()
        {
            appointments = new List<Appointment>()
            {
                new Appointment(){Id = Guid.NewGuid().ToString(), Date = "10 октября 2023", ServiceName = "Кузовной ремонт",
                    CarNumber = "В 051 НА 777", CarModel ="BMW M3 2020", Comment = "Проведена замена переднего бампера."},
                new Appointment(){Id = Guid.NewGuid().ToString(), Date = "20 августа 2023", ServiceName = "Плановое ТО",
                    CarNumber = "В 051 НА 777", CarModel ="BMW M3 2020", Comment = "Проведено плановое ТО. Пробег на момент обслуживания - 21 568 км. Заменено моторное масло и фильтры. Рекомендуем заменить тормозные колодки через 3000 км пробега. Следующее плановое ТО через год или 7000 км пробега."},
                new Appointment(){Id = Guid.NewGuid().ToString(), Date = "14 августа 2023", ServiceName = "Плановое ТО",
                    CarNumber = "В 051 НА 777", CarModel ="BMW M3 2020", Comment = "Проведено плановое ТО. Пробег на момент обслуживания - 15 067 км. Заменено моторное масло. Поломок не выявлено."},
            };
        }

        // Команда для выводу конкретной записи
        public async Task<Appointment> GetAppointmentAsync(string id)
        {
            return await Task.FromResult(appointments.FirstOrDefault(s => s.Id == id));
        }

        // Команда для вывода коллекции записей
        public async Task<IEnumerable<Appointment>> GetAppointmentsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(appointments);
        }
    }
}

