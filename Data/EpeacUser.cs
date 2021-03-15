using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Data
{
	public class EpeacUser : IdentityUser

	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string StreetName { get; set; }
		public int StreetNumber { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public byte[] ProfilePicture { get; set; }
	}
}