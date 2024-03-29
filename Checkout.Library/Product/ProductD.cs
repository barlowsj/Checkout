﻿namespace Checkout.Library.Product
{
    public class ProductD : ProductBase, IProduct
    {
        public ProductD()
        {
            PopulateProductValues("ProductDUnitPrice", "ProductDPromQuant", "ProductDPromPrice");
        }

        public override decimal Promotion()
        {
            var qualifyingProductTotal = Quantity / PromotionQuantity;
            var remainingProductsAtUnitPrice = Quantity % PromotionQuantity;

            var promotionPercentage = decimal.Parse(PromotionPrice.ToString()) / 100M;

            return ((qualifyingProductTotal * PromotionQuantity) * (UnitPrice - (UnitPrice * promotionPercentage))) + (remainingProductsAtUnitPrice * UnitPrice);
        }
    }
}
