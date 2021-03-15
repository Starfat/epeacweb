using epeacweb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task = epeacweb.Data.Task;

namespace epeacweb.Contracts
{
	public interface ITaskRepository : IRepositoryBase<Task>
	{
		ICollection<Task> GetEmployeesByTask(int id);
	}
}
