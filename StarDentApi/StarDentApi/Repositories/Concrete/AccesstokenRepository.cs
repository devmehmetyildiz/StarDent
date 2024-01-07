using StarDentApi.Entities;
using StarDentApi.Repositories.Abstract;

namespace StarDentApi.Repositories.Concrete
{
    public class AccesstokenRepository : Repository<AccesstokenEntity>, IAccesstokenRepository
    {
        public AccesstokenRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
