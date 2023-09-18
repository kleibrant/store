using System;
using System.Collections.Generic;

namespace MyConvini
{
    class Store
    {
        private List<Item> storeItems;
        public int wallet = 200; // how do i make this visible to the user?
        ShoppingCart userCart = new ShoppingCart();

        public Store()
        {
            storeItems = new List<Item>();

            Item cigarettes = new Item("cigarettes", 65, 20);
            Item snus = new Item("snus", 45, 30);
            Item redBull = new Item("red bull", 15, 10);
            Item sandwich = new Item("sandwich", 30, 3);
            Item lighter = new Item("lighter", 10, 2);
            Item candy = new Item("candy", 20, 5);
            Item hotDog = new Item("hot dog", 20, 3);

            AddItem(cigarettes);
            AddItem(snus);
            AddItem(redBull);
            AddItem(sandwich);
            AddItem(lighter);
            AddItem(candy);
            AddItem(hotDog);
        }

        public void AddItem(Item item)
        {
            storeItems.Add(item);
        }

        public void ListAvailableItems()
        {
            Console.WriteLine("you can buy these items:");
            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
            Console.WriteLine("name \t price \t stock");

            foreach (Item item in storeItems)
            {
                if (item.Stock > 0)
                {
                    Console.WriteLine($"{item.Name}\t${item.Price}\t{item.Stock}");
                }
            }

            Console.WriteLine("- - - - - - - - - - - - - - - - - -");
        }


        public Item GetItemByName(string itemName)
        {
            foreach (Item item in storeItems)
            {
                if (item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    return item;
                }
            }

            return null; // Item not found with the provided name
        }

        public void Checkout(ShoppingCart userCart)
        {
            int total = userCart.Sum();

            if (wallet >= total)
            {
                wallet -= total;
                Console.WriteLine($"here's your receipt: {ViewCart()} \n {total}");
                Console.WriteLine($"you have ${wallet} left");
            }
            else
            {
                Console.WriteLine($"Sorry, the purchase didn't go through, you don't have enough funds.");
            }

        }

        public void Run()
        {

        }
    }
}

