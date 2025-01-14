﻿using Entities.Abstract;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface IEntityRepository<T> where T : class, IEntity, new()
	{
		List<T> GetAll(Expression<Func<T, bool>> filter = null);
		T Get(Expression<Func<T, bool>> filter);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		//List<T> GetAllByCategoryID(int categoryID); //Getall metoduna expression ekleyerek yapılabilir ayrı metoda gerek yok
	}
}
