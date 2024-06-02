using System.Collections.Generic;
using SmartCity.Business.Abstract;
using SmartCity.DataAccess.Abstract;
using SmartCity.Entities.Concrete;

namespace SmartCity.Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        private IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public List<Reservation> GetAll()
        {
            return _reservationDal.GetList();
        }
        public Reservation Get(int entityId)
        {
            return _reservationDal.Get();
        }

        public void Add(Reservation entity)
        {
            _reservationDal.Add(entity);
        }

        public void Delete(Reservation entity)
        {
            _reservationDal.Delete(entity);
        }

        public void Update(Reservation entity)
        {
            _reservationDal.Update(entity);
        }
    }
}