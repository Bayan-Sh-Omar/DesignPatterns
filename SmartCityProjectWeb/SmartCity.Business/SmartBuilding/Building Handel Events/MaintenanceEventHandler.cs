
namespace SmartCity.Business.SmartBuilding
{
    public class MaintenanceEventHandler : IEventHandler
    {
        private IEventHandler _nextHandler;

        public void SetNextHandler(IEventHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleEvent(BuildingEvent bEvent)
        {
            if (bEvent.Type == "Maintenance")
            {
                Console.WriteLine("Handling maintenance event: " + bEvent.Description);
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleEvent(bEvent);
            }
        }
    }
}
