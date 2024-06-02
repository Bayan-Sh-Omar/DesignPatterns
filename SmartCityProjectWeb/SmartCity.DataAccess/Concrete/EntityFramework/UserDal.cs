using SmartCity.Core.DataAccess.EntityFramework;
using SmartCity.DataAccess.Abstract;
using SmartCity.Entities.Concrete;

namespace SmartCity.DataAccess.Concrete.EntityFramework
{
    public class UserDal : EfEntityRepositoryBase<User, SmartCityContext>, IUserDal
    {
    }
}
