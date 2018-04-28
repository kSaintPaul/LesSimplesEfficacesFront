using System;

namespace LesSimpleEfficacesFront.Models
{
	public class Tip
	{
		public Guid Id { get; set; }
		public string Designation { get; set; }
		public Guid? GameId { get; set; }

		public virtual Game Game { get; set; }
	}
}
