using System.Collections.Generic;
using Newtonsoft.Json;

namespace Multikino.Data
{
	public partial class Genres
	{
		[JsonProperty("active")]
		public bool Active { get; set; }

		[JsonProperty("names")]
		public List<FluffyName> Names { get; set; }
	}
}