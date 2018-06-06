
namespace BinnacleService.Data.Repositories
{
    using BinnacleService.Data.Models;

    public interface IRepository
    {
        void SaveBinnacle(Binnacle binnacleData);
    }
}
