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
