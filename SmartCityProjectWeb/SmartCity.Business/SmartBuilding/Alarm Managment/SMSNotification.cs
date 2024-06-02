
namespace SmartCity.Business.SmartBuilding
{
    public class SMSNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending SMS notification.");
        }
    }
}
