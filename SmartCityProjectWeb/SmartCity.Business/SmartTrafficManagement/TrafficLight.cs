
namespace SmartCity.Business.SmartTrafficManagement
{
    public class TrafficLight : ITrafficObserver
    {
        private string lightColor;

        public void Update(string trafficCondition)
        {
            if (trafficCondition == "Heavy Traffic")
            {
                lightColor = "Red";
            }
            else if (trafficCondition == "Moderate Traffic")
            {
                lightColor = "Yellow";
            }
            else
            {
                lightColor = "Green";
            }
            Console.WriteLine($"Traffic light changed to {lightColor} " +
                $"due to {trafficCondition}");
        }
    }
}
