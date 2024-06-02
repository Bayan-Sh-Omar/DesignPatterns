
namespace SmartCity.Business.SmartBuilding
{
    public class SecurityEventHandler : IEventHandler
    {
        private IEventHandler _nextHandler;

        public void SetNextHandler(IEventHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleEvent(BuildingEvent bEvent)
        {
            if (bEvent.Type == "Security")
            {
                Console.WriteLine("Handling security event: " + bEvent.Description);
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleEvent(bEvent);
            }
        }

    }
}


