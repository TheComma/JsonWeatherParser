using Newtonsoft.Json.Linq;
using OruPrognozuotojas.Database;
using OruPrognozuotojas.Database.Models;
using System.IO;

namespace OruPrognozuotojas
{
	class Program
	{
		static void Main(string[] args)
		{
			WeatherDatabaseContext dbcontext = new WeatherDatabaseContext();
			JArray o1 = JArray.Parse(File.ReadAllText(@"./f120a0806e14c7bcff4a5c1515aad2aa.json"));
			foreach(JObject obj in o1)
			{
				int i = 1;
			}
			Weather w = new Weather();
		}
		
	}
}
