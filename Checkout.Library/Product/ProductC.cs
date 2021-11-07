namespace Checkout.Library.Product
{
    public class ProductC : ProductBase, IProduct
    {
        public ProductC()
        {
            UnitPrice = int.Parse(Config.GetSection("ProductCUnitPrice").Value);
            PromotionQuantity = int.Parse(Config.GetSection("ProductCPromQuant").Value);
            PromotionPrice = int.Parse(Config.GetSection("ProductCPromPrice").Value);
        }


        public override int UnitPrice { get; }
        public override int PromotionQuantity { get; }
        public override int PromotionPrice { get; }
        public override double OrderTotal { get { return OrderPrice(); } }

    }
}
