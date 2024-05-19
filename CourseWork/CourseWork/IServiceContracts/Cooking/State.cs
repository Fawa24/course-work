namespace CourseWork.IServiceContracts.Cooking
{
    public abstract class State
    {
        public State NextState;
        public string StateName;
    }
}
