

namespace SmartCity.Business.SmartBuilding
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}

