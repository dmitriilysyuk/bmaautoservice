using System.Collections.Generic;
using System.Threading.Tasks;

namespace bmaservise.Services
{
    public interface IDataStore<T>
    {
        Task<T> GetAppointmentAsync(string id);
        Task<IEnumerable<T>> GetAppointmentsAsync(bool forceRefresh = false);
    }
}

