using System;
using System.Collections.Generic;

namespace LesSimpleEfficacesFront.Models
{
	public class User
	{
		public User()
		{
			Entries = new HashSet<Entry>();
			Teams = new HashSet<Team>();
		}

		public Guid Id { get; set; }
		public string Firstname { get; set; }
		public string Email { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public DateTime? BirthDate { get; set; }
		public string Lastname { get; set; }

		public virtual ICollection<Entry> Entries { get; set; }
		public virtual ICollection<Team> Teams { get; set; }
	}
}
