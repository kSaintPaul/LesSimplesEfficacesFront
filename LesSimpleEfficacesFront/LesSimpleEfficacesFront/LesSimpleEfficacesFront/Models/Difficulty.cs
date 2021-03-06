using System;
using System.Collections.Generic;

namespace LesSimpleEfficacesFront.Models
{
	public class Difficulty
	{
		public Difficulty()
		{
			Routes = new HashSet<Route>();
		}

		public Guid Id { get; set; }
		public string Designation { get; set; }

		public virtual ICollection<Route> Routes { get; set; }
	}
}