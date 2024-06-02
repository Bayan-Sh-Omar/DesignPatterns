
namespace SmartCity.Business.SmartBuilding
{
    public class CentralControlUnit
    {
        private static CentralControlUnit _instance;

        private CentralControlUnit() { }

        public static CentralControlUnit Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CentralControlUnit();
                }
                return _instance;
            }
        }

        public void Control(string message)
        {
            Console.WriteLine($"Central Control Unit: {message}");
        }
    }
}
