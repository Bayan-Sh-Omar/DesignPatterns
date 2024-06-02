
namespace SmartCity.Business.SmartTrafficManagement
{
    internal class TrafficClient
    {
        public static void Apply()
        {
            TrafficData trafficData = new TrafficData();
            TrafficLight trafficLight1 = new TrafficLight();
            TrafficLight trafficLight2 = new TrafficLight();

            trafficData.RegisterObserver(trafficLight1);
            trafficData.RegisterObserver(trafficLight2);

            Console.WriteLine("Setting traffic condition to Heavy Traffic:");
            trafficData.SetTrafficCondition("Heavy Traffic");

            Console.WriteLine("Setting traffic condition to Moderate Traffic:");
            trafficData.SetTrafficCondition("Moderate Traffic");

            Console.WriteLine("Setting traffic condition to Light Traffic:");
            trafficData.SetTrafficCondition("Light Traffic");
        }

    }
}
