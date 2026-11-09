
using System;
using System.Collections.Generic;

namespace ShoppingBasket
{
    public class ShoppingBasketCalculator
    {
        public static Dictionary<string, int> CountItems(List<string> basket)
        {
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string item in basket)
            {
                if (counts.ContainsKey(item))
                {
                    counts[item]++;
                }
                else
                {
                    counts[item] = 1;
                }
            }

            return counts;
        }

        public static int CalculateItemPrice(string item, int quantity)
        {
            switch (item)
            {
                case "Apple":
                    return quantity * 35;

                case "Banana":
                    return quantity * 20;

                case "Melon":
                    return ((quantity + 1) / 2) * 50;

                case "Lime":
                    return ((quantity / 3) * 2 + quantity % 3) * 15;

                default:
                    throw new ArgumentException("Unknown item: " + item);
            }
        }

        public static int CalculateTotal(List<string> basket)
        {
            if (basket == null)
                throw new ArgumentNullException(nameof(basket));

            Dictionary<string, int> counts = CountItems(basket);

            int total = 0;

            foreach (var entry in counts)
            {
                total += CalculateItemPrice(entry.Key, entry.Value);
            }

            return total;
        }
    }

    class Program
    {
        static void Main()
        {
            List<string> basket = new List<string>
            {
                "Apple",
                "Apple",
                "Banana",
                "Melon",
                "Melon",
                "Melon",
                "Lime",
                "Lime",
                "Lime",
                "Lime"
            };

            int total = ShoppingBasketCalculator.CalculateTotal(basket);

            Console.WriteLine("Total shopping cost: " + total + "p");
        }
    }
}
