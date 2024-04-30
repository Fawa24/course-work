using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface ICartObjectPrototype
    {
        /// <summary>
        /// Copies the cart object
        /// </summary>
        /// <returns>Copy of the cart object</returns>
        ICartObjectPrototype Copy();
    }
}
