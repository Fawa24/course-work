namespace Entities
{
    public class CartObject : ICartObjectPrototype
    {
        public Guid CartObjectId { get; set; }
        public string RestorauntType { get; set; } = null!;
        public string DishType { get; set; } = null!;
        public Dictionary<string, int> Ingradients { get; set; } = null!;
        public int BasePrice { get; set; }

        public ICartObjectPrototype Copy()
        {
            Dictionary<string, int> copyIngradients = new Dictionary<string, int>();
            
            foreach (KeyValuePair<string, int> kvp in Ingradients)
            {
                copyIngradients.Add(kvp.Key, kvp.Value);
            }

            return new CartObject()
            {
                CartObjectId = Guid.NewGuid(),
                RestorauntType = RestorauntType,
                DishType = DishType,
                Ingradients = copyIngradients,
                BasePrice = BasePrice
            };
        }
    }
}
