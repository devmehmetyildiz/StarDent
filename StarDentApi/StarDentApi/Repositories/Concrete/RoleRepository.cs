using StarDentApi.Entities;
using StarDentApi.Repositories.Abstract;

namespace StarDentApi.Repositories.Concrete
{
    public class RoleRepository : Repository<RoleEntity> ,IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
