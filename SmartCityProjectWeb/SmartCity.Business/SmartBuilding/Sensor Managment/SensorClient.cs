
namespace SmartCity.Business.SmartBuilding
{
    public class SensorClient
    {
        public static void Apply ()
        {
            // Factory Pattern
            SensorFactory sensorFactory = new SensorFactory();
            ISensor tempSensor = sensorFactory.CreateSensor("Temperature");
            ISensor motionSensor = sensorFactory.CreateSensor("Motion");

            tempSensor.ReadData();
            motionSensor.ReadData();
        }
    }
}
