using System.Collections.Generic;
using bmaservise.Models;

// В данном файле создается список для элемента Picker на странице новой записи

namespace bmaservise.Services
{
	public class PickerService
	{
		public static List<AutoService>GetAutoServices()
		{
			var AutoServices = new List<AutoService>()
			{
				new AutoService() {Key = 1, Value ="Плановое ТО"},
                new AutoService() {Key = 2, Value ="Кузовной ремонт"},
                new AutoService() {Key = 2, Value ="Покраска"},
                new AutoService() {Key = 2, Value ="Ремонт двигателя"},
                new AutoService() {Key = 2, Value ="Ремонт трансмиссии"},
                new AutoService() {Key = 2, Value ="Ремонт подвески"}
            };
			return AutoServices;
		}
	}
}

