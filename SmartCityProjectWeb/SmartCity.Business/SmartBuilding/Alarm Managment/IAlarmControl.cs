
namespace SmartCity.Business.SmartBuilding
{
    public interface IAlarmControl
    {
        void Activate();
        void Deactivate();
        void Notify();
    }
}
