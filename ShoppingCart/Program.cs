using ShoppingCart.BusinessRules;
using ShoppingCart.Repository;
using System;

namespace ShoppingCart
{
    class Program
    {
        static void Main(string[] args)
        {
            var discount = new Discount(new UsersRepository()).DiscountPercentage("jonsan");

            Console.WriteLine($"Discount percentage: {discount}");
        }
    }
}
