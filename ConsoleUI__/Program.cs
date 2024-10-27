
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

namespace ConsoleUI__
{
	class Program
	{
		static void Main(string[] args)
		{
			ProductManager productManager = new ProductManager(new EfProductDal());
			foreach (var product in productManager.GetByUnitPrice(500, 1000))
			{
				Console.WriteLine(product.ProductName);
			}
		}
	}
}
