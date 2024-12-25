using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.IRepositories
{
	public interface IBaseRepository<T> where T : class
	{
		Task Add(T entity);
		Task Update(T entity);
		Task Delete(int id);
		Task<T?> GetById(int id);
		Task<List<T>> GetAll();
	}
}
