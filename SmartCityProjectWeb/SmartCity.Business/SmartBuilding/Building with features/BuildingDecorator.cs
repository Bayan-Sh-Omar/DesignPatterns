
namespace SmartCity.Business.SmartBuilding
{
    public abstract class BuildingDecorator : IBuildingComponent
    {
        protected IBuildingComponent _buildingComponent;

        public BuildingDecorator(IBuildingComponent buildingComponent)
        {
            _buildingComponent = buildingComponent;
        }

        public virtual string Describe()
        {
            return _buildingComponent.Describe();
        }
    }
}

