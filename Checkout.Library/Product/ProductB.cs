namespace Checkout.Library.Product
{
    public class ProductB : ProductBase, IProduct
    {
        public ProductB()
        {
            UnitPrice = int.Parse(Config.GetSection("ProductBUnitPrice").Value);
            PromotionQuantity = int.Parse(Config.GetSection("ProductBPromQuant").Value);
            PromotionPrice = int.Parse(Config.GetSection("ProductBPromPrice").Value);
        }

        public override int UnitPrice { get; }
        public override int PromotionQuantity { get; }
        public override int PromotionPrice { get; }
        public override double OrderTotal { get { return OrderPrice(); } }

    }
}
