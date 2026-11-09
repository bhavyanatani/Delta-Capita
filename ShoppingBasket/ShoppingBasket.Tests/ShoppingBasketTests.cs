
using System;
using System.Collections.Generic;
using Xunit;
using ShoppingBasket;

namespace ShoppingBasket.Tests
{
    public class ShoppingBasketTests
    {
        [Fact]
        public void OneApple_ShouldCost35()
        {
            var basket = new List<string> { "Apple" };

            int result = ShoppingBasketCalculator.CalculateTotal(basket);

            Assert.Equal(35, result);
        }

        [Fact]
        public void OneBanana_ShouldCost20()
        {
            var basket = new List<string> { "Banana" };

            int result = ShoppingBasketCalculator.CalculateTotal(basket);

            Assert.Equal(20, result);
        }

        [Fact]
        public void TwoApples_ShouldCost70()
        {
            var basket = new List<string> { "Apple", "Apple" };

            int result = ShoppingBasketCalculator.CalculateTotal(basket);

            Assert.Equal(70, result);
        }

        [Fact]
        public void TwoMelons_ShouldCost50()
        {
            var basket = new List<string> { "Melon", "Melon" };

            int result = ShoppingBasketCalculator.CalculateTotal(basket);

            Assert.Equal(50, result);
        }

        [Fact]
        public void ThreeMelons_ShouldCost100()
        {
            var basket = new List<string>
            {
                "Melon", "Melon", "Melon"
            };

            int result = ShoppingBasketCalculator.CalculateTotal(basket);

            Assert.Equal(100, result);
        }

        [Fact]
        public void ThreeLimes_ShouldCost30()
        {
            var basket = new List<string>
            {
                "Lime", "Lime", "Lime"
            };

            int result = ShoppingBasketCalculator.CalculateTotal(basket);

            Assert.Equal(30, result);
        }

        [Fact]
        public void FourLimes_ShouldCost45()
        {
            var basket = new List<string>
            {
                "Lime", "Lime", "Lime", "Lime"
            };

            int result = ShoppingBasketCalculator.CalculateTotal(basket);

            Assert.Equal(45, result);
        }

        [Fact]
        public void EmptyBasket_ShouldCostZero()
        {
            var basket = new List<string>();

            int result = ShoppingBasketCalculator.CalculateTotal(basket);

            Assert.Equal(0, result);
        }

        [Fact]
        public void MixedBasket_ShouldCalculateCorrectTotal()
        {
            var basket = new List<string>
            {
                "Apple", "Apple", "Banana",
                "Melon", "Melon", "Melon",
                "Lime", "Lime", "Lime", "Lime"
            };

            int result = ShoppingBasketCalculator.CalculateTotal(basket);

            Assert.Equal(235, result);
        }

        [Fact]
        public void UnknownItem_ShouldThrowException()
        {
            var basket = new List<string> { "Orange" };

            Assert.Throws<ArgumentException>(
                () => ShoppingBasketCalculator.CalculateTotal(basket)
            );
        }

        [Fact]
        public void NullBasket_ShouldThrowException()
        {
            Assert.Throws<ArgumentNullException>(
                () => ShoppingBasketCalculator.CalculateTotal(null)
            );
        }

        [Fact]
        public void FiveMelons_ShouldCost150()
        {
            var basket = new List<string>
            {
                "Melon", "Melon", "Melon", "Melon", "Melon"
            };

            int result = ShoppingBasketCalculator.CalculateTotal(basket);

            Assert.Equal(150, result);
        }
    }
}
