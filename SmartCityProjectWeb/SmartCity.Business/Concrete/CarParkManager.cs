using System.Collections.Generic;
using SmartCity.Business.Abstract;
using SmartCity.DataAccess.Abstract;
using SmartCity.Entities.Concrete;

namespace SmartCity.Business.Concrete
{
    public class CarParkManager : ICarParkService
    {
        private ICarParkDal _carParkDal;
        public CarParkManager(ICarParkDal carParkDal)
        {
            _carParkDal = carParkDal;
        }
        public CarPark Get(int entityId)
        {
            return _carParkDal.Get(x => x.CarParkId == entityId);
        }

        public List<CarPark> GetAll()
        {
            return _carParkDal.GetIncludeList("Company");
        }

        public void Add(CarPark entity)
        {
            _carParkDal.Add(entity);
        }

        public void Delete(CarPark entity)
        {
            _carParkDal.Delete(entity);
        }

        public void Update(CarPark entity)
        {
            _carParkDal.Update(entity);
        }
    }
}