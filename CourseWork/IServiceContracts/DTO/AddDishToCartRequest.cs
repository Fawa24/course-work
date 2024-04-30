using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IServiceContracts.DTO
{
    public class AddDishToCartRequest
    {
        public string RestorauntType { get; set; }
        public string DishType { get; set; }
        public Dictionary<string, int> Ingradients { get; set; }

        public AddDishToCartRequest(string restorauntType, string dishType, Dictionary<string, int> ingradients) 
        { 
            RestorauntType = restorauntType;
            DishType = dishType;
            Ingradients = ingradients;
        }

        public CartObject ToCartObject()
        {
            return new CartObject()
            {
                CartObjectId = Guid.NewGuid(),
                RestorauntType = RestorauntType,
                DishType = DishType,
                Ingradients = Ingradients
            };
        }
    }

    public static class DictionaryExtension
    { 
        public static AddDishToCartRequest ToAddDishToCartRequest(this Dictionary<string, string> dictionary)
        {
            string restorauntType = dictionary["RestorauntType"];
            dictionary.Remove("RestorauntType");
            string dishType = dictionary["DishType"];
            dictionary.Remove("DishType");

            Dictionary<string, int> ingradients = new Dictionary<string, int>();
            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                string key = pair.Key;
                int value = Convert.ToInt16(pair.Value);
                ingradients.Add(key, value);
            }

            return new AddDishToCartRequest(restorauntType, dishType, ingradients);
        }
    }
}
