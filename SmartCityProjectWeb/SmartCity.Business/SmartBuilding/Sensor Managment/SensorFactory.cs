

namespace SmartCity.Business.SmartBuilding
{
    public class SensorFactory
    {
        public ISensor CreateSensor(string sensorType)
        {
            if (sensorType == "Temperature")
            {
                return new TemperatureSensor();
            }
            else if (sensorType == "Motion")
            {
                return new MotionSensor();
            }
            else
            {
                throw new ArgumentException("Invalid sensor type");
            }
        }
    }
}
