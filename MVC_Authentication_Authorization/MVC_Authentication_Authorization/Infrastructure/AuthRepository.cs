using MVC_Authentication_Authorization.Models;

namespace MVC_Authentication_Authorization.Infrastructure
{
    public class AuthRepository : IAuthRepository
    {
        UserAuthConext _context = new UserAuthConext();
        public UserDetail AuthenticateUser(UserDetailViewModel usr)
        {
            UserDetail usrDetail = new UserDetail();

            usrDetail = _context.UserDetails.FirstOrDefault(u => u.UserID == usr.UserID && u.Password == usr.Password);

            return usrDetail;
        }

    }
}
