using System.Collections.Generic;
using Newtonsoft.Json;

namespace Multikino.Data
{
	public partial class PromoLabels
	{
		[JsonProperty("isborder")]
		public bool Isborder { get; set; }

		[JsonProperty("names")]
		public List<PurpleName> Names { get; set; }

		[JsonProperty("position")]
		public string Position { get; set; }
	}
}