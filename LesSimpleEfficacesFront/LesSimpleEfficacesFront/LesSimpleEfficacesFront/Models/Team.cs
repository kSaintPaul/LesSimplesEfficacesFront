using System;
using System.Collections.Generic;

namespace LesSimpleEfficacesFront.Models
{
	public class Team
	{
		public Team()
		{
			Users = new HashSet<User>();
		}

		public Guid Id { get; set; }

		public virtual ICollection<User> Users { get; set; }
	}
}
