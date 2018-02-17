using Newtonsoft.Json;

namespace Multikino.Data
{
	public partial class FluffyName
	{
		[JsonProperty("highlighted")]
		public bool Highlighted { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}
}