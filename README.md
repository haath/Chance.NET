<h1 align="center">
  <img src="assets/logo.png">
</h1>

<p align="center">
<a href="https://www.nuget.org/packages/Chance.NET">
  <img src="https://img.shields.io/nuget/v/Chance.NET.svg">
</a>
<a href="https://www.nuget.org/packages/Chance.NET">
  <img src="https://img.shields.io/nuget/dt/Chance.NET.svg">
</a>
<a href="https://ci.appveyor.com/project/gmantaos/chance-net">
  <img src="https://ci.appveyor.com/api/projects/status/ahkrm585ivrcqqsv/branch/master?svg=true">
</a>
<a href="LICENSE">
  <img src="https://img.shields.io/badge/license-MIT-blue.svg">
</a>
</p>

[Chance.js](http://chancejs.com) port into native C# targetting .NET Standard.

This project aims to mimic the original chance.js api as closely as possible while adapting 
it to C# types and practices. For example using enums for options and returning regular objects 
instead of json or strings.

## Installation

Install from [NuGet](https://www.nuget.org/packages/Chance.NET/)

## Usage

Simply instantiate a new generator with a new time-dependant seed.

```csharp
Chance chance = new Chance();
```

Or provide a seed.

```csharp
Chance chance = new Chance(42);
```

Which can also be a string.

```csharp
Chance chance = new Chance("string seed");
```

Due to entropy limitations in the underlying `System.Random`, new generators that are instantiated
during the same [tick](https://msdn.microsoft.com/en-us/library/system.datetime.ticks(v=vs.110).aspx)
will inherit the same seed from the system clock. For this reason, when creating multiple `Chance`
instances together, it is recommended that you use a single instance as a generator.

```csharp
Chance generator = new Chance();

for (...)
{
	Chance chance = generator.New();
}
```

## API

Almost every function that is implemented in [Chance.js](http://chancejs.com).
Apart from those, you will find new additions listed below.

### Locations

```csharp
Location loc = chance.Location();
```

You can also generate random locations that are within a given range in meters from a central location.
The generated point is also mathematically set to be uniformally distributed in the given area.

```csharp
double centerLatitude  = 55.753765;
double centerLongitude = 37.620641;
double range           = 100;

// This point will be somewhere around the Red Square in Moscow
Location point = chance.Location(centerLatitude, centerLongitude, range);
```

### Credit Cards

```csharp
CreditCardType ccType = chance.CreditCardType();

ccType.Type;           // MasterCard
ccType.Prefix;         // "51"
ccType.SpacingPattern; // "4-4-4-4"
```

```csharp
CreditCard cc = chance.CreditCard();

cc.Number;           // "4246023945944476"
cc.NumberFormatted;  // "4246 0239 4594 4476"
cc.ExpirationMonth;  // June
cc.ExpirationYear;   // 2020
cc.ExpirationString; // 06/20
```

### People

```csharp
Person p = chance.Person(gender: Gender.Male);

p.Gender;    // Male
p.FirstName; // John
p.SSN;       // "501940398"
```

### Generating objects

You can generate objects of your own types by setting the appropriate attributes and using
the `Chance.Object<T>()` method.

```csharp
public class Book
{
	[Year]
	public int PublishingYear;
		
	[Person]
	public Person Author;

	[String(10)]
	public string Title;
	
	[Paragraph(sentences: 6)]
	public string Summary;
}
```

```csharp
Book book = chance.Object<Book>();
```

## Credits

- Original idea, concept and some of the original datasets are credited to [Victor Quinn](https://www.victorquinn.com/) and the rest of the contributors of [Chance.js](https://chancejs.com/).
- Any math used came from [Markos Karameris](https://www.linkedin.com/in/markos-karameris-298029160/).





