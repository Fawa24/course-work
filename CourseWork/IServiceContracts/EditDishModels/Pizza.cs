namespace CourseWork.Models.EditDishModels
{
    public class Pizza : IDishModel
    {
        public IRestoraunt _restoraunt { get; set; }

        public string CheeseName { get; set; }
        public string SauseName { get; set; }

        public int CheeseAmount { get; set; }
        public int SauseAmount { get; set; }

        public Pizza(IRestoraunt restoraunt) 
        {
            _restoraunt = restoraunt;
        }

        public void GetIngradients()
        {
            CheeseName = _restoraunt.CheeseName;
            SauseName = _restoraunt.SauceName;
        }
    }
}
