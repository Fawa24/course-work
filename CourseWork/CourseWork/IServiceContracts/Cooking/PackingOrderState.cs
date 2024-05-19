namespace CourseWork.IServiceContracts.Cooking
{
    public class PackingOrderState : State
    {
        public PackingOrderState()
        {
            this.NextState = new ReadyOrderState();
            this.StateName = "Packing the order...";
        }
    }
}
