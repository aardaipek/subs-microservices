using User.API.Models;

namespace User.API.Infrastructure
{
    public interface IUserService
    {
        UserDTO GetUserInfoById(int id);
    }
}