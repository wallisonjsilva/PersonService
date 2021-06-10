using PersonService.Data.VO;
using PersonService.Model;

namespace PersonService.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
        
        User ValidateCredentials(string userName);

        bool RevokeToken(string userName);

        User RefreshUserInfo(User user);
    }
}