using System.Collections.Generic;
using Newtonsoft.Json;

namespace Multikino.Data
{
	public partial class Time
	{
		[JsonProperty("date")]
		public string Date { get; set; }

		[JsonProperty("event_info")]
		public object EventInfo { get; set; }

		[JsonProperty("hidden")]
		public bool Hidden { get; set; }

		[JsonProperty("lang")]
		public object Lang { get; set; }

		[JsonProperty("time")]
		public string PurpleTime { get; set; }

		[JsonProperty("screen_number")]
		public object ScreenNumber { get; set; }

		[JsonProperty("screen_type")]
		public string ScreenType { get; set; }

		[JsonProperty("session_id")]
		public string SessionId { get; set; }

		[JsonProperty("tags")]
		public List<Tag> Tags { get; set; }

		[JsonProperty("version_id")]
		public string VersionId { get; set; }
	}
}