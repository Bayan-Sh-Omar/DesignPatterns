
namespace SmartCity.Business.SmartBuilding
{
    public class SecuritySystemDecorator : BuildingDecorator
    {
        public SecuritySystemDecorator(IBuildingComponent buildingComponent) : base(buildingComponent) 
        {
        }

        public override string Describe()
        {
            return _buildingComponent.Describe() + ", with Smart Security System";
        }
    }
}

