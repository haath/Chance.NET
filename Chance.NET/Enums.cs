using System;

namespace ChanceNET
{
	public enum AgeRange
	{
		/// <summary>
		/// Ages 0 - 100
		/// </summary>
		Any,

		/// <summary>
		/// Ages 0 - 12
		/// </summary>
		Child,

		/// <summary>
		/// Ages 12 - 19
		/// </summary>
		Teen,

		/// <summary>
		/// Ages 18 - 65
		/// </summary>
		Adult,

		/// <summary>
		/// Ages 65 - 100
		/// </summary>
		Senior
	}

	public enum Gender
	{
		Male,
		Female
	}

	public enum Month
	{
		January = 1,
		February = 2,
		March = 3,
		April = 4,
		May = 5,
		June = 6,
		July = 7,
		August = 8,
		September = 9,
		October = 10,
		November = 11,
		December = 12
	}

	public enum GuidVersion
	{
		V1 = 1,
		V2 = 2,
		V3 = 3,
		V4 = 4,
		V5 = 5
	}

	public enum CoinSide
	{
		Heads,
		Tails
	}

	public enum GravatarDefaults
	{
		Pattern,
		Monster,
		Face,
		Retro
	}

	public enum FileExtensionTypes 
	{
		Raster,
		Vector,
		_3D,
		Document
	}

	public enum RadioSide
	{
		East,
		West
	}
}
