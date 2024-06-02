using SmartCity.Entities.Concrete;

namespace SmartCity.Business.Abstract
{
    public interface IUserService : IServices<User>
    {
        User LoginControlGet(string userName, string password);
    }
}