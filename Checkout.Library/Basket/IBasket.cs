using Checkout.Library.Product;

namespace Checkout.Library.Basket
{
    public interface IBasket
    {
        void AddProduct(IProduct product);

        decimal OrderTotal();
    }
}
