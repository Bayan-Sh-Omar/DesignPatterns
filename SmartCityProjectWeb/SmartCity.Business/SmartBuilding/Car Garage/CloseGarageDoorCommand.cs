

namespace SmartCity.Business.SmartBuilding
{
    public class CloseGarageDoorCommand : ICommand
    {
        private GarageDoor _garageDoor;

        public CloseGarageDoorCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Close();
        }

        public void Undo()
        {
            _garageDoor.Open();
        }
    }
}
