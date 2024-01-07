using StarDentApi.Entities;
using StarDentApi.Repositories.Abstract;

namespace StarDentApi.Repositories.Concrete
{
    public class TablemetaconfigRepository : Repository<TablemetaconfigEntity> , ITablemetaconfigRepository
    {
        public TablemetaconfigRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
