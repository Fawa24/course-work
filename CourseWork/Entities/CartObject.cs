using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CartObject
    {
        public Guid CartObjectId { get; set; }
        public string RestorauntType { get; set; } = null!;
        public string DishType { get; set; } = null!;
        public Dictionary<string, int> Ingradients { get; set; } = null!;
    }
}
