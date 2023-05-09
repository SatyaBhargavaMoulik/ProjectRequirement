using MVCCore_ModelAnnotations.Models;

namespace MVCCore_ModelAnnotations.Infrastructure
{
    public interface IUserInfoRepository
    {
        string SaveUserDetail(UserDetail usr);
    }
}
