namespace Entities
{
    public class CartObject
    {
        public Guid CartObjectId { get; set; }
        public string RestorauntType { get; set; } = null!;
        public string DishType { get; set; } = null!;
        public Dictionary<string, int> Ingradients { get; set; } = null!;
        public int BasePrice { get; set; }
    }
}
