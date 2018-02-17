using Newtonsoft.Json;

namespace Multikino.Data
{
	public partial class PurpleName
	{
		[JsonProperty("class")]
		public string Class { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("short_name")]
		public string ShortName { get; set; }
	}
}