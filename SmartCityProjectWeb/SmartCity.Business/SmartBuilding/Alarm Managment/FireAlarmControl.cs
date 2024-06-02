
namespace SmartCity.Business.SmartBuilding
{
    public class FireAlarmControl : IAlarmControl
    {
        private INotification _notification;

        public FireAlarmControl(INotification notification)
        {
            _notification = notification;
        }

        public void Activate()
        {
            Console.WriteLine("Fire alarm is activated.");
        }

        public void Deactivate()
        {
            Console.WriteLine("Fire alarm is deactivated.");
        }

        public void Notify()
        {
            _notification.Send();
        }
    }
}
