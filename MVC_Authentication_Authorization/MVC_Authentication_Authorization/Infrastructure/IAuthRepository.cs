using MVC_Authentication_Authorization.Models;

namespace MVC_Authentication_Authorization.Infrastructure
{
    public interface IAuthRepository
    {
        UserDetail AuthenticateUser(UserDetailViewModel usr);
    }
}
