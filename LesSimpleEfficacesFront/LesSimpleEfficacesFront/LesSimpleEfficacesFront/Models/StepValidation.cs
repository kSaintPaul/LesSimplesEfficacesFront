using System;

namespace LesSimpleEfficacesFront.Models
{
	public class StepValidation
	{
		public Guid EntryId { get; set; }
		public Guid StepId { get; set; }
		public bool? Validated { get; set; }

		public virtual Entry Entry { get; set; }
		public virtual Step Step { get; set; }
	}
}
