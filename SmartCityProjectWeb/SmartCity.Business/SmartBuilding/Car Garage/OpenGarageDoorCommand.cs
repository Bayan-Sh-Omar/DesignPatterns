
namespace SmartCity.Business.SmartBuilding
{
    public class OpenGarageDoorCommand : ICommand
    {
        private GarageDoor _garageDoor;

        public OpenGarageDoorCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Open();
        }

        public void Undo()
        {
            _garageDoor.Close();
        }
    }
}
