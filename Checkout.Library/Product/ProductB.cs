namespace Checkout.Library.Product
{
    public class ProductB : ProductBase, IProduct
    {
        public ProductB()
        {
            PopulateProductValues("ProductBUnitPrice", "ProductBPromQuant", "ProductBPromPrice");
        }

        public override double OrderTotal { get { return OrderPrice(); } }

    }
}
