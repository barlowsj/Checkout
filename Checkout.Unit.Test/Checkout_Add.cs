using Checkout.Library.Basket;
using Checkout.Library.Product;
using System;
using Xunit;

namespace Checkout.Unit.Test
{
    public class Checkout_Add
    {
        private IBasket basket = new BasketWithProductBPromotion();

        [Fact]
        public void GivenABasketWhenAddingAProductOfZeroQuantityThenReturnZero()
        {
            basket.AddProduct(new ProductA { Quantity = 0 });

            Assert.True(basket.OrderTotal() == 0);
        }
    }
}
