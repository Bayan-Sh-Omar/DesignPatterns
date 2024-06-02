﻿using SmartCity.Core.Entities;

namespace SmartCity.Entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? UserYears { get; set; }
        public bool? UserGender { get; set; }
        public string UserPassword { get; set; }
        public string UserPhone { get; set; }
        public string UserMail { get; set; }
        public string UserCity { get; set; }
        public string UserDistrict { get; set; }
        public string UserAdress { get; set; }
        public int? UserType { get; set; }
        public string Token { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
