using System.Collections.Generic;
using Newtonsoft.Json;

namespace Multikino.Data
{
	public class MultikinoShowsData
	{
		[JsonProperty("cdate")]
		public string Cdate { get; set; }

		[JsonProperty("films")]
		public List<Film> Films { get; set; }

		[JsonProperty("Lang")]
		public string Lang { get; set; }

		[JsonProperty("Site")]
		public string Site { get; set; }

		[JsonProperty("SiteRootPath")]
		public string SiteRootPath { get; set; }
	}
}