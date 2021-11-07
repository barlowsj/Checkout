using System.Linq;

namespace Checkout.Library.Basket
{
    public class BasketWithProductBPromotion : BasketBase, IBasket
    {
        public override double OrderTotal()
        {
            double orderTotal = 0;

            orderTotal = Items.Select(s => s.OrderTotal).Sum();

            return orderTotal;
        }
    }
}
