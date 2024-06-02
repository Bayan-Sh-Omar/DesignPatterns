
namespace SmartCity.Business.SmartTrafficManagement
{
    public class TrafficData : ITrafficSubject
    {
        private List<ITrafficObserver> observers;
        private string trafficCondition;

        public TrafficData()
        {
            observers = new List<ITrafficObserver>();
        }

        public void RegisterObserver(ITrafficObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(ITrafficObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(trafficCondition);
            }
        }

        public void SetTrafficCondition(string condition)
        {
            trafficCondition = condition;
            NotifyObservers();
        }
    }
}
