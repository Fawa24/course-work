using CourseWork.Models.EditDishModels;

namespace CourseWork.Models
{
    public class EditDishModel
    {
        public IDishModel DishModel { get; set; }
        public string RestorauntType { get; set; }
        public string DishType { get; set; }

        public EditDishModel (IDishModel dishModel, string restorauntType, string dishType)
        {
            DishModel = dishModel;
            RestorauntType = restorauntType;
            DishType = dishType;
        }
    }
}
