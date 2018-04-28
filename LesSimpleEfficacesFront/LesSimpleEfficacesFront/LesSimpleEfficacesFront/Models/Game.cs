using System;
using System.Collections.Generic;

namespace LesSimpleEfficacesFront.Models
{
	public class Game
	{
		public Game()
		{
			Tips = new HashSet<Tip>();
			Steps = new HashSet<Step>();
		}

		public Guid Id { get; set; }
		public string Designation { get; set; }
		public string Description { get; set; }

		public virtual ICollection<Tip> Tips { get; set; }
		public virtual ICollection<Step> Steps { get; set; }
	}
}
