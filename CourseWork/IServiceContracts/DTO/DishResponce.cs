namespace IServiceContracts.DTO
{
    public partial class DishResponce
    {
        public Guid DishId { get; set; }

        public string DishName { get; set; } = null!;

        public string DishType { get; set; } = null!;

        public string RestaurantType { get; set; } = null!;

        public int DishPrice { get; set; }
    }
}
