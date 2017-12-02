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

	public enum Weekday
	{
		Monday = 1,
		Tuesday = 2,
		Wednesday = 3,
		Thursday = 4,
		Friday = 5,
		Saturday = 6,
		Sunday = 7
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
		/// <summary>
		/// Mystery man
		/// </summary>
		MM,

		/// <summary>
		/// Geometric pattern based on hash
		/// </summary>
		Identicon,

		/// <summary>
		/// A generated monster icon
		/// </summary>
		MonsterId,

		/// <summary>
		/// A generated face
		/// </summary>
		Wavatar,

		/// <summary>
		/// 8-bit icon
		/// </summary>
		Retro,

		/// <summary>
		/// A transparent png
		/// </summary>
		Blank
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
