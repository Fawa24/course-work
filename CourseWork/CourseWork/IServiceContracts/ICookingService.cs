namespace CourseWork.IServiceContracts
{
    public interface ICookingService
    {
        string GetState();
        Task Cook();
        void StopCooking();
    }
}
