
namespace SmartCity.Business.SmartBuilding
{
    public interface IEventHandler
    {
        void SetNextHandler(IEventHandler handler);
        void HandleEvent(BuildingEvent bEvent);

    }
}
