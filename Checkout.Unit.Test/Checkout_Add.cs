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

        [Fact]
        public void GivenABasketWhenAddingProductAOfOneQuantityThenReturn10()
        {
            var expectedResult = 10;
            basket.AddProduct(new ProductA { Quantity = 1 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingProductBOfOneQuantityThenReturn15()
        {
            var expectedResult = 15;
            basket.AddProduct(new ProductB { Quantity = 1 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingProductCOfOneQuantityThenReturn40()
        {
            var expectedResult = 40;
            basket.AddProduct(new ProductC { Quantity = 1 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingProductDOfOneQuantityThenReturn55()
        {
            var expectedResult = 55;
            basket.AddProduct(new ProductD { Quantity = 1 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingProductABCDOfOneQuantityThenReturn()
        {
            var expectedResult = 120;
            basket.AddProduct(new ProductA { Quantity = 1 });
            basket.AddProduct(new ProductB { Quantity = 1 });
            basket.AddProduct(new ProductC { Quantity = 1 });
            basket.AddProduct(new ProductD { Quantity = 1 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingThreeLotsOfProductBThenReturnPromotionalValue()
        {
            var expectedResult = 40;
            basket.AddProduct(new ProductB { Quantity = 3 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }


        [Fact]
        public void GivenABasketWhenAddingThreeLotsOfProductBPlusFourIndividualLotsOfProductBThenReturnPromotionalValue()
        {
            var expectedResult = 95;
            basket.AddProduct(new ProductB { Quantity = 3 });
            basket.AddProduct(new ProductB { Quantity = 1 });
            basket.AddProduct(new ProductB { Quantity = 1 });
            basket.AddProduct(new ProductB { Quantity = 1 });
            basket.AddProduct(new ProductB { Quantity = 1 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingOneLotofProductAThreeLotsOfProductBAndOneLotOfProductCThenReturn90()
        {
            var expectedResult = 90;
            basket.AddProduct(new ProductA { Quantity = 1 });
            basket.AddProduct(new ProductB { Quantity = 3 });
            basket.AddProduct(new ProductC { Quantity = 1 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingTwoLotsOfProductDThenReturnPromotionalValue()
        {
            var expectedResult = 82.50M;
            basket.AddProduct(new ProductD { Quantity = 2 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingTwoLotsOfProductDPlusTwoMoreIndividualLotsOfProductDThenReturnPromotionalValue()
        {
            var expectedResult = 192.50M;
            basket.AddProduct(new ProductD { Quantity = 2 });
            basket.AddProduct(new ProductD { Quantity = 1 });
            basket.AddProduct(new ProductD { Quantity = 1 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingTwoTimesTwoLotsOfProductDThenReturnPromotionalValue()
        {
            var expectedResult = 165;
            basket.AddProduct(new ProductD { Quantity = 2 });
            basket.AddProduct(new ProductD { Quantity = 2 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingTwoLotsOfProductDPlusOneLotofProductAThenReturnResult()
        {
            var expectedResult = 92.50M;
            basket.AddProduct(new ProductD { Quantity = 2 });
            basket.AddProduct(new ProductA { Quantity = 1 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingTwoLotsOfProductDPlusThreeLotofProductBThenReturnResult()
        {
            var expectedResult = 122.50M;
            basket.AddProduct(new ProductD { Quantity = 2 });
            basket.AddProduct(new ProductB { Quantity = 3 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingThreeLotsOfProductAOfOneQuantityThenReturn30()
        {
            var expectedResult = 30;
            basket.AddProduct(new ProductA { Quantity = 3 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

        [Fact]
        public void GivenABasketWhenAddingThreeLotsOfProductCThenReturn120()
        {
            var expectedResult = 120;
            basket.AddProduct(new ProductC { Quantity = 3 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }


        [Fact]
        public void GivenABasketWhenAddingOneLotofProductAThreeLotsOfProductBAndProductDThenReturn120()
        {
            var expectedResult = 187.50M;
            basket.AddProduct(new ProductA { Quantity = 1 });
            basket.AddProduct(new ProductB { Quantity = 3 });
            basket.AddProduct(new ProductD { Quantity = 3 });

            Assert.Equal(expectedResult, basket.OrderTotal());
        }

    }
}
