using Newtonsoft.Json;

namespace Multikino.Data
{
	public partial class Tag
	{
		[JsonProperty("fullname")]
		public string Fullname { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}