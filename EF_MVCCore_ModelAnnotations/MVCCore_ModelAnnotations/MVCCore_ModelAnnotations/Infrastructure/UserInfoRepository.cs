using MVCCore_ModelAnnotations.Models;

namespace MVCCore_ModelAnnotations.Infrastructure
{
    public class UserInfoRepository : IUserInfoRepository
    {
        public string SaveUserDetail(UserDetail usr)
        {
            string msg = String.Empty;

            // Connect to DB to save

            return msg;
        }
    }
}
