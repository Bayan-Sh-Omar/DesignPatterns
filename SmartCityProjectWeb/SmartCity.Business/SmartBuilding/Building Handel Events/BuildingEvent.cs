
namespace SmartCity.Business.SmartBuilding
{
    public class BuildingEvent
    {
        public string Type { get; set; }
        public string Description { get; set; }

        public BuildingEvent(string type, string description)
        {
            Type = type;
            Description = description;
        }
    }
}
