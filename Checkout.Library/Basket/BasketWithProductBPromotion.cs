using Checkout.Library.Product;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkout.Library.Basket
{
    public class BasketWithProductBPromotion : BasketBase, IBasket
    {
        public override double OrderTotal()
        {
            var promotionTotal = Promotion(Items.Where(s => s.GetType() == typeof(ProductB)).ToList());

            return promotionTotal + Items.Where(s => s.GetType() != typeof(ProductB)).Select(s => s.OrderTotal).Sum();
        }

        internal override double Promotion(List<IProduct> products)
        {

            if (products.Count == 0)
                return 0;

            var promotionQuantity = products.Select(s => s.PromotionQuantity).FirstOrDefault();
            var promotionPrice = products.Select(s => s.PromotionPrice).FirstOrDefault();
            var totalProductsOrdered = products.Select(s => s.Quantity).Sum();

            var qualifyingProductTotal = totalProductsOrdered / promotionQuantity;
            var remainingProductsAtUnitPrice = totalProductsOrdered % promotionQuantity;

            var UnitPriceProducts = new List<IProduct> { new ProductB { Quantity = Convert.ToInt32(remainingProductsAtUnitPrice) } };

            var normalnitPriceTotal = UnitPriceProducts.Select(s => s.OrderTotal).Sum();

            var promotionalItemCount = qualifyingProductTotal * promotionPrice;

            return normalnitPriceTotal + promotionalItemCount;

        }

    }
}
