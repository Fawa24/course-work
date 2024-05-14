namespace CourseWork.Models.EditDishModels
{
    public interface IDishModel
    {
        public IRestoraunt _restoraunt { get; set; }
        
        public abstract void GetIngradients();
    }
}
