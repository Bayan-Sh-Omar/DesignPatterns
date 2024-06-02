
namespace SmartCity.Business.SmartBuilding
{
    public class LightingSystemDecorator : BuildingDecorator
    {
        public LightingSystemDecorator(IBuildingComponent buildingComponent) : base(buildingComponent)
        { 
        }

        public override string Describe()
        {
            return _buildingComponent.Describe() + ", with Smart Lighting System";
        }
    }
}


