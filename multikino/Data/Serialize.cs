using Newtonsoft.Json;

namespace Multikino.Data
{
	public static class Serialize
	{
		public static string ToJson(this MultikinoShowsData self) => JsonConvert.SerializeObject((object) self, (JsonSerializerSettings) Converter.Settings);
	}
}