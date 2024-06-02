

namespace SmartCity.Business.SmartBuilding
{
    public class HeatingSystemDecorator : BuildingDecorator
    {
        public HeatingSystemDecorator(IBuildingComponent buildingComponent) : base(buildingComponent)
        {
        }

        public override string Describe()
        {
            return _buildingComponent.Describe() + ", with Smart Heating System";
        }
    }
}


