namespace CourseWork.IServiceContracts.Cooking
{
    public class CookingOrderState : State
    {
        public CookingOrderState()
        {
            this.NextState = new PackingOrderState();
            this.StateName = "Cooking...";
        }
    }
}
