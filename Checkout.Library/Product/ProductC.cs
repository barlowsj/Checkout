namespace Checkout.Library.Product
{
    public class ProductC : ProductBase, IProduct
    {
        public ProductC()
        {
            PopulateProductValues("ProductCUnitPrice", "ProductCPromQuant", "ProductCPromPrice");
        }


        public override double OrderTotal { get { return OrderPrice(); } }

    }
}
