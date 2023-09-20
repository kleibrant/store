using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConvini
{
    public class Motor
    {
        bool redo = true;

        public void Run() {
        Store store = new Store();
        ShoppingCart userCart = new ShoppingCart();

       

        while (redo == true)
        {

            Console.WriteLine("welcome to convini, how may we help you?");
            Console.WriteLine("1. list available items");
            Console.WriteLine("2. add an item to the shopping cart");
            Console.WriteLine("3. view shopping cart");
            Console.WriteLine("4. checkout");
            Console.WriteLine("5. exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    store.ListAvailableItems();
                    Console.WriteLine("would you like to purchase one of these items? y/n");

                    if (Console.ReadLine() == "y")
                    {
                        redo = true;
                    }
                    else
                    {
                        redo = false;
                    }
                    break;

                case "2":
                        string itemName = Console.ReadLine();
                        Item selectedItem = store.GetItemByName(itemName);
                        userCart.AddToCart(selectedItem);
                    Console.WriteLine("proceed? y/n");

                    if (Console.ReadLine() == "y")
                    {
                        redo = true;
                    }

                    else if (Console.ReadLine() == "n")
                    {
                        redo = false;
                    }
                    else
                    {
                        Console.WriteLine("you didn't answer the question!! please say sorry (:");
                        Console.ReadLine();
                        if (Console.ReadLine() == "sorry")
                        {
                            Console.WriteLine("i forgive you, try again <3");
                            redo = true;
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("shopping cart:");
                    userCart.ViewCart();
                    Console.WriteLine("proceed? y/n");

                    if (Console.ReadLine() == "y")
                    {
                        redo = true;
                    }
                    else
                    {
                        redo = false;
                    }
                    break;
                case "4":
                    store.Checkout(userCart);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("invalid option. please try again!");
                    break;
            }
        }
    }
    }
}
