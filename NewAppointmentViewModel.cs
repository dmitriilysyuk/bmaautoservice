using System.Collections.Generic;
using bmaservise.Models;
using bmaservise.Services;
using System.Linq;

// Страница создания новой записи

namespace bmaservise.ViewModels
{
    public class NewAppointmentViewModel : BaseViewModel
    {
        public NewAppointmentViewModel()
        {
            // Команде присваивается функция для вывода элемента Picker
            ListAutoServices = PickerService.GetAutoServices().OrderBy(t => t.Value).ToList();
        }

        // Объявление команд
        public List<AutoService> ListAutoServices { get; set; }
        private AutoService _selectedAutoService { get; set; }

        public AutoService SelectedAutoService
        {
            get
            { 
                return _selectedAutoService;
            }
            set
            {
                if (_selectedAutoService != value)
                {
                    _selectedAutoService = value;
                    AutoServiceText = _selectedAutoService.Value;
                } 
            }
        }

        string _autoServiceText;
        public string AutoServiceText
        {
            get
            { 
                return _autoServiceText;
            }
            set
            {
                if (_autoServiceText != value)
                {
                    _autoServiceText = value;
                    OnPropertyChanged();
                }   
            }
        }
    }
}