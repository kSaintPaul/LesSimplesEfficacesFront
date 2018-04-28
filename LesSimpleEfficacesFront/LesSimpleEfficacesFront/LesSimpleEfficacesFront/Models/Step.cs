using System;
using System.Collections.Generic;

namespace LesSimpleEfficacesFront.Models
{
	public class Step
	{
		public Step()
		{
			StepValidations = new HashSet<StepValidation>();
			Games = new HashSet<Game>();
		}

		public Guid Id { get; set; }
		public string Designation { get; set; }
		public string Description { get; set; }
		public Guid? RouteId { get; set; }
		public string Latitude { get; set; }
		public string Longitude { get; set; }

		public virtual Route Route { get; set; }
		public virtual ICollection<StepValidation> StepValidations { get; set; }
		public virtual ICollection<Game> Games { get; set; }
	}
}
