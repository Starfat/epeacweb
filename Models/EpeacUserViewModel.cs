using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace epeacweb.Models
{
	public class EpeacUserViewModel
	{
		public string Id { get; set; }
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string StreetName { get; set; }
		public int StreetNumber { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public byte[] ProfilePicture { get; set; }
	}
}
