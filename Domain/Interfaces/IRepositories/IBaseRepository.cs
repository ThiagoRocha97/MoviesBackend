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
		void Add(T entity);
		void Update(T entity);
		void Delete(int id);
		Task<T> GetById(int id);
		Task<List<T>> GetAll();
	}
}
