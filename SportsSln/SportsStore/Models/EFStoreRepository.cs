namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDBContext _dbContext;

        public EFStoreRepository(StoreDBContext ctx)
        {
            _dbContext = ctx;
        }   

        public IQueryable<Product> Products => _dbContext.Products;
    }
}
