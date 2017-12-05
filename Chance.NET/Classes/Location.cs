using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET
{
	public struct Location
	{
		public readonly double Latitude;
		public readonly double Longitude;

		internal Location(double latitude, double longitude)
		{
			Latitude = latitude;
			Longitude = longitude;
		}

		/// <summary>
		/// Get this location in a string formatted as: Lat, Long
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Latitude + ", " + Longitude;
		}
	}
}
