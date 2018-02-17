using System;
using Multikino.Service;

namespace Multikino
{
	class Program
	{
		static void Main(string[] args)
		{
			var service = new MultikinoShowsService();
			var films = service.GetShows();
			foreach (var film in films)
			{
				Console.WriteLine(film.Title);
			}
			Console.WriteLine("-------");
			Console.WriteLine("Enter to exit");
			Console.ReadLine();
		}
	}
}
