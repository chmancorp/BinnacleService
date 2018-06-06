
namespace BinnacleService.Data.UnitOfWork
{
    using BinnacleService.Data.Repositories;

    public interface IUnitBinnacle: IUnitOfWork
    {
        IRepository Repository { get; } 
    }
}
