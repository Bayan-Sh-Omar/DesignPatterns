

namespace SmartCity.Business.SmartBuilding
{
    public class FireEventHandler : IEventHandler
    {
        private IEventHandler _nextHandler;

        public void SetNextHandler(IEventHandler handler)
        {
            _nextHandler = handler;
        }

        public void HandleEvent(BuildingEvent bEvent)
        {
            if (bEvent.Type == "Fire")
            {
                Console.WriteLine("Handling fire event: " + bEvent.Description);
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleEvent(bEvent);
            }
        }
    }
}
