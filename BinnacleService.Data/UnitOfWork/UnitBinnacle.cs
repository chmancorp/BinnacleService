
namespace BinnacleService.Data.UnitOfWork
{
    using System;
    using BinnacleService.Data.DataAccess;
    using BinnacleService.Data.Repositories;

    public class UnitBinnacle : IUnitBinnacle
    {
        private BinnacleDbContext _dbContext;

        public UnitBinnacle(BinnacleDbContext dbContext)
        {
            _dbContext = dbContext;
            Repository = new Repository(dbContext);
        }

        public IRepository Repository
        {
            get; private set;
        }
        public int Complete()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                string oh = e.InnerException.Message;
                throw;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
