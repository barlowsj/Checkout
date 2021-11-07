namespace Checkout.Library.Product
{
    public class ProductD : ProductBase, IProduct
    {
        public ProductD()
        {
            PopulateProductValues("ProductDUnitPrice", "ProductDPromQuant", "ProductDPromPrice");
        }

        public override double OrderTotal { get { return OrderPrice(); } }

    }
}
