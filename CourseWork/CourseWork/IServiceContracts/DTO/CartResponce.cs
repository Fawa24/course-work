using Entities;

namespace IServiceContracts.DTO
{
    public class CartResponce
    {
        public Guid CartObjectId { get; set; }
        public string RestorauntType { get; set; } = null!;
        public string DishType { get; set; } = null!;
        public Dictionary<string, int> Ingradients { get; set; } = null!;
        public int BasePrice { get; set; }

        public int CalculatePrice()
        {
            int price = BasePrice;
            foreach (KeyValuePair<string, int> kvp in Ingradients)
            {
                price = price + (kvp.Value - 1) * 3;
            }
            return price;
        }
    }

    public static class CartObjectExtension
    {
        public static CartResponce ToCartResponce(this CartObject obj)
        {
            return new CartResponce()
            {
                CartObjectId = obj.CartObjectId,
                RestorauntType = obj.RestorauntType,
                DishType = obj.DishType,
                Ingradients = obj.Ingradients,
                BasePrice = obj.BasePrice
            };
        }

        public static int CalculatePrice(this CartObject obj)
        {
            int price = obj.BasePrice;
            foreach (KeyValuePair<string, int> kvp in obj.Ingradients)
            {
                price = price + (kvp.Value - 1) * 3;
            }
            return price;
        }
    }
}
