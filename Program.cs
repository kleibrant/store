using System;
using System.Runtime.InteropServices;

namespace MyConvini
{

    class Program
    {
        bool redo = true;

        static void Main(string[] args)
        {
            Store store = new Store();
            ShoppingCart userCart = new ShoppingCart();

            Program program = new Program();

            while (program.redo == true)
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
                            program.redo = true;
                        }
                        else 
                        { 
                            program.redo = false; 
                        }
                            break;

                    case "2":
                        Console.WriteLine("which item would you like to add to the cart?");
                        string itemName = Console.ReadLine();
                        Item selectedItem = store.GetItemByName(itemName);

                        if (selectedItem != null)
                        {
                            userCart.AddToCart(selectedItem);
                        }
                        else
                        {
                            Console.WriteLine("item not found.");
                        }
                        Console.WriteLine("proceed? y/n");

                        if (Console.ReadLine() == "y")
                        {
                            program.redo = true;
                        }

                        else if (Console.ReadLine() == "n")
                        {
                            program.redo= false;
                        }
                        else
                        {
                            Console.WriteLine("you didn't answer the question!! please say sorry (:");
                            Console.ReadLine();
                            if (Console.ReadLine() == "sorry")
                            {
                                Console.WriteLine("i forgive you, try again <3");
                                program.redo = true;
                            }
                        }
                        break;
                    case "3":
                        userCart.ViewCart();
                        Console.WriteLine("proceed? y/n");

                        if (Console.ReadLine() == "y")
                        {
                            program.redo = true;
                        }
                        else
                        {
                            program.redo = false;
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
