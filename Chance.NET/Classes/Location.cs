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

		/// <summary>
		/// Get the distance between this location and a set of geographical coordinates.
		/// </summary>
		/// <returns></returns>
		public double DistanceTo(double latitude, double longitude)
		{
			const int EARTH_RADIUS = 6371000;
			Func<double, double> toRad = ang =>
			{
				return (Math.PI / 180) * ang;
			};

			double dLng = toRad(Longitude - longitude);
			double dLat = toRad(Latitude - latitude);
			double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2)
					+ Math.Cos(toRad(Latitude)) * Math.Cos(toRad(latitude))
					* Math.Sin(dLng / 2) * Math.Sin(dLng / 2);
			double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
			return (float)(EARTH_RADIUS * c);
		}

		/// <summary>
		/// Get the distance between this location and another.
		/// </summary>
		/// <param name="loc"></param>
		/// <returns></returns>
		public double DistanceTo(Location loc)
		{
			return DistanceTo(loc.Latitude, loc.Longitude);
		}
	}
}
