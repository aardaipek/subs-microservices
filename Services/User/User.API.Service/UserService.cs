using User.API.Infrastructure;
using User.API.Models;

namespace User.API.Service
{
    public class UserService : IUserService
    {
        public UserDTO GetUserInfoById(int id)
        {
            return new UserDTO()
            {
                Id = id,
                FirstName = "Arda",
                LastName = "Ipek"
            };
        }
    }
}