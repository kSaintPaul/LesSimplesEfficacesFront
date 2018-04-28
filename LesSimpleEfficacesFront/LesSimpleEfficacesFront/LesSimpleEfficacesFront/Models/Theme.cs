using System;
using System.Collections.Generic;

namespace LesSimpleEfficacesFront.Models
{
	public class Theme
	{
		public Theme()
		{
			Routes = new HashSet<Route>();
		}

		public Guid Id { get; set; }
		public string Designation { get; set; }
		public string Description { get; set; }

		public virtual ICollection<Route> Routes { get; set; }
	}
}
