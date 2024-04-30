using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IServiceContracts.DTO
{
    public class CartResponce
    {
        public Guid CartObjectId { get; set; }
        public string RestorauntType { get; set; } = null!;
        public string DishType { get; set; } = null!;
        public Dictionary<string, int> Ingradients { get; set; } = null!;
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
                Ingradients = obj.Ingradients
            };
        }
    }
}
