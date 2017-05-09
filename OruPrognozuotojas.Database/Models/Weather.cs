using System;
using System.ComponentModel.DataAnnotations;

namespace OruPrognozuotojas.Database.Models
{
	public class Weather
	{
		[Key]
		public int WeatherId { get; set; }

		public float AverageTemperature { get; set; }

		public float MinimumTemperature { get; set; }

		public float MaximumTemperature { get; set; }

		public int Pressure { get; set; }

		public int Humidity { get; set; }

		public int WindSpeed { get; set; }

		public int WindDegree { get; set; }

		public int CloudCoverege { get; set; }

		public string Sky { get; set; }

		public string SkyDescription { get; set; }

		public DateTime RecordDate { get; set; }

		public DateTime CreateDate { get; set; }
	}
}
