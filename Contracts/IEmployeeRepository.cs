using epeacweb.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Contracts
{
	public interface IEmployeeRepository : IRepositoryBase<Employee>
	{
	}
}
