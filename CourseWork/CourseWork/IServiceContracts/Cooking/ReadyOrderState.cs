namespace CourseWork.IServiceContracts.Cooking
{
    public class ReadyOrderState : State
    {
        public ReadyOrderState()
        {
            NextState = null;
            this.StateName = "Order ready!";
        }
    }
}
