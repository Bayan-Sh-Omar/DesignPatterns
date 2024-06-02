using SmartCity.Core.DataAccess.EntityFramework;
using SmartCity.DataAccess.Abstract;
using SmartCity.Entities.Concrete;

namespace SmartCity.DataAccess.Concrete.EntityFramework
{
    public class CarParkDal : EfEntityRepositoryBase<CarPark, SmartCityContext>, ICarParkDal
    {
    }
}
