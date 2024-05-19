namespace CourseWork.IServiceContracts.Cooking
{
    public class OrderStateManager
    {
        private State state;

        public OrderStateManager()
        {
            state = null;
        }

        public async Task Cook()
        {
            state = new PreparingOrderState();
            while (state.NextState != null)
            {
                await Task.Delay(10000);
                state = state.NextState;
            }
        }

        public string GetState()
        {
            if (state != null)
            {
                return state.StateName;
            }
            else return "No orders in progres right now.";
        }

        public void ResetState()
        {
            state = null;
        }

    }
}
