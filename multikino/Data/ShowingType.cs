using Newtonsoft.Json;

namespace Multikino.Data
{
	public partial class ShowingType
	{
		[JsonProperty("active")]
		public bool Active { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}