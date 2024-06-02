
namespace SmartCity.Business.SmartBuilding
{
    internal class CarGarageClient
    {
        public static void Apply()
        {
            var garageDoor = new GarageDoor();

            // Command Pattern
            var doorOpenCommand = new OpenGarageDoorCommand(garageDoor);
            var doorCloseCommand = new CloseGarageDoorCommand(garageDoor);

            var remote = new RemoteControl();

            // Controlling garage door
            remote.SetCommand(doorOpenCommand);
            remote.PressButton();
            remote.PressUndo();

            remote.SetCommand(doorCloseCommand);
            remote.PressButton();
            remote.PressUndo();

        }
    }
}
