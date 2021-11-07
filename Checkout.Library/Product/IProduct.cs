namespace Checkout.Library.Product
{
    public interface IProduct
    {
        int Quantity { get; set; }
        int UnitPrice { get; }
        int PromotionQuantity { get; }
        int PromotionPrice { get; }
    }
}
