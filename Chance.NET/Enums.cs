using System;

namespace ChanceNET
{
	[Flags]
	public enum AgeRanges
	{
		/// <summary>
		/// Ages 0 - 100
		/// </summary>
		Any		= 0xFF,

		/// <summary>
		/// Ages 0 - 12
		/// </summary>
		Child	= 1 << 0,

		/// <summary>
		/// Ages 12 - 19
		/// </summary>
		Teen	= 1 << 1,

		/// <summary>
		/// Ages 18 - 65
		/// </summary>
		Adult	= 1 << 2,

		/// <summary>
		/// Ages 65 - 100
		/// </summary>
		Senior	= 1 << 3
	}

	public enum Gender
	{
		Male	= 1,
		Female	= 2
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

	[Flags]
	public enum WeekdayTypes
	{
		Any		= 0xFF,
		Weekday	= 1 << 0,
		Weekend	= 1 << 1
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

	[Flags]
	public enum FileExtensionTypes 
	{
		/// <summary>
		/// Image types like .BMP and .PNG
		/// </summary>
		Raster		= 1 << 0,

		/// <summary>
		/// Vector types like .SVG and .AWG
		/// </summary>
		Vector		= 1 << 1,

		/// <summary>
		/// 3D object files like .BLEND and .3DM
		/// </summary>
		_3D			= 1 << 2,

		/// <summary>
		/// Document types like .DOC and .CSV
		/// </summary>
		Document	= 1 << 3
	}

	public enum RadioSide
	{
		East,
		West
	}

	[Flags]
	public enum CreditCardTypes
	{
		AmericanExpress					= 1 << 0,
		Bankcard						= 1 << 1,
		ChinaUnionPay					= 1 << 2,
		DinersClubCarteBlanche			= 1 << 3,
		DinersClubEnRoute				= 1 << 4,
		DinersClubInternational			= 1 << 5,
		DinersClubUnitedStatesAndCanada	= 1 << 6,
		DiscoverCard					= 1 << 7,
		InstaPayment					= 1 << 8,
		JCB								= 1 << 9,
		Laser							= 1 << 10,
		Maestro							= 1 << 11,
		Mastercard						= 1 << 12,
		Solo							= 1 << 13,
		Switch							= 1 << 14,
		Visa							= 1 << 15,
		VisaElectron					= 1 << 16,
		Dankort							= 1 << 17,
		InterPayment					= 1 << 18,
		UATP							= 1 << 19
	}
}
