using System.Collections.Generic;
using Newtonsoft.Json;

namespace Multikino.Data
{
	public partial class Tags
	{
		[JsonProperty("active")]
		public bool Active { get; set; }

		[JsonProperty("names")]
		public List<object> Names { get; set; }
	}
}