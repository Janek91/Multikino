using System.Collections.Generic;
using Newtonsoft.Json;

namespace Multikino.Data
{
	public class Film
	{
		public bool Announcement { get; set; }

		public string AvailableCopy { get; set; }

		public Genres Categories { get; set; }

		[JsonProperty("cert_desc")]
		public object CertDesc { get; set; }

		[JsonProperty("cert_image")]
		public string CertImage { get; set; }

		[JsonProperty("coming_soon")]
		public bool ComingSoon { get; set; }

		[JsonProperty("comming_soon")]
		public bool CommingSoon { get; set; }

		[JsonProperty("film_page_name")]
		public string FilmPageName { get; set; }

		[JsonProperty("filmlink")]
		public string Filmlink { get; set; }

		[JsonProperty("genres")]
		public Genres Genres { get; set; }

		[JsonProperty("hidden")]
		public bool Hidden { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("image_hero")]
		public string ImageHero { get; set; }

		[JsonProperty("image_poster")]
		public string ImagePoster { get; set; }

		[JsonProperty("info_age")]
		public string InfoAge { get; set; }

		[JsonProperty("info_cast")]
		public object InfoCast { get; set; }

		[JsonProperty("info_director")]
		public string InfoDirector { get; set; }

		[JsonProperty("info_release")]
		public string InfoRelease { get; set; }

		[JsonProperty("info_runningtime")]
		public string InfoRunningtime { get; set; }

		[JsonProperty("info_runningtime_visible")]
		public bool InfoRunningtimeVisible { get; set; }

		[JsonProperty("newsletterurl")]
		public string Newsletterurl { get; set; }

		[JsonProperty("original_s_count")]
		public long OriginalSCount { get; set; }

		[JsonProperty("pegi_class")]
		public string PegiClass { get; set; }

		[JsonProperty("promo_labels")]
		public PromoLabels PromoLabels { get; set; }

		[JsonProperty("rank_value")]
		public string RankValue { get; set; }

		[JsonProperty("rank_votes")]
		public string RankVotes { get; set; }

		[JsonProperty("ReleaseDate")]
		public string ReleaseDate { get; set; }

		[JsonProperty("show_showings")]
		public bool ShowShowings { get; set; }

		[JsonProperty("showing_type")]
		public ShowingType ShowingType { get; set; }

		[JsonProperty("showings")]
		public List<Showing> Showings { get; set; }

		[JsonProperty("showwantsee")]
		public bool Showwantsee { get; set; }

		[JsonProperty("sortable")]
		public long Sortable { get; set; }

		[JsonProperty("synopsis_short")]
		public string SynopsisShort { get; set; }

		[JsonProperty("tags")]
		public Tags Tags { get; set; }

		[JsonProperty("timeslink")]
		public string Timeslink { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("video")]
		public string Video { get; set; }

		[JsonProperty("videolink")]
		public string Videolink { get; set; }

		[JsonProperty("virtual_reality")]
		public bool VirtualReality { get; set; }

		[JsonProperty("wantsee")]
		public string Wantsee { get; set; }
	}
}