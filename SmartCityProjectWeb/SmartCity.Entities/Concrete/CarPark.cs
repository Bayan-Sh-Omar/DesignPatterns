﻿using SmartCity.Core.Entities;

namespace SmartCity.Entities.Concrete
{
    public class CarPark : IEntity
    {
        public CarPark()
        {
            this.Company = new Company();
        }
        public int CarParkId { get; set; }
        public int? CarParkMax { get; set; }
        public Boolean CarParkDisabled { get; set; }
        public Boolean CarParkWashing { get; set; }
        public Boolean CarParkTire { get; set; }
        public int? CarParkNull { get; set; }
        public int? CompanyId { get; set; }
        public Boolean CarParkMarket { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
