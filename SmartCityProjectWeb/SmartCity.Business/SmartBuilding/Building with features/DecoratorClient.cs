

namespace SmartCity.Business.SmartBuilding
{
    internal class DecoratorClient
    {
        public static void Apply()
        {
            IBuildingComponent basicBuilding = new BasicBuilding();
            Console.WriteLine(basicBuilding.Describe());

            IBuildingComponent buildingWithLighting = new LightingSystemDecorator(basicBuilding);
            Console.WriteLine(buildingWithLighting.Describe());

            IBuildingComponent buildingWithSecurity = new SecuritySystemDecorator(buildingWithLighting);
            Console.WriteLine(buildingWithSecurity.Describe());

            IBuildingComponent fullyFeaturedBuilding = new HeatingSystemDecorator(buildingWithSecurity);
            Console.WriteLine(fullyFeaturedBuilding.Describe());
        }
    }
}


