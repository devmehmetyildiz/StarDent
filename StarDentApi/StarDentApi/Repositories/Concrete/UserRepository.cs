using StarDentApi.Entities;
using StarDentApi.Repositories.Abstract;

namespace StarDentApi.Repositories.Concrete
{
    public class UserRepository: Repository<UserEntity> , IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) 
        {
            
        }
    }
}
