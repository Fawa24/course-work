namespace CourseWork.IServiceContracts.Cooking
{
    public class PreparingOrderState : State
    {
        public PreparingOrderState()
        {
            this.NextState = new CookingOrderState();
            this.StateName = "Preparing ingradients...";
        }
    }
}
