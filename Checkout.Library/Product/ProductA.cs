namespace Checkout.Library.Product
{
    public class ProductA : ProductBase, IProduct
    {
        public ProductA()
        {
            PopulateProductValues("ProductAUnitPrice", "ProductAPromQuant", "ProductAPromPrice");
        }

    }
}

