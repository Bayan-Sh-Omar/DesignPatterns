namespace SmartCity.Business.SmartBuilding
{
    internal class BuildingEventsClient
    {
        public static void Apply()
        {
            // Create event handlers
            IEventHandler securityHandler = new SecurityEventHandler();
            IEventHandler fireHandler = new FireEventHandler();
            IEventHandler maintenanceHandler = new MaintenanceEventHandler();

            // Set up chain of responsibility
            securityHandler.SetNextHandler(fireHandler);
            fireHandler.SetNextHandler(maintenanceHandler);

            // Create events
            var events = new[]
            {
                new BuildingEvent("Security", "Unauthorized access detected."),
                new BuildingEvent("Fire", "Smoke detected in the kitchen."),
                new BuildingEvent("Maintenance", "Elevator needs maintenance."),
            };

            // Process events
            foreach (var ev in events)
            {
                securityHandler.HandleEvent(ev);
            }
        }
    }
}
