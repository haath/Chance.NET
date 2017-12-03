# Chance.NET

Chance.js port into native C# targetting portable .NET Standard.

This project aims to mimic the original chance.js api as closely as possible while adapting it to C# types and practices. For example using enums for options and returning regular objects instead of json or strings.

- [Docs](http://chancejs.com)
- [Source](https://github.com/chancejs/chancejs)

## Installation
Version 1.0.0 out on: [NuGet](https://nuget.gmantaos.com/?specialType=singlePackage&id=Chance.NET)

Add the following to your NuGet sources: `https://nuget.gmantaos.com/api/v2/`

## Progress

- [x] Basics
	- [x] bool
	- [x] character
	- [x] floating
	- [x] integer
	- [x] letter
	- [x] natural
	- [x] string
- [x] Text
	- [x] syllable
	- [x] word
	- [x] sentence
	- [x] paragraph
- [x] Person
	- [x] age
	- [x] birthday
	- [x] first
	- [x] gender
	- [x] last
	- [x] name
	- [x] prefix
	- [x] ssn
	- [x] suffix
- [x] Mobile
	- [x] android_id
	- [x] apple_token
	- [x] bb_pin
	- [x] wp7_anid
	- [x] wp8_anid2
- [x] Web
	- [x] avatar
	- [x] color
	- [x] company
	- [x] domain
	- [x] email
	- [x] fbid
	- [x] google_analytics
	- [x] hashtag
	- [x] mac
	- [x] ip
	- [x] ipv6
	- [x] port
	- [x] klout
	- [x] profession
	- [x] tld
	- [x] twitter
	- [x] url
- [x] Location
	- [x] altitude
	- [x] areacode
	- [x] city
	- [x] latitude
	- [x] longitude
	- [x] coordinates
	- [x] country
	- [x] depth
	- [x] geohash
	- [ ] geojson (?)
	- [x] phone (only US)
	- [x] postal
	- [ ] province (?)
	- [x] state
	- [x] street
	- [x] zip
	- [x] address
- [x] Time
	- [x] ampm
	- [x] date
	- [x] hammertime
	- [x] timestamp
	- [x] hour
	- [x] minute
	- [x] second
	- [x] millisecond
	- [x] month
	- [x] timezone
	- [x] weekday
	- [x] year
- [x] Finance
	- [x] cc
	- [x] cc_type
	- [x] exp
	- [x] exp_month
	- [x] exp_year
	- [x] currency
	- [x] currency_pair
	- [x] dollar
	- [x] euro
- [ ] Helpers
	- [x] capitalize
	- [ ] ~~mixin~~ (Does not translate well into C#)
	- [x] pad
	- [x] pickone
	- [x] pickset
	- [x] shuffle
- [x] Miscellaneous
	- [x] coin
	- [x] dice
	- [x] guid
	- [x] hash
	- [x] n
	- [x] normal
	- [x] radio
	- [x] rpg
	- [x] tv
	- [x] unique
	- [x] weighted