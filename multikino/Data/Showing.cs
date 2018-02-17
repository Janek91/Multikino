using System.Collections.Generic;
using Newtonsoft.Json;

namespace Multikino.Data
{
	public partial class Showing
	{
		[JsonProperty("cdate")]
		public string Cdate { get; set; }

		[JsonProperty("clone")]
		public bool Clone { get; set; }

		[JsonProperty("date")]
		public string Date { get; set; }

		[JsonProperty("date_day")]
		public string DateDay { get; set; }

		[JsonProperty("date_formatted")]
		public string DateFormatted { get; set; }

		[JsonProperty("date_long")]
		public string DateLong { get; set; }

		[JsonProperty("date_prefix")]
		public string DatePrefix { get; set; }

		[JsonProperty("date_short")]
		public string DateShort { get; set; }

		[JsonProperty("date_time")]
		public string DateTime { get; set; }

		[JsonProperty("times")]
		public List<Time> Times { get; set; }
	}
}