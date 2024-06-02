
namespace SmartCity.Business.SmartBuilding
{
    public class EmailNotification : INotification
    {
        public void Send()
        {
            Console.WriteLine("Sending Email notification.");
        }
    }
}

