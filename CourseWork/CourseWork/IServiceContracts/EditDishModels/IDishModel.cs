namespace CourseWork.Models.EditDishModels
{
    public interface IDishModel
    {
        IRestoraunt _restoraunt { get; set; }

        void GetIngradients();
    }
}
