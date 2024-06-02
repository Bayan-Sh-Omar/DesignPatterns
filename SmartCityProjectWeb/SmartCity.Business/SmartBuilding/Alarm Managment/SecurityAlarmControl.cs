
namespace SmartCity.Business.SmartBuilding
{
    public class SecurityAlarmControl : IAlarmControl
    {
        private INotification _notification;

        public SecurityAlarmControl(INotification notification)
        {
            _notification = notification;
        }

        public void Activate()
        {
            Console.WriteLine("Security alarm is activated.");
        }

        public void Deactivate()
        {
            Console.WriteLine("Security alarm is deactivated.");
        }

        public void Notify()
        {
            _notification.Send();
        }
    }
}
