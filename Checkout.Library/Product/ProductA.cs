namespace Checkout.Library.Product
{
    public class ProductA : ProductBase, IProduct
    {
        public ProductA()
        {
            UnitPrice = int.Parse(Config.GetSection("ProductAUnitPrice").Value);
            PromotionQuantity = int.Parse(Config.GetSection("ProductAPromQuant").Value);
            PromotionPrice = int.Parse(Config.GetSection("ProductAPromPrice").Value);
        }

        public override int UnitPrice { get; }
        public override int PromotionQuantity { get; }
        public override int PromotionPrice { get; }
        public override double OrderTotal { get { return OrderPrice(); } }

    }
}

