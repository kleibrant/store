using System;

namespace MyConvini
{

    class ShoppingCart
    {
        public List<Item> cartItems;

        

        public ShoppingCart()
        {
            cartItems = new List<Item>();
        }

        public void AddToCart(Item item)
        {
            if (item.Stock > 0)
            {
                cartItems.Add(item);
                Console.WriteLine($"{item.Name} added to the shopping cart.");
                item.Stock -= 1;
            }
            
        }

        public void ViewCart()
        {
            Console.WriteLine("shopping cart:");
            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Name\tPrice");

            foreach (Item item in cartItems)
            {
                Console.WriteLine($"{item.Name}\t${item.Price}");
            }

            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
        }

        public int Sum()
        {
            int total = 0;

            foreach (Item item in cartItems)
            {
                total += item.Price;
            }

            return total;
        }

       
        }
    }