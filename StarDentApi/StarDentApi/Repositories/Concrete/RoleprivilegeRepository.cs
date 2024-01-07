using StarDentApi.Entities;
using StarDentApi.Repositories.Abstract;

namespace StarDentApi.Repositories.Concrete
{
    public class RoleprivilegeRepository : Repository<RoleprivilegeEntity> , IRoleprivilegeRepository
    {
        public RoleprivilegeRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
