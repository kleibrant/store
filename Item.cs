using System;

namespace MyConvini
{

	public class Item
	{
		public string Name { get; set; }
		public int Price { get; set; }
		public int Stock { get; set; }

		public Item(string name, int stock, int price)
		{
			Name = name;
			Stock = stock;
			Price = price;
		}
	}
}
