using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Multikino.Data;
using Newtonsoft.Json;

namespace Multikino.Service
{
	public class MultikinoShowsService 
	{
		private const string Url = "https://multikino.pl/data/filmswithshowings/14";
		
		public List<Film> GetShows()
		{
			var client = new HttpClient();
			
			var data = client.GetStringAsync(Url).Result;
			return JsonConvert.DeserializeObject<MultikinoShowsData>(data).Films;
		}
	}
}