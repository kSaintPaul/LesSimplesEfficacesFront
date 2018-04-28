using System;
using System.Collections.Generic;

namespace LesSimpleEfficacesFront.Models
{
	public class Route
	{
		public Route()
		{
			Entries = new HashSet<Entry>();
			Steps = new HashSet<Step>();
			Themes = new HashSet<Theme>();
		}

		public Guid Id { get; set; }
		public string Designation { get; set; }
		public string StartingDate { get; set; }
		public string Duration { get; set; }
		public string ParticipantsCount { get; set; }
		public string Description { get; set; }
		public Guid? DifficultyId { get; set; }

		public virtual Difficulty Difficulty { get; set; }
		public virtual ICollection<Entry> Entries { get; set; }
		public virtual ICollection<Step> Steps { get; set; }
		public virtual ICollection<Theme> Themes { get; set; }
	}
}
