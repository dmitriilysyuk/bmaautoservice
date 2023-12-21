
// В данной модели указываются параматры для элемента коллекции прошедших записей

namespace bmaservise.Models
{
	public class Appointment
	{
        public string Id { get; set; }
        public string Date { get; set; }
        public string ServiceName { get; set; }
        public string CarNumber { get; set; }
        public string CarModel { get; set; }
        public string Comment{ get; set; }
	}
}

