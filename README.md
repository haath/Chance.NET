
![logo](assets/logo.png)

[![Nuget](https://img.shields.io/nuget/v/Chance.NET.svg)](https://www.nuget.org/packages/Chance.NET/)

[Chance.js](http://chancejs.com) port into native C# targetting portable .NET Standard.



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

### API

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

### Generating objects

You can generate objects of your own types by setting the appropriate attributes and using
the `Chance.Object<T>()` method.

```csharp
public class Book
{
	[Integer(min: 1950)]
	public int PublishingYear;
		
	[Person]
	public Person Author;

	[String(10)]
	public string Title;
}
```

```csharp
Book book = chance.Object<Book>();
```







