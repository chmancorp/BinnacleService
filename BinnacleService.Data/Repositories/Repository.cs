
namespace BinnacleService.Data.Repositories
{
    using System;
    using BinnacleService.Data.DataAccess;
    using BinnacleService.Data.Models;

    public class Repository : IRepository
    {
        private readonly BinnacleDbContext _dbContext;

        public Repository(BinnacleDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void SaveBinnacle(Binnacle binnacleData)
        {
            _dbContext.Add(binnacleData);
        }
    }
}
