using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingLibrary
{
    public class ShoppingCart
    {

        private List<ShoppingCartItem> _item = new List<ShoppingCartItem>();

        private double vat;
        public void AddShoppingItem(ShoppingCartItem item)
        {
            _item.Add(item);
        }

        public List<ShoppingCartItem> GetItems()
        {
            return _item;
        }

        public double GetSubTotal()
        {

            double total = 0;

            foreach (ShoppingCartItem shoppingItem in _item)
            {
                total = total + shoppingItem.Price;
            }


            return total;
        }

        public double GetSubTotalWithVat()
        {
            double total = GetSubTotal();

            return total * 1.15;


        }

    }
         
        
}
