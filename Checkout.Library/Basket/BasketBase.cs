using Checkout.Library.Product;
using System.Collections.Generic;


namespace Checkout.Library.Basket
{
    public abstract class BasketBase
    {
        internal List<IProduct> Items { get; set; } = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            if (product.Quantity > 0)
                Items.Add(product);
        }

        public abstract decimal OrderTotal();
        internal abstract decimal Promotion(List<IProduct> products);
    }
}
