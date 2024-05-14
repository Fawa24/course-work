namespace CourseWork.Models.EditDishModels
{
    public class Lasagna : IDishModel
    {
        public IRestoraunt _restoraunt { get; set; }

        public string CheeseName { get; set; }
        public string SauseName { get; set; }
        public string FillingName { get; set; }

        public Lasagna(IRestoraunt restoraunt)
        {
            _restoraunt = restoraunt;
            GetIngradients();
        }
            
        public void GetIngradients()
        {
            CheeseName = _restoraunt.CheeseName;
            SauseName = _restoraunt.SauceName;
            FillingName = _restoraunt.FillingName;
        }
    }
}
