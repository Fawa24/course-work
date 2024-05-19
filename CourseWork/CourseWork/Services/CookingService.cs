using CourseWork.IServiceContracts;
using CourseWork.IServiceContracts.Cooking;

namespace CourseWork.Services
{
    public class CookingService : ICookingService
    {
        private readonly OrderStateManager _stateManager;

        public CookingService()
        {
            _stateManager = new OrderStateManager();
        }

        public Task Cook()
        {
            return Task.Run(_stateManager.Cook);
        }

        public string GetState()
        {
            return _stateManager.GetState();
        }

        public void StopCooking()
        {
            _stateManager.ResetState();
        }
    }
}
