

namespace SmartCity.Business.SmartTrafficManagement
{
    public interface ITrafficSubject
    {
        void RegisterObserver(ITrafficObserver observer);
        void RemoveObserver(ITrafficObserver observer);
        void NotifyObservers();
    }
}
