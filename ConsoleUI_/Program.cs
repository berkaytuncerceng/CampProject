﻿using System;

namespace ConsoleUI_
{
	internal class Program
	{
		static void Main(string[] args)
		{

			ProductManager productManager = new ProductManager(new InMemoryProductDal());
			foreach (var product in productManager.GetAll())
			{
				Console.WriteLine(product.ProductName);
			}

		}
	}
}
