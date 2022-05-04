using ShoppingLibrary;
using System;
using System.Collections.Generic;

namespace ShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            ShoppingCart cart = new ShoppingCart();

            ShoppingCartItem item = new ShoppingCartItem("Xbox", 5999);
            cart.AddShoppingItem(item);

            item = new ShoppingCartItem("PS4", 9999);
            cart.AddShoppingItem(item);

            item = new ShoppingCartItem("Sugar", 30);
            cart.AddShoppingItem(item);






            List<ShoppingCartItem> shoppingItems = cart.GetItems();

            foreach(ShoppingCartItem shoppingItem in shoppingItems)
            {
                Console.WriteLine(shoppingItem.ItemName +  "  " + shoppingItem.Price);
            }

            Console.WriteLine(cart.GetSubTotal());
            Console.WriteLine(cart.GetSubTotalWithVat());


            // all code to display items and subtotal here


        }
    }
}
