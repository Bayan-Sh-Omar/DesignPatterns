using SmartCity.Core.Entities;

namespace SmartCity.Entities.Concrete
{
    public class Request:IEntity
    {
        public int RequestId { get; set; }
        public DateTime? RequestTime { get; set; }
        public string RequestAmaunt { get; set; }
        public bool? RequestActive { get; set; }
        public int? MedicineId { get; set; }
        public int? UserId { get; set; }

        public virtual User User { get; set; }
    }
}
