using HealthCareApp.Core.Models;

namespace HealthCareApp.Core.Interfaces
{
    // Defines visit operations
    public interface IVisitRepository
    {
        void RecordVisit(Visit visit);

        List<Visit> GetAllVisits();
    }
}
