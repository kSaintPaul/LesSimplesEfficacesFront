using System;
using System.Collections.Generic;

namespace LesSimpleEfficacesFront.Models
{
	public class Entry
	{
		public Entry()
		{
			StepValidations = new HashSet<StepValidation>();
		}

		public Guid Id { get; set; }
		public Guid? UserId { get; set; }
		public Guid? RouteId { get; set; }

		public virtual Route Route { get; set; }
		public virtual User User { get; set; }
		public virtual ICollection<StepValidation> StepValidations { get; set; }
	}
}
