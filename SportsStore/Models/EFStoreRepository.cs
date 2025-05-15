
namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;
        public IQueryable<Product> Products => throw new NotImplementedException();

        public EFStoreRepository(StoreDbContext ctx)
        {
            this.context = ctx;
        }
    }
}
