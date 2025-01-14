﻿using Entities.Concrete;

namespace Business.Abstract
{
	public interface IProductService
	{
		List<Product> GetAll();
		List<Product> GetAllByCategoryId(int id);
		List<Product> GetByUnitPrice(decimal min, decimal max);
	}
}
