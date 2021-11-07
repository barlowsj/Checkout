namespace Checkout.Library.Product
{
    public class ProductD : ProductBase, IProduct
    {
        public ProductD()
        {
            UnitPrice = int.Parse(Config.GetSection("ProductDUnitPrice").Value);
            PromotionQuantity = int.Parse(Config.GetSection("ProductDPromQuant").Value);
            PromotionPrice = int.Parse(Config.GetSection("ProductDPromPrice").Value);
        }

        public override int UnitPrice { get; }
        public override int PromotionQuantity { get; }

        public override int PromotionPrice { get; }
        public override double OrderTotal { get { return OrderPrice(); } }

    }
}
