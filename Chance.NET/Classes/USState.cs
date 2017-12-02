using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET
{
	public class USState
	{
		public readonly string Abbreviation;
		public readonly string StateName;
		public readonly string ZipCodes;
		public readonly string Capitol;
		public readonly string Bird;
		public readonly string Flower;
		public readonly string Population;
		public readonly string LargestCity;
		public readonly string Latitude;
		public readonly string Longitude;
		public readonly string SquareMiles;
		public readonly string AdmittedToUnion;
		public readonly string HighestPoint;
		public readonly string LowestPoint;
		public readonly string MedianAltitude;
		public readonly string AreaCodes;
		public readonly string Motto;
		public readonly string Magnify;
		public readonly string Nickname;
		public readonly string Facts;
		public readonly string Tree;
		public readonly string OriginOfName;

		internal USState(string abbreviation,
						 string stateName,
						 string zipCodes,
						 string capitol,
						 string bird,
						 string flower,
						 string population,
						 string largestcity,
						 string latitude,
						 string longitude,
						 string squaremiles,
						 string admittedtounion,
						 string highestpoint,
						 string lowestpoint,
						 string medianaltitude,
						 string areacodes,
						 string motto,
						 string magnify,
						 string nickname,
						 string facts,
						 string tree,
						 string originofname
		)
		{
			Abbreviation = abbreviation;
			StateName = stateName;
			ZipCodes = zipCodes;
			Capitol = capitol;
			Bird = bird;
			Flower = flower;
			Population = population;
			LargestCity = largestcity;
			Latitude = latitude;
			Longitude = longitude;
			SquareMiles = squaremiles;
			AdmittedToUnion = admittedtounion;
			HighestPoint = highestpoint;
			LowestPoint = lowestpoint;
			MedianAltitude = medianaltitude;
			AreaCodes = areacodes;
			Motto = motto;
			Magnify = magnify;
			Nickname = nickname;
			Facts = facts;
			Tree = tree;
			OriginOfName = originofname;
		}
		
	}
}
