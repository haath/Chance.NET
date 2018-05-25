using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChanceNET
{
	internal static class Data
	{
		public static class FirstNames
		{
			public static string[] Male =
			{
				"James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Charles", "Thomas", "Christopher", "Daniel", "Matthew", "George", "Donald", "Anthony", "Paul", "Mark", "Edward", "Steven", "Kenneth", "Andrew", "Brian", "Joshua", "Kevin", "Ronald", "Timothy", "Jason", "Jeffrey", "Frank", "Gary", "Ryan", "Nicholas", "Eric", "Stephen", "Jacob", "Larry", "Jonathan", "Scott", "Raymond", "Justin", "Brandon", "Gregory", "Samuel", "Benjamin", "Patrick", "Jack", "Henry", "Walter", "Dennis", "Jerry", "Alexander", "Peter", "Tyler", "Douglas", "Harold", "Aaron", "Jose", "Adam", "Arthur", "Zachary", "Carl", "Nathan", "Albert", "Kyle", "Lawrence", "Joe", "Willie", "Gerald", "Roger", "Keith", "Jeremy", "Terry", "Harry", "Ralph", "Sean", "Jesse", "Roy", "Louis", "Billy", "Austin", "Bruce", "Eugene", "Christian", "Bryan", "Wayne", "Russell", "Howard", "Fred", "Ethan", "Jordan", "Philip", "Alan", "Juan", "Randy", "Vincent", "Bobby", "Dylan", "Johnny", "Phillip", "Victor", "Clarence", "Ernest", "Martin", "Craig", "Stanley", "Shawn", "Travis", "Bradley", "Leonard", "Earl", "Gabriel", "Jimmy", "Francis", "Todd", "Noah", "Danny", "Dale", "Cody", "Carlos", "Allen", "Frederick", "Logan", "Curtis", "Alex", "Joel", "Luis", "Norman", "Marvin", "Glenn", "Tony", "Nathaniel", "Rodney", "Melvin", "Alfred", "Steve", "Cameron", "Chad", "Edwin", "Caleb", "Evan", "Antonio", "Lee", "Herbert", "Jeffery", "Isaac", "Derek", "Ricky", "Marcus", "Theodore", "Elijah", "Luke", "Jesus", "Eddie", "Troy", "Mike", "Dustin", "Ray", "Adrian", "Bernard", "Leroy", "Angel", "Randall", "Wesley", "Ian", "Jared", "Mason", "Hunter", "Calvin", "Oscar", "Clifford", "Jay", "Shane", "Ronnie", "Barry", "Lucas", "Corey", "Manuel", "Leo", "Tommy", "Warren", "Jackson", "Isaiah", "Connor", "Don", "Dean", "Jon", "Julian", "Miguel", "Bill", "Lloyd", "Charlie", "Mitchell", "Leon", "Jerome", "Darrell", "Jeremiah", "Alvin", "Brett", "Seth", "Floyd", "Jim", "Blake", "Micheal", "Gordon", "Trevor", "Lewis", "Erik", "Edgar", "Vernon", "Devin", "Gavin", "Jayden", "Chris", "Clyde", "Tom", "Derrick", "Mario", "Brent", "Marc", "Herman", "Chase", "Dominic", "Ricardo", "Franklin", "Maurice", "Max", "Aiden", "Owen", "Lester", "Gilbert", "Elmer", "Gene", "Francisco", "Glen", "Cory", "Garrett", "Clayton", "Sam", "Jorge", "Chester", "Alejandro", "Jeff", "Harvey", "Milton", "Cole", "Ivan", "Andre", "Duane", "Landon"
			};

			public static string[] Female =
			{
				"Mary", "Emma", "Elizabeth", "Minnie", "Margaret", "Ida", "Alice", "Bertha", "Sarah", "Annie", "Clara", "Ella", "Florence", "Cora", "Martha", "Laura", "Nellie", "Grace", "Carrie", "Maude", "Mabel", "Bessie", "Jennie", "Gertrude", "Julia", "Hattie", "Edith", "Mattie", "Rose", "Catherine", "Lillian", "Ada", "Lillie", "Helen", "Jessie", "Louise", "Ethel", "Lula", "Myrtle", "Eva", "Frances", "Lena", "Lucy", "Edna", "Maggie", "Pearl", "Daisy", "Fannie", "Josephine", "Dora", "Rosa", "Katherine", "Agnes", "Marie", "Nora", "May", "Mamie", "Blanche", "Stella", "Ellen", "Nancy", "Effie", "Sallie", "Nettie", "Della", "Lizzie", "Flora", "Susie", "Maud", "Mae", "Etta", "Harriet", "Sadie", "Caroline", "Katie", "Lydia", "Elsie", "Kate", "Susan", "Mollie", "Alma", "Addie", "Georgia", "Eliza", "Lulu", "Nannie", "Lottie", "Amanda", "Belle", "Charlotte", "Rebecca", "Ruth", "Viola", "Olive", "Amelia", "Hannah", "Jane", "Virginia", "Emily", "Matilda", "Irene", "Kathryn", "Esther", "Willie", "Henrietta", "Ollie", "Amy", "Rachel", "Sara", "Estella", "Theresa", "Augusta", "Ora", "Pauline", "Josie", "Lola", "Sophia", "Leona", "Anne", "Mildred", "Ann", "Beulah", "Callie", "Lou", "Delia", "Eleanor", "Barbara", "Iva", "Louisa", "Maria", "Mayme", "Evelyn", "Estelle", "Nina", "Betty", "Marion", "Bettie", "Dorothy", "Luella", "Inez", "Lela", "Rosie", "Allie", "Millie", "Janie", "Cornelia", "Victoria", "Ruby", "Winifred", "Alta", "Celia", "Christine", "Beatrice", "Birdie", "Harriett", "Mable", "Myra", "Sophie", "Tillie", "Isabel", "Sylvia", "Carolyn", "Isabelle", "Leila", "Sally", "Ina", "Essie", "Bertie", "Nell", "Alberta", "Katharine", "Lora", "Rena", "Mina", "Rhoda", "Mathilda", "Abbie", "Eula", "Dollie", "Hettie", "Eunice", "Fanny", "Ola", "Lenora", "Adelaide", "Christina", "Lelia", "Nelle", "Sue", "Johanna", "Lilly", "Lucinda", "Minerva", "Lettie", "Roxie", "Cynthia", "Helena", "Hilda", "Hulda", "Bernice", "Genevieve", "Jean", "Cordelia", "Marian", "Francis", "Jeanette", "Adeline", "Gussie", "Leah", "Lois", "Lura", "Mittie", "Hallie", "Isabella", "Olga", "Phoebe", "Teresa", "Hester", "Lida", "Lina", "Winnie", "Claudia", "Marguerite", "Vera", "Cecelia", "Bess", "Emilie", "Rosetta", "Verna", "Myrtie", "Cecilia", "Elva", "Olivia", "Ophelia", "Georgie", "Elnora", "Violet", "Adele", "Lily", "Linnie", "Loretta", "Madge", "Polly", "Virgie", "Eugenia", "Lucile", "Lucille", "Mabelle", "Rosalie"
			};

			public static string[] Any
			{
				get
				{
					string[] combined = new string[Male.Length + Female.Length];
					Male.CopyTo(combined, 0);
					Female.CopyTo(combined, Male.Length);
					return combined;
				}
			}
		}

		public static string[] LastNames =
		{
			"Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Robinson", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "Hernandez", "King", "Wright", "Lopez", "Hill", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez", "Roberts", "Turner", "Phillips", "Campbell", "Parker", "Evans", "Edwards", "Collins", "Stewart", "Sanchez", "Morris", "Rogers", "Reed", "Cook", "Morgan", "Bell", "Murphy", "Bailey", "Rivera", "Cooper", "Richardson", "Cox", "Howard", "Ward", "Torres", "Peterson", "Gray", "Ramirez", "James", "Watson", "Brooks", "Kelly", "Sanders", "Price", "Bennett", "Wood", "Barnes", "Ross", "Henderson", "Coleman", "Jenkins", "Perry", "Powell", "Long", "Patterson", "Hughes", "Flores", "Washington", "Butler", "Simmons", "Foster", "Gonzales", "Bryant", "Alexander", "Russell", "Griffin", "Diaz", "Hayes", "Myers", "Ford", "Hamilton", "Graham", "Sullivan", "Wallace", "Woods", "Cole", "West", "Jordan", "Owens", "Reynolds", "Fisher", "Ellis", "Harrison", "Gibson", "McDonald", "Cruz", "Marshall", "Ortiz", "Gomez", "Murray", "Freeman", "Wells", "Webb", "Simpson", "Stevens", "Tucker", "Porter", "Hunter", "Hicks", "Crawford", "Henry", "Boyd", "Mason", "Morales", "Kennedy", "Warren", "Dixon", "Ramos", "Reyes", "Burns", "Gordon", "Shaw", "Holmes", "Rice", "Robertson", "Hunt", "Black", "Daniels", "Palmer", "Mills", "Nichols", "Grant", "Knight", "Ferguson", "Rose", "Stone", "Hawkins", "Dunn", "Perkins", "Hudson", "Spencer", "Gardner", "Stephens", "Payne", "Pierce", "Berry", "Matthews", "Arnold", "Wagner", "Willis", "Ray", "Watkins", "Olson", "Carroll", "Duncan", "Snyder", "Hart", "Cunningham", "Bradley", "Lane", "Andrews", "Ruiz", "Harper", "Fox", "Riley", "Armstrong", "Carpenter", "Weaver", "Greene", "Lawrence", "Elliott", "Chavez", "Sims", "Austin", "Peters", "Kelley", "Franklin", "Lawson", "Fields", "Gutierrez", "Ryan", "Schmidt", "Carr", "Vasquez", "Castillo", "Wheeler", "Chapman", "Oliver", "Montgomery", "Richards", "Williamson", "Johnston", "Banks", "Meyer", "Bishop", "McCoy", "Howell", "Alvarez", "Morrison", "Hansen", "Fernandez", "Garza", "Harvey", "Little", "Burton", "Stanley", "Nguyen", "George", "Jacobs", "Reid", "Kim", "Fuller", "Lynch", "Dean", "Gilbert", "Garrett", "Romero", "Welch", "Larson", "Frazier", "Burke", "Hanson", "Day", "Mendoza", "Moreno", "Bowman", "Medina", "Fowler", "Brewer", "Hoffman", "Carlson", "Silva", "Pearson", "Holland", "Douglas", "Fleming", "Jensen", "Vargas", "Byrd", "Davidson", "Hopkins", "May", "Terry", "Herrera", "Wade", "Soto", "Walters", "Curtis", "Neal", "Caldwell", "Lowe", "Jennings", "Barnett", "Graves", "Jimenez", "Horton", "Shelton", "Barrett", "Obrien", "Castro", "Sutton", "Gregory", "McKinney", "Lucas", "Miles", "Craig", "Rodriquez", "Chambers", "Holt", "Lambert", "Fletcher", "Watts", "Bates", "Hale", "Rhodes", "Pena", "Beck", "Newman", "Haynes", "McDaniel", "Mendez", "Bush", "Vaughn", "Parks", "Dawson", "Santiago", "Norris", "Hardy", "Love", "Steele", "Curry", "Powers", "Schultz", "Barker", "Guzman", "Page", "Munoz", "Ball", "Keller", "Chandler", "Weber", "Leonard", "Walsh", "Lyons", "Ramsey", "Wolfe", "Schneider", "Mullins", "Benson", "Sharp", "Bowen", "Daniel", "Barber", "Cummings", "Hines", "Baldwin", "Griffith", "Valdez", "Hubbard", "Salazar", "Reeves", "Warner", "Stevenson", "Burgess", "Santos", "Tate", "Cross", "Garner", "Mann", "Mack", "Moss", "Thornton", "Dennis", "McGee", "Farmer", "Delgado", "Aguilar", "Vega", "Glover", "Manning", "Cohen", "Harmon", "Rodgers", "Robbins", "Newton", "Todd", "Blair", "Higgins", "Ingram", "Reese", "Cannon", "Strickland", "Townsend", "Potter", "Goodwin", "Walton", "Rowe", "Hampton", "Ortega", "Patton", "Swanson", "Joseph", "Francis", "Goodman", "Maldonado", "Yates", "Becker", "Erickson", "Hodges", "Rios", "Conner", "Adkins", "Webster", "Norman", "Malone", "Hammond", "Flowers", "Cobb", "Moody", "Quinn", "Blake", "Maxwell", "Pope", "Floyd", "Osborne", "Paul", "McCarthy", "Guerrero", "Lindsey", "Estrada", "Sandoval", "Gibbs", "Tyler", "Gross", "Fitzgerald", "Stokes", "Doyle", "Sherman", "Saunders", "Wise", "Colon", "Gill", "Alvarado", "Greer", "Padilla", "Simon", "Waters", "Nunez", "Ballard", "Schwartz", "McBride", "Houston", "Christensen", "Klein", "Pratt", "Briggs", "Parsons", "McLaughlin", "Zimmerman", "French", "Buchanan", "Moran", "Copeland", "Roy", "Pittman", "Brady", "McCormick", "Holloway", "Brock", "Poole", "Frank", "Logan", "Owen", "Bass", "Marsh", "Drake", "Wong", "Jefferson", "Park", "Morton", "Abbott", "Sparks", "Patrick", "Norton", "Huff", "Clayton", "Massey", "Lloyd", "Figueroa", "Carson", "Bowers", "Roberson", "Barton", "Tran", "Lamb", "Harrington", "Casey", "Boone", "Cortez", "Clarke", "Mathis", "Singleton", "Wilkins", "Cain", "Bryan", "Underwood", "Hogan", "McKenzie", "Collier", "Luna", "Phelps", "McGuire", "Allison", "Bridges", "Wilkerson", "Nash", "Summers", "Atkins"
		};

		public static class Prefixes
		{
			public static string[] Male =
			{
				"Dr.", "Mr."
			};

			public static string[] Female =
			{
				"Dr.", "Mrs.", "Miss"
			};

			public static string[] Any
			{
				get
				{
					string[] combined = new string[Male.Length + Female.Length];
					Male.CopyTo(combined, 0);
					Female.CopyTo(combined, Male.Length);
					return combined;
				}
			}
		}

		public static string[] Suffixes =
		{
			"D.O.", "Ph.D.", "Esq.", "Jr.", "J.D.", "M.A.", "M.B.A", "M.S.", "M.D.", "Sr.", "III", "IV", "B.E.", "B.TECH"
		};

		public static string[] TLDs =
		{
			"com", "org", "edu", "gov", "co.uk", "net", "io", "ac", "ad", "ae", "af", "ag", "ai", "al", "am", "an", "ao", "aq", "ar", "as", "at", "au", "aw", "ax", "az", "ba", "bb", "bd", "be", "bf", "bg", "bh", "bi", "bj", "bm", "bn", "bo", "bq", "br", "bs", "bt", "bv", "bw", "by", "bz", "ca", "cc", "cd", "cf", "cg", "ch", "ci", "ck", "cl", "cm", "cn", "co", "cr", "cu", "cv", "cw", "cx", "cy", "cz", "de", "dj", "dk", "dm", "do", "dz", "ec", "ee", "eg", "eh", "er", "es", "et", "eu", "fi", "fj", "fk", "fm", "fo", "fr", "ga", "gb", "gd", "ge", "gf", "gg", "gh", "gi", "gl", "gm", "gn", "gp", "gq", "gr", "gs", "gt", "gu", "gw", "gy", "hk", "hm", "hn", "hr", "ht", "hu", "id", "ie", "il", "im", "in", "io", "iq", "ir", "is", "it", "je", "jm", "jo", "jp", "ke", "kg", "kh", "ki", "km", "kn", "kp", "kr", "kw", "ky", "kz", "la", "lb", "lc", "li", "lk", "lr", "ls", "lt", "lu", "lv", "ly", "ma", "mc", "md", "me", "mg", "mh", "mk", "ml", "mm", "mn", "mo", "mp", "mq", "mr", "ms", "mt", "mu", "mv", "mw", "mx", "my", "mz", "na", "nc", "ne", "nf", "ng", "ni", "nl", "no", "np", "nr", "nu", "nz", "om", "pa", "pe", "pf", "pg", "ph", "pk", "pl", "pm", "pn", "pr", "ps", "pt", "pw", "py", "qa", "re", "ro", "rs", "ru", "rw", "sa", "sb", "sc", "sd", "se", "sg", "sh", "si", "sj", "sk", "sl", "sm", "sn", "so", "sr", "ss", "st", "su", "sv", "sx", "sy", "sz", "tc", "td", "tf", "tg", "th", "tj", "tk", "tl", "tm", "tn", "to", "tp", "tr", "tt", "tv", "tw", "tz", "ua", "ug", "uk", "us", "uy", "uz", "va", "vc", "ve", "vg", "vi", "vn", "vu", "wf", "ws", "ye", "yt", "za", "zm", "zw"
		};

		public static class Professions
		{
			public static string[] Ranks =
			{
				"Apprentice", "Junior", "Senior", "Lead", "Trainee"
			};

			public static string[] Names =
			{
				"Airline Pilot", "Academic Team", "Accountant", "Account Executive", "Actor", "Actuary", "Acquisition Analyst", "Administrative Asst.", "Administrative Analyst", "Administrator", "Advertising Director", "Aerospace Engineer", "Agent", "Agricultural Inspector", "Agricultural Scientist", "Air Traffic Controller", "Animal Trainer", "Anthropologist", "Appraiser", "Architect", "Art Director", "Artist", "Astronomer", "Athletic Coach", "Auditor", "Author", "Baker", "Banker", "Bankruptcy Attorney", "Benefits Manager", "Biologist", "Bio-feedback Specialist", "Biomedical Engineer", "Biotechnical Researcher", "Broadcaster", "Broker", "Building Manager", "Building Contractor", "Building Inspector", "Business Analyst", "Business Planner", "Business Manager", "Buyer", "Call Center Manager", "Career Counselor", "Cash Manager", "Ceramic Engineer", "Chief Executive Officer", "Chief Operation Officer", "Chef", "Chemical Engineer", "Chemist", "Child Care Manager", "Chief Medical Officer", "Chiropractor", "Cinematographer", "City Housing Manager", "City Manager", "Civil Engineer", "Claims Manager", "Clinical Research Assistant", "Collections Manager.", "Compliance Manager", "Comptroller", "Computer Manager", "Commercial Artist", "Communications Affairs Director", "Communications Director", "Communications Engineer", "Compensation Analyst", "Computer Programmer", "Computer Ops. Manager", "Computer Engineer", "Computer Operator", "Computer Graphics Specialist", "Construction Engineer", "Construction Manager", "Consultant", "Consumer Relations Manager", "Contract Administrator", "Copyright Attorney", "Copywriter", "Corporate Planner", "Corrections Officer", "Cosmetologist", "Credit Analyst", "Cruise Director", "Chief Information Officer", "Chief Technology Officer", "Customer Service Manager", "Cryptologist", "Dancer", "Data Security Manager", "Database Manager", "Day Care Instructor", "Dentist", "Designer", "Design Engineer", "Desktop Publisher", "Developer", "Development Officer", "Diamond Merchant", "Dietitian", "Direct Marketer", "Director", "Distribution Manager", "Diversity Manager", "Economist", "EEO Compliance Manager", "Editor", "Education Adminator", "Electrical Engineer", "Electro Optical Engineer", "Electronics Engineer", "Embassy Management", "Employment Agent", "Engineer Technician", "Entrepreneur", "Environmental Analyst", "Environmental Attorney", "Environmental Engineer", "Environmental Specialist", "Escrow Officer", "Estimator", "Executive Assistant", "Executive Director", "Executive Recruiter", "Facilities Manager", "Family Counselor", "Fashion Events Manager", "Fashion Merchandiser", "Fast Food Manager", "Film Producer", "Film Production Assistant", "Financial Analyst", "Financial Planner", "Financier", "Fine Artist", "Wildlife Specialist", "Fitness Consultant", "Flight Attendant", "Flight Engineer", "Floral Designer", "Food & Beverage Director", "Food Service Manager", "Forestry Technician", "Franchise Management", "Franchise Sales", "Fraud Investigator", "Freelance Writer", "Fund Raiser", "General Manager", "Geologist", "General Counsel", "Geriatric Specialist", "Gerontologist", "Glamour Photographer", "Golf Club Manager", "Gourmet Chef", "Graphic Designer", "Grounds Keeper", "Hazardous Waste Manager", "Health Care Manager", "Health Therapist", "Health Service Administrator", "Hearing Officer", "Home Economist", "Horticulturist", "Hospital Administrator", "Hotel Manager", "Human Resources Manager", "Importer", "Industrial Designer", "Industrial Engineer", "Information Director", "Inside Sales", "Insurance Adjuster", "Interior Decorator", "Internal Controls Director", "International Acct.", "International Courier", "International Lawyer", "Interpreter", "Investigator", "Investment Banker", "Investment Manager", "IT Architect", "IT Project Manager", "IT Systems Analyst", "Jeweler", "Joint Venture Manager", "Journalist", "Labor Negotiator", "Labor Organizer", "Labor Relations Manager", "Lab Services Director", "Lab Technician", "Land Developer", "Landscape Architect", "Law Enforcement Officer", "Lawyer", "Lead Software Engineer", "Lead Software Test Engineer", "Leasing Manager", "Legal Secretary", "Library Manager", "Litigation Attorney", "Loan Officer", "Lobbyist", "Logistics Manager", "Maintenance Manager", "Management Consultant", "Managed Care Director", "Managing Partner", "Manufacturing Director", "Manpower Planner", "Marine Biologist", "Market Res. Analyst", "Marketing Director", "Materials Manager", "Mathematician", "Membership Chairman", "Mechanic", "Mechanical Engineer", "Media Buyer", "Medical Investor", "Medical Secretary", "Medical Technician", "Mental Health Counselor", "Merchandiser", "Metallurgical Engineering", "Meteorologist", "Microbiologist", "MIS Manager", "Motion Picture Director", "Multimedia Director", "Musician", "Network Administrator", "Network Specialist", "Network Operator", "New Product Manager", "Novelist", "Nuclear Engineer", "Nuclear Specialist", "Nutritionist", "Nursing Administrator", "Occupational Therapist", "Oceanographer", "Office Manager", "Operations Manager", "Operations Research Director", "Optical Technician", "Optometrist", "Organizational Development Manager", "Outplacement Specialist", "Paralegal", "Park Ranger", "Patent Attorney", "Payroll Specialist", "Personnel Specialist", "Petroleum Engineer", "Pharmacist", "Photographer", "Physical Therapist", "Physician", "Physician Assistant", "Physicist", "Planning Director", "Podiatrist", "Political Analyst", "Political Scientist", "Politician", "Portfolio Manager", "Preschool Management", "Preschool Teacher", "Principal", "Private Banker", "Private Investigator", "Probation Officer", "Process Engineer", "Producer", "Product Manager", "Product Engineer", "Production Engineer", "Production Planner", "Professional Athlete", "Professional Coach", "Professor", "Project Engineer", "Project Manager", "Program Manager", "Property Manager", "Public Administrator", "Public Safety Director", "PR Specialist", "Publisher", "Purchasing Agent", "Publishing Director", "Quality Assurance Specialist", "Quality Control Engineer", "Quality Control Inspector", "Radiology Manager", "Railroad Engineer", "Real Estate Broker", "Recreational Director", "Recruiter", "Redevelopment Specialist", "Regulatory Affairs Manager", "Registered Nurse", "Rehabilitation Counselor", "Relocation Manager", "Reporter", "Research Specialist", "Restaurant Manager", "Retail Store Manager", "Risk Analyst", "Safety Engineer", "Sales Engineer", "Sales Trainer", "Sales Promotion Manager", "Sales Representative", "Sales Manager", "Service Manager", "Sanitation Engineer", "Scientific Programmer", "Scientific Writer", "Securities Analyst", "Security Consultant", "Security Director", "Seminar Presenter", "Ship\'s Officer", "Singer", "Social Director", "Social Program Planner", "Social Research", "Social Scientist", "Social Worker", "Sociologist", "Software Developer", "Software Engineer", "Software Test Engineer", "Soil Scientist", "Special Events Manager", "Special Education Teacher", "Special Projects Director", "Speech Pathologist", "Speech Writer", "Sports Event Manager", "Statistician", "Store Manager", "Strategic Alliance Director", "Strategic Planning Director", "Stress Reduction Specialist", "Stockbroker", "Surveyor", "Structural Engineer", "Superintendent", "Supply Chain Director", "System Engineer", "Systems Analyst", "Systems Programmer", "System Administrator", "Tax Specialist", "Teacher", "Technical Support Specialist", "Technical Illustrator", "Technical Writer", "Technology Director", "Telecom Analyst", "Telemarketer", "Theatrical Director", "Title Examiner", "Tour Escort", "Tour Guide Director", "Traffic Manager", "Trainer Translator", "Transportation Manager", "Travel Agent", "Treasurer", "TV Programmer", "Underwriter", "Union Representative", "University Administrator", "University Dean", "Urban Planner", "Veterinarian", "Vendor Relaions Director", "Viticulturist", "Warehouse Manager"
			};
		}

		public static string[] Companies =
		{
			"3Com Corp", "3M Company", "A.G. Edwards Inc.", "Abbott Laboratories", "Abercrombie & Fitch Co.", "ABM Industries Incorporated", "Ace Hardware Corporation", "ACT Manufacturing Inc.", "Acterna Corp.", "Adams Resources & Energy, Inc.", "ADC Telecommunications, Inc.", "Adelphia Communications Corporation", "Administaff, Inc.", "Adobe Systems Incorporated", "Adolph Coors Company", "Advance Auto Parts, Inc.", "Advanced Micro Devices, Inc.", "AdvancePCS, Inc.", "Advantica Restaurant Group, Inc.", "The AES Corporation", "Aetna Inc.", "Affiliated Computer Services, Inc.", "AFLAC Incorporated", "AGCO Corporation", "Agilent Technologies, Inc.", "Agway Inc.", "Apartment Investment and Management Company", "Air Products and Chemicals, Inc.", "Airborne, Inc.", "Airgas, Inc.", "AK Steel Holding Corporation", "Alaska Air Group, Inc.", "Alberto-Culver Company", "Albertson\'s, Inc.", "Alcoa Inc.", "Alleghany Corporation", "Allegheny Energy, Inc.", "Allegheny Technologies Incorporated", "Allergan, Inc.", "ALLETE, Inc.", "Alliant Energy Corporation", "Allied Waste Industries, Inc.", "Allmerica Financial Corporation", "The Allstate Corporation", "ALLTEL Corporation", "The Alpine Group, Inc.", "Amazon.com, Inc.", "AMC Entertainment Inc.", "American Power Conversion Corporation", "Amerada Hess Corporation", "AMERCO", "Ameren Corporation", "America West Holdings Corporation", "American Axle & Manufacturing Holdings, Inc.", "American Eagle Outfitters, Inc.", "American Electric Power Company, Inc.", "American Express Company", "American Financial Group, Inc.", "American Greetings Corporation", "American International Group, Inc.", "American Standard Companies Inc.", "American Water Works Company, Inc.", "AmerisourceBergen Corporation", "Ames Department Stores, Inc.", "Amgen Inc.", "Amkor Technology, Inc.", "AMR Corporation", "AmSouth Bancorp.", "Amtran, Inc.", "Anadarko Petroleum Corporation", "Analog Devices, Inc.", "Anheuser-Busch Companies, Inc.", "Anixter International Inc.", "AnnTaylor Inc.", "Anthem, Inc.", "AOL Time Warner Inc.", "Aon Corporation", "Apache Corporation", "Apple Computer, Inc.", "Applera Corporation", "Applied Industrial Technologies, Inc.", "Applied Materials, Inc.", "Aquila, Inc.", "ARAMARK Corporation", "Arch Coal, Inc.", "Archer Daniels Midland Company", "Arkansas Best Corporation", "Armstrong Holdings, Inc.", "Arrow Electronics, Inc.", "ArvinMeritor, Inc.", "Ashland Inc.", "Astoria Financial Corporation", "AT&T Corp.", "Atmel Corporation", "Atmos Energy Corporation", "Audiovox Corporation", "Autoliv, Inc.", "Automatic Data Processing, Inc.", "AutoNation, Inc.", "AutoZone, Inc.", "Avaya Inc.", "Avery Dennison Corporation", "Avista Corporation", "Avnet, Inc.", "Avon Products, Inc.", "Baker Hughes Incorporated", "Ball Corporation", "Bank of America Corporation", "The Bank of New York Company, Inc.", "Bank One Corporation", "Banknorth Group, Inc.", "Banta Corporation", "Barnes & Noble, Inc.", "Bausch & Lomb Incorporated", "Baxter International Inc.", "BB&T Corporation", "The Bear Stearns Companies Inc.", "Beazer Homes USA, Inc.", "Beckman Coulter, Inc.", "Becton, Dickinson and Company", "Bed Bath & Beyond Inc.", "Belk, Inc.", "Bell Microproducts Inc.", "BellSouth Corporation", "Belo Corp.", "Bemis Company, Inc.", "Benchmark Electronics, Inc.", "Berkshire Hathaway Inc.", "Best Buy Co., Inc.", "Bethlehem Steel Corporation", "Beverly Enterprises, Inc.", "Big Lots, Inc.", "BJ Services Company", "BJ\'s Wholesale Club, Inc.", "The Black & Decker Corporation", "Black Hills Corporation", "BMC Software, Inc.", "The Boeing Company", "Boise Cascade Corporation", "Borders Group, Inc.", "BorgWarner Inc.", "Boston Scientific Corporation", "Bowater Incorporated", "Briggs & Stratton Corporation", "Brightpoint, Inc.", "Brinker International, Inc.", "Bristol-Myers Squibb Company", "Broadwing, Inc.", "Brown Shoe Company, Inc.", "Brown-Forman Corporation", "Brunswick Corporation", "Budget Group, Inc.", "Burlington Coat Factory Warehouse Corporation", "Burlington Industries, Inc.", "Burlington Northern Santa Fe Corporation", "Burlington Resources Inc.", "C. H. Robinson Worldwide Inc.", "Cablevision Systems Corp", "Cabot Corp", "Cadence Design Systems, Inc.", "Calpine Corp.", "Campbell Soup Co.", "Capital One Financial Corp.", "Cardinal Health Inc.", "Caremark Rx Inc.", "Carlisle Cos. Inc.", "Carpenter Technology Corp.", "Casey\'s General Stores Inc.", "Caterpillar Inc.", "CBRL Group Inc.", "CDI Corp.", "CDW Computer Centers Inc.", "CellStar Corp.", "Cendant Corp", "Cenex Harvest States Cooperatives", "Centex Corp.", "CenturyTel Inc.", "Ceridian Corp.", "CH2M Hill Cos. Ltd.", "Champion Enterprises Inc.", "Charles Schwab Corp.", "Charming Shoppes Inc.", "Charter Communications Inc.", "Charter One Financial Inc.", "ChevronTexaco Corp.", "Chiquita Brands International Inc.", "Chubb Corp", "Ciena Corp.", "Cigna Corp", "Cincinnati Financial Corp.", "Cinergy Corp.", "Cintas Corp.", "Circuit City Stores Inc.", "Cisco Systems Inc.", "Citigroup, Inc", "Citizens Communications Co.", "CKE Restaurants Inc.", "Clear Channel Communications Inc.", "The Clorox Co.", "CMGI Inc.", "CMS Energy Corp.", "CNF Inc.", "Coca-Cola Co.", "Coca-Cola Enterprises Inc.", "Colgate-Palmolive Co.", "Collins & Aikman Corp.", "Comcast Corp.", "Comdisco Inc.", "Comerica Inc.", "Comfort Systems USA Inc.", "Commercial Metals Co.", "Community Health Systems Inc.", "Compass Bancshares Inc", "Computer Associates International Inc.", "Computer Sciences Corp.", "Compuware Corp.", "Comverse Technology Inc.", "ConAgra Foods Inc.", "Concord EFS Inc.", "Conectiv, Inc", "Conoco Inc", "Conseco Inc.", "Consolidated Freightways Corp.", "Consolidated Edison Inc.", "Constellation Brands Inc.", "Constellation Emergy Group Inc.", "Continental Airlines Inc.", "Convergys Corp.", "Cooper Cameron Corp.", "Cooper Industries Ltd.", "Cooper Tire & Rubber Co.", "Corn Products International Inc.", "Corning Inc.", "Costco Wholesale Corp.", "Countrywide Credit Industries Inc.", "Coventry Health Care Inc.", "Cox Communications Inc.", "Crane Co.", "Crompton Corp.", "Crown Cork & Seal Co. Inc.", "CSK Auto Corp.", "CSX Corp.", "Cummins Inc.", "CVS Corp.", "Cytec Industries Inc.", "D&K Healthcare Resources, Inc.", "D.R. Horton Inc.", "Dana Corporation", "Danaher Corporation", "Darden Restaurants Inc.", "DaVita Inc.", "Dean Foods Company", "Deere & Company", "Del Monte Foods Co", "Dell Computer Corporation", "Delphi Corp.", "Delta Air Lines Inc.", "Deluxe Corporation", "Devon Energy Corporation", "Di Giorgio Corporation", "Dial Corporation", "Diebold Incorporated", "Dillard\'s Inc.", "DIMON Incorporated", "Dole Food Company, Inc.", "Dollar General Corporation", "Dollar Tree Stores, Inc.", "Dominion Resources, Inc.", "Domino\'s Pizza LLC", "Dover Corporation, Inc.", "Dow Chemical Company", "Dow Jones & Company, Inc.", "DPL Inc.", "DQE Inc.", "Dreyer\'s Grand Ice Cream, Inc.", "DST Systems, Inc.", "DTE Energy Co.", "E.I. Du Pont de Nemours and Company", "Duke Energy Corp", "Dun & Bradstreet Inc.", "DURA Automotive Systems Inc.", "DynCorp", "Dynegy Inc.", "E*Trade Group, Inc.", "E.W. Scripps Company", "Earthlink, Inc.", "Eastman Chemical Company", "Eastman Kodak Company", "Eaton Corporation", "Echostar Communications Corporation", "Ecolab Inc.", "Edison International", "EGL Inc.", "El Paso Corporation", "Electronic Arts Inc.", "Electronic Data Systems Corp.", "Eli Lilly and Company", "EMC Corporation", "Emcor Group Inc.", "Emerson Electric Co.", "Encompass Services Corporation", "Energizer Holdings Inc.", "Energy East Corporation", "Engelhard Corporation", "Enron Corp.", "Entergy Corporation", "Enterprise Products Partners L.P.", "EOG Resources, Inc.", "Equifax Inc.", "Equitable Resources Inc.", "Equity Office Properties Trust", "Equity Residential Properties Trust", "Estee Lauder Companies Inc.", "Exelon Corporation", "Exide Technologies", "Expeditors International of Washington Inc.", "Express Scripts Inc.", "ExxonMobil Corporation", "Fairchild Semiconductor International Inc.", "Family Dollar Stores Inc.", "Farmland Industries Inc.", "Federal Mogul Corp.", "Federated Department Stores Inc.", "Federal Express Corp.", "Felcor Lodging Trust Inc.", "Ferro Corp.", "Fidelity National Financial Inc.", "Fifth Third Bancorp", "First American Financial Corp.", "First Data Corp.", "First National of Nebraska Inc.", "First Tennessee National Corp.", "FirstEnergy Corp.", "Fiserv Inc.", "Fisher Scientific International Inc.", "FleetBoston Financial Co.", "Fleetwood Enterprises Inc.", "Fleming Companies Inc.", "Flowers Foods Inc.", "Flowserv Corp", "Fluor Corp", "FMC Corp", "Foamex International Inc", "Foot Locker Inc", "Footstar Inc.", "Ford Motor Co", "Forest Laboratories Inc.", "Fortune Brands Inc.", "Foster Wheeler Ltd.", "FPL Group Inc.", "Franklin Resources Inc.", "Freeport McMoran Copper & Gold Inc.", "Frontier Oil Corp", "Furniture Brands International Inc.", "Gannett Co., Inc.", "Gap Inc.", "Gateway Inc.", "GATX Corporation", "Gemstar-TV Guide International Inc.", "GenCorp Inc.", "General Cable Corporation", "General Dynamics Corporation", "General Electric Company", "General Mills Inc", "General Motors Corporation", "Genesis Health Ventures Inc.", "Gentek Inc.", "Gentiva Health Services Inc.", "Genuine Parts Company", "Genuity Inc.", "Genzyme Corporation", "Georgia Gulf Corporation", "Georgia-Pacific Corporation", "Gillette Company", "Gold Kist Inc.", "Golden State Bancorp Inc.", "Golden West Financial Corporation", "Goldman Sachs Group Inc.", "Goodrich Corporation", "The Goodyear Tire & Rubber Company", "Granite Construction Incorporated", "Graybar Electric Company Inc.", "Great Lakes Chemical Corporation", "Great Plains Energy Inc.", "GreenPoint Financial Corp.", "Greif Bros. Corporation", "Grey Global Group Inc.", "Group 1 Automotive Inc.", "Guidant Corporation", "H&R Block Inc.", "H.B. Fuller Company", "H.J. Heinz Company", "Halliburton Co.", "Harley-Davidson Inc.", "Harman International Industries Inc.", "Harrah\'s Entertainment Inc.", "Harris Corp.", "Harsco Corp.", "Hartford Financial Services Group Inc.", "Hasbro Inc.", "Hawaiian Electric Industries Inc.", "HCA Inc.", "Health Management Associates Inc.", "Health Net Inc.", "Healthsouth Corp", "Henry Schein Inc.", "Hercules Inc.", "Herman Miller Inc.", "Hershey Foods Corp.", "Hewlett-Packard Company", "Hibernia Corp.", "Hillenbrand Industries Inc.", "Hilton Hotels Corp.", "Hollywood Entertainment Corp.", "Home Depot Inc.", "Hon Industries Inc.", "Honeywell International Inc.", "Hormel Foods Corp.", "Host Marriott Corp.", "Household International Corp.", "Hovnanian Enterprises Inc.", "Hub Group Inc.", "Hubbell Inc.", "Hughes Supply Inc.", "Humana Inc.", "Huntington Bancshares Inc.", "Idacorp Inc.", "IDT Corporation", "IKON Office Solutions Inc.", "Illinois Tool Works Inc.", "IMC Global Inc.", "Imperial Sugar Company", "IMS Health Inc.", "Ingles Market Inc", "Ingram Micro Inc.", "Insight Enterprises Inc.", "Integrated Electrical Services Inc.", "Intel Corporation", "International Paper Co.", "Interpublic Group of Companies Inc.", "Interstate Bakeries Corporation", "International Business Machines Corp.", "International Flavors & Fragrances Inc.", "International Multifoods Corporation", "Intuit Inc.", "IT Group Inc.", "ITT Industries Inc.", "Ivax Corp.", "J.B. Hunt Transport Services Inc.", "J.C. Penny Co.", "J.P. Morgan Chase & Co.", "Jabil Circuit Inc.", "Jack In The Box Inc.", "Jacobs Engineering Group Inc.", "JDS Uniphase Corp.", "Jefferson-Pilot Co.", "John Hancock Financial Services Inc.", "Johnson & Johnson", "Johnson Controls Inc.", "Jones Apparel Group Inc.", "KB Home", "Kellogg Company", "Kellwood Company", "Kelly Services Inc.", "Kemet Corp.", "Kennametal Inc.", "Kerr-McGee Corporation", "KeyCorp", "KeySpan Corp.", "Kimball International Inc.", "Kimberly-Clark Corporation", "Kindred Healthcare Inc.", "KLA-Tencor Corporation", "K-Mart Corp.", "Knight-Ridder Inc.", "Kohl\'s Corp.", "KPMG Consulting Inc.", "Kroger Co.", "L-3 Communications Holdings Inc.", "Laboratory Corporation of America Holdings", "Lam Research Corporation", "LandAmerica Financial Group Inc.", "Lands\' End Inc.", "Landstar System Inc.", "La-Z-Boy Inc.", "Lear Corporation", "Legg Mason Inc.", "Leggett & Platt Inc.", "Lehman Brothers Holdings Inc.", "Lennar Corporation", "Lennox International Inc.", "Level 3 Communications Inc.", "Levi Strauss & Co.", "Lexmark International Inc.", "Limited Inc.", "Lincoln National Corporation", "Linens \'n Things Inc.", "Lithia Motors Inc.", "Liz Claiborne Inc.", "Lockheed Martin Corporation", "Loews Corporation", "Longs Drug Stores Corporation", "Louisiana-Pacific Corporation", "Lowe\'s Companies Inc.", "LSI Logic Corporation", "The LTV Corporation", "The Lubrizol Corporation", "Lucent Technologies Inc.", "Lyondell Chemical Company", "M & T Bank Corporation", "Magellan Health Services Inc.", "Mail-Well Inc.", "Mandalay Resort Group", "Manor Care Inc.", "Manpower Inc.", "Marathon Oil Corporation", "Mariner Health Care Inc.", "Markel Corporation", "Marriott International Inc.", "Marsh & McLennan Companies Inc.", "Marsh Supermarkets Inc.", "Marshall & Ilsley Corporation", "Martin Marietta Materials Inc.", "Masco Corporation", "Massey Energy Company", "MasTec Inc.", "Mattel Inc.", "Maxim Integrated Products Inc.", "Maxtor Corporation", "Maxxam Inc.", "The May Department Stores Company", "Maytag Corporation", "MBNA Corporation", "McCormick & Company Incorporated", "McDonald\'s Corporation", "The McGraw-Hill Companies Inc.", "McKesson Corporation", "McLeodUSA Incorporated", "M.D.C. Holdings Inc.", "MDU Resources Group Inc.", "MeadWestvaco Corporation", "Medtronic Inc.", "Mellon Financial Corporation", "The Men\'s Wearhouse Inc.", "Merck & Co., Inc.", "Mercury General Corporation", "Merrill Lynch & Co. Inc.", "Metaldyne Corporation", "Metals USA Inc.", "MetLife Inc.", "Metris Companies Inc", "MGIC Investment Corporation", "MGM Mirage", "Michaels Stores Inc.", "Micron Technology Inc.", "Microsoft Corporation", "Milacron Inc.", "Millennium Chemicals Inc.", "Mirant Corporation", "Mohawk Industries Inc.", "Molex Incorporated", "The MONY Group Inc.", "Morgan Stanley Dean Witter & Co.", "Motorola Inc.", "MPS Group Inc.", "Murphy Oil Corporation", "Nabors Industries Inc", "Nacco Industries Inc", "Nash Finch Company", "National City Corp.", "National Commerce Financial Corporation", "National Fuel Gas Company", "National Oilwell Inc", "National Rural Utilities Cooperative Finance Corporation", "National Semiconductor Corporation", "National Service Industries Inc", "Navistar International Corporation", "NCR Corporation", "The Neiman Marcus Group Inc.", "New Jersey Resources Corporation", "New York Times Company", "Newell Rubbermaid Inc", "Newmont Mining Corporation", "Nextel Communications Inc", "Nicor Inc", "Nike Inc", "NiSource Inc", "Noble Energy Inc", "Nordstrom Inc", "Norfolk Southern Corporation", "Nortek Inc", "North Fork Bancorporation Inc", "Northeast Utilities System", "Northern Trust Corporation", "Northrop Grumman Corporation", "NorthWestern Corporation", "Novellus Systems Inc", "NSTAR", "NTL Incorporated", "Nucor Corp", "Nvidia Corp", "NVR Inc", "Northwest Airlines Corp", "Occidental Petroleum Corp", "Ocean Energy Inc", "Office Depot Inc.", "OfficeMax Inc", "OGE Energy Corp", "Oglethorpe Power Corp.", "Ohio Casualty Corp.", "Old Republic International Corp.", "Olin Corp.", "OM Group Inc", "Omnicare Inc", "Omnicom Group", "On Semiconductor Corp", "ONEOK Inc", "Oracle Corp", "Oshkosh Truck Corp", "Outback Steakhouse Inc.", "Owens & Minor Inc.", "Owens Corning", "Owens-Illinois Inc", "Oxford Health Plans Inc", "Paccar Inc", "PacifiCare Health Systems Inc", "Packaging Corp. of America", "Pactiv Corp", "Pall Corp", "Pantry Inc", "Park Place Entertainment Corp", "Parker Hannifin Corp.", "Pathmark Stores Inc.", "Paychex Inc", "Payless Shoesource Inc", "Penn Traffic Co.", "Pennzoil-Quaker State Company", "Pentair Inc", "Peoples Energy Corp.", "PeopleSoft Inc", "Pep Boys Manny, Moe & Jack", "Potomac Electric Power Co.", "Pepsi Bottling Group Inc.", "PepsiAmericas Inc.", "PepsiCo Inc.", "Performance Food Group Co.", "Perini Corp", "PerkinElmer Inc", "Perot Systems Corp", "Petco Animal Supplies Inc.", "Peter Kiewit Sons\', Inc.", "PETsMART Inc", "Pfizer Inc", "Pacific Gas & Electric Corp.", "Pharmacia Corp", "Phar Mor Inc.", "Phelps Dodge Corp.", "Philip Morris Companies Inc.", "Phillips Petroleum Co", "Phillips Van Heusen Corp.", "Phoenix Companies Inc", "Pier 1 Imports Inc.", "Pilgrim\'s Pride Corporation", "Pinnacle West Capital Corp", "Pioneer-Standard Electronics Inc.", "Pitney Bowes Inc.", "Pittston Brinks Group", "Plains All American Pipeline LP", "PNC Financial Services Group Inc.", "PNM Resources Inc", "Polaris Industries Inc.", "Polo Ralph Lauren Corp", "PolyOne Corp", "Popular Inc", "Potlatch Corp", "PPG Industries Inc", "PPL Corp", "Praxair Inc", "Precision Castparts Corp", "Premcor Inc.", "Pride International Inc", "Primedia Inc", "Principal Financial Group Inc.", "Procter & Gamble Co.", "Pro-Fac Cooperative Inc.", "Progress Energy Inc", "Progressive Corporation", "Protective Life Corp", "Provident Financial Group", "Providian Financial Corp.", "Prudential Financial Inc.", "PSS World Medical Inc", "Public Service Enterprise Group Inc.", "Publix Super Markets Inc.", "Puget Energy Inc.", "Pulte Homes Inc", "Qualcomm Inc", "Quanta Services Inc.", "Quantum Corp", "Quest Diagnostics Inc.", "Questar Corp", "Quintiles Transnational", "Qwest Communications Intl Inc", "R.J. Reynolds Tobacco Company", "R.R. Donnelley & Sons Company", "Radio Shack Corporation", "Raymond James Financial Inc.", "Raytheon Company", "Reader\'s Digest Association Inc.", "Reebok International Ltd.", "Regions Financial Corp.", "Regis Corporation", "Reliance Steel & Aluminum Co.", "Reliant Energy Inc.", "Rent A Center Inc", "Republic Services Inc", "Revlon Inc", "RGS Energy Group Inc", "Rite Aid Corp", "Riverwood Holding Inc.", "RoadwayCorp", "Robert Half International Inc.", "Rock-Tenn Co", "Rockwell Automation Inc", "Rockwell Collins Inc", "Rohm & Haas Co.", "Ross Stores Inc", "RPM Inc.", "Ruddick Corp", "Ryder System Inc", "Ryerson Tull Inc", "Ryland Group Inc.", "Sabre Holdings Corp", "Safeco Corp", "Safeguard Scientifics Inc.", "Safeway Inc", "Saks Inc", "Sanmina-SCI Inc", "Sara Lee Corp", "SBC Communications Inc", "Scana Corp.", "Schering-Plough Corp", "Scholastic Corp", "SCI Systems Onc.", "Science Applications Intl. Inc.", "Scientific-Atlanta Inc", "Scotts Company", "Seaboard Corp", "Sealed Air Corp", "Sears Roebuck & Co", "Sempra Energy", "Sequa Corp", "Service Corp. International", "ServiceMaster Co", "Shaw Group Inc", "Sherwin-Williams Company", "Shopko Stores Inc", "Siebel Systems Inc", "Sierra Health Services Inc", "Sierra Pacific Resources", "Silgan Holdings Inc.", "Silicon Graphics Inc", "Simon Property Group Inc", "SLM Corporation", "Smith International Inc", "Smithfield Foods Inc", "Smurfit-Stone Container Corp", "Snap-On Inc", "Solectron Corp", "Solutia Inc", "Sonic Automotive Inc.", "Sonoco Products Co.", "Southern Company", "Southern Union Company", "SouthTrust Corp.", "Southwest Airlines Co", "Southwest Gas Corp", "Sovereign Bancorp Inc.", "Spartan Stores Inc", "Spherion Corp", "Sports Authority Inc", "Sprint Corp.", "SPX Corp", "St. Jude Medical Inc", "St. Paul Cos.", "Staff Leasing Inc.", "StanCorp Financial Group Inc", "Standard Pacific Corp.", "Stanley Works", "Staples Inc", "Starbucks Corp", "Starwood Hotels & Resorts Worldwide Inc", "State Street Corp.", "Stater Bros. Holdings Inc.", "Steelcase Inc", "Stein Mart Inc", "Stewart & Stevenson Services Inc", "Stewart Information Services Corp", "Stilwell Financial Inc", "Storage Technology Corporation", "Stryker Corp", "Sun Healthcare Group Inc.", "Sun Microsystems Inc.", "SunGard Data Systems Inc.", "Sunoco Inc.", "SunTrust Banks Inc", "Supervalu Inc", "Swift Transportation, Co., Inc", "Symbol Technologies Inc", "Synovus Financial Corp.", "Sysco Corp", "Systemax Inc.", "Target Corp.", "Tech Data Corporation", "TECO Energy Inc", "Tecumseh Products Company", "Tektronix Inc", "Teleflex Incorporated", "Telephone & Data Systems Inc", "Tellabs Inc.", "Temple-Inland Inc", "Tenet Healthcare Corporation", "Tenneco Automotive Inc.", "Teradyne Inc", "Terex Corp", "Tesoro Petroleum Corp.", "Texas Industries Inc.", "Texas Instruments Incorporated", "Textron Inc", "Thermo Electron Corporation", "Thomas & Betts Corporation", "Tiffany & Co", "Timken Company", "TJX Companies Inc", "TMP Worldwide Inc", "Toll Brothers Inc", "Torchmark Corporation", "Toro Company", "Tower Automotive Inc.", "Toys \'R\' Us Inc", "Trans World Entertainment Corp.", "TransMontaigne Inc", "Transocean Inc", "TravelCenters of America Inc.", "Triad Hospitals Inc", "Tribune Company", "Trigon Healthcare Inc.", "Trinity Industries Inc", "Trump Hotels & Casino Resorts Inc.", "TruServ Corporation", "TRW Inc", "TXU Corp", "Tyson Foods Inc", "U.S. Bancorp", "U.S. Industries Inc.", "UAL Corporation", "UGI Corporation", "Unified Western Grocers Inc", "Union Pacific Corporation", "Union Planters Corp", "Unisource Energy Corp", "Unisys Corporation", "United Auto Group Inc", "United Defense Industries Inc.", "United Parcel Service Inc", "United Rentals Inc", "United Stationers Inc", "United Technologies Corporation", "UnitedHealth Group Incorporated", "Unitrin Inc", "Universal Corporation", "Universal Forest Products Inc", "Universal Health Services Inc", "Unocal Corporation", "Unova Inc", "UnumProvident Corporation", "URS Corporation", "US Airways Group Inc", "US Oncology Inc", "USA Interactive", "USFreighways Corporation", "USG Corporation", "UST Inc", "Valero Energy Corporation", "Valspar Corporation", "Value City Department Stores Inc", "Varco International Inc", "Vectren Corporation", "Veritas Software Corporation", "Verizon Communications Inc", "VF Corporation", "Viacom Inc", "Viad Corp", "Viasystems Group Inc", "Vishay Intertechnology Inc", "Visteon Corporation", "Volt Information Sciences Inc", "Vulcan Materials Company", "W.R. Berkley Corporation", "W.R. Grace & Co", "W.W. Grainger Inc", "Wachovia Corporation", "Wakenhut Corporation", "Walgreen Co", "Wallace Computer Services Inc", "Wal-Mart Stores Inc", "Walt Disney Co", "Walter Industries Inc", "Washington Mutual Inc", "Washington Post Co.", "Waste Management Inc", "Watsco Inc", "Weatherford International Inc", "Weis Markets Inc.", "Wellpoint Health Networks Inc", "Wells Fargo & Company", "Wendy\'s International Inc", "Werner Enterprises Inc", "WESCO International Inc", "Western Digital Inc", "Western Gas Resources Inc", "WestPoint Stevens Inc", "Weyerhauser Company", "WGL Holdings Inc", "Whirlpool Corporation", "Whole Foods Market Inc", "Willamette Industries Inc.", "Williams Companies Inc", "Williams Sonoma Inc", "Winn Dixie Stores Inc", "Wisconsin Energy Corporation", "Wm Wrigley Jr Company", "World Fuel Services Corporation", "WorldCom Inc", "Worthington Industries Inc", "WPS Resources Corporation", "Wyeth", "Wyndham International Inc", "Xcel Energy Inc", "Xerox Corp", "Xilinx Inc", "XO Communications Inc", "Yellow Corporation", "York International Corp", "Yum Brands Inc.", "Zale Corporation", "Zions Bancorporation"
		};

		public static class FileExtensions
		{
			public static string[] Raster =
			{
				"bmp", "gif", "gpl", "ico", "jpeg", "psd", "png", "psp", "raw", "tiff"
			};

			public static string[] Vector =
			{
				"3dv", "amf", "awg", "ai", "cgm", "cdr", "cmx", "dxf", "e2d", "egt", "eps", "fs", "odg", "svg", "xar"
			};

			public static string[] _3D =
			{
				"3dmf", "3dm", "3mf", "3ds", "an8", "aoi", "blend", "cal3d", "cob", "ctm", "iob", "jas", "max", "mb", "mdx", "obj", "x", "x3d"
			};

			public static string[] Document =
			{
				"doc", "docx", "dot", "html", "xml", "odt", "odm", "ott", "csv", "rtf", "tex", "xhtml", "xps"
			};

			public static string[] Any
			{
				get
				{
					string[] combined = new string[Raster.Length + Vector.Length + _3D.Length + Document.Length];
					Raster.CopyTo(combined, 0);
					Vector.CopyTo(combined, Raster.Length);
					_3D.CopyTo(combined, Raster.Length + Vector.Length);
					Document.CopyTo(combined, Raster.Length + Vector.Length + _3D.Length);
					return combined;
				}
			}
		}

		public static IEnumerable<WorldCountry> Countries
		{
			get
			{
				yield return new WorldCountry("Afghanistan", "AF", "AFG", "004", false);
				yield return new WorldCountry("Aland Islands", "AX", "ALA", "248", false);
				yield return new WorldCountry("Albania", "AL", "ALB", "008", false);
				yield return new WorldCountry("Algeria", "DZ", "DZA", "012", false);
				yield return new WorldCountry("American Samoa", "AS", "ASM", "016", false);
				yield return new WorldCountry("Andorra", "AD", "AND", "020", false);
				yield return new WorldCountry("Angola", "AO", "AGO", "024", false);
				yield return new WorldCountry("Anguilla", "AI", "AIA", "660", false);
				yield return new WorldCountry("Antarctica", "AQ", "ATA", "010", false);
				yield return new WorldCountry("Antigua and Barbuda", "AG", "ATG", "028", false);
				yield return new WorldCountry("Argentina", "AR", "ARG", "032", false);
				yield return new WorldCountry("Armenia", "AM", "ARM", "051", false);
				yield return new WorldCountry("Aruba", "AW", "ABW", "533", false);
				yield return new WorldCountry("Australia", "AU", "AUS", "036", false);
				yield return new WorldCountry("Austria", "AT", "AUT", "040", false);
				yield return new WorldCountry("Azerbaijan", "AZ", "AZE", "031", false);
				yield return new WorldCountry("Bahamas", "BS", "BHS", "044", false);
				yield return new WorldCountry("Bahrain", "BH", "BHR", "048", false);
				yield return new WorldCountry("Bangladesh", "BD", "BGD", "050", false);
				yield return new WorldCountry("Barbados", "BB", "BRB", "052", false);
				yield return new WorldCountry("Belarus", "BY", "BLR", "112", false);
				yield return new WorldCountry("Belgium", "BE", "BEL", "056", false);
				yield return new WorldCountry("Belize", "BZ", "BLZ", "084", false);
				yield return new WorldCountry("Benin", "BJ", "BEN", "204", false);
				yield return new WorldCountry("Bermuda", "BM", "BMU", "060", false);
				yield return new WorldCountry("Bhutan", "BT", "BTN", "064", false);
				yield return new WorldCountry("Bolivia, Plurinational State of", "BO", "BOL", "068", false);
				yield return new WorldCountry("Bonaire, Sint Eustatius and Saba", "BQ", "BES", "535", false);
				yield return new WorldCountry("Bosnia and Herzegovina", "BA", "BIH", "070", false);
				yield return new WorldCountry("Botswana", "BW", "BWA", "072", false);
				yield return new WorldCountry("Bouvet Island", "BV", "BVT", "074", false);
				yield return new WorldCountry("Brazil", "BR", "BRA", "076", false);
				yield return new WorldCountry("British Indian Ocean Territory", "IO", "IOT", "086", false);
				yield return new WorldCountry("Brunei Darussalam", "BN", "BRN", "096", false);
				yield return new WorldCountry("Bulgaria", "BG", "BGR", "100", false);
				yield return new WorldCountry("Burkina Faso", "BF", "BFA", "854", false);
				yield return new WorldCountry("Burundi", "BI", "BDI", "108", false);
				yield return new WorldCountry("Cambodia", "KH", "KHM", "116", false);
				yield return new WorldCountry("Cameroon", "CM", "CMR", "120", false);
				yield return new WorldCountry("Canada", "CA", "CAN", "124", true);
				yield return new WorldCountry("Cape Verde", "CV", "CPV", "132", false);
				yield return new WorldCountry("Cayman Islands", "KY", "CYM", "136", false);
				yield return new WorldCountry("Central African Republic", "CF", "CAF", "140", false);
				yield return new WorldCountry("Chad", "TD", "TCD", "148", false);
				yield return new WorldCountry("Chile", "CL", "CHL", "152", false);
				yield return new WorldCountry("China", "CN", "CHN", "156", false);
				yield return new WorldCountry("Christmas Island", "CX", "CXR", "162", false);
				yield return new WorldCountry("Cocos (Keeling) Islands", "CC", "CCK", "166", false);
				yield return new WorldCountry("Colombia", "CO", "COL", "170", false);
				yield return new WorldCountry("Comoros", "KM", "COM", "174", false);
				yield return new WorldCountry("Congo", "CG", "COG", "178", false);
				yield return new WorldCountry("Congo, the Democratic Republic of the", "CD", "COD", "180", false);
				yield return new WorldCountry("Cook Islands", "CK", "COK", "184", false);
				yield return new WorldCountry("Costa Rica", "CR", "CRI", "188", false);
				yield return new WorldCountry("Cote d'Ivoire", "CI", "CIV", "384", false);
				yield return new WorldCountry("Croatia", "HR", "HRV", "191", false);
				yield return new WorldCountry("Cuba", "CU", "CUB", "192", false);
				yield return new WorldCountry("Curacao", "CW", "CUW", "531", false);
				yield return new WorldCountry("Cyprus", "CY", "CYP", "196", false);
				yield return new WorldCountry("Czech Republic", "CZ", "CZE", "203", false);
				yield return new WorldCountry("Denmark", "DK", "DNK", "208", false);
				yield return new WorldCountry("Djibouti", "DJ", "DJI", "262", false);
				yield return new WorldCountry("Dominica", "DM", "DMA", "212", false);
				yield return new WorldCountry("Dominican Republic", "DO", "DOM", "214", false);
				yield return new WorldCountry("Ecuador", "EC", "ECU", "218", false);
				yield return new WorldCountry("Egypt", "EG", "EGY", "818", false);
				yield return new WorldCountry("El Salvador", "SV", "SLV", "222", false);
				yield return new WorldCountry("Equatorial Guinea", "GQ", "GNQ", "226", false);
				yield return new WorldCountry("Eritrea", "ER", "ERI", "232", false);
				yield return new WorldCountry("Estonia", "EE", "EST", "233", false);
				yield return new WorldCountry("Ethiopia", "ET", "ETH", "231", false);
				yield return new WorldCountry("Falkland Islands (Malvinas)", "FK", "FLK", "238", false);
				yield return new WorldCountry("Faroe Islands", "FO", "FRO", "234", false);
				yield return new WorldCountry("Fiji", "FJ", "FJI", "242", false);
				yield return new WorldCountry("Finland", "FI", "FIN", "246", false);
				yield return new WorldCountry("France", "FR", "FRA", "250", false);
				yield return new WorldCountry("French Guiana", "GF", "GUF", "254", false);
				yield return new WorldCountry("French Polynesia", "PF", "PYF", "258", false);
				yield return new WorldCountry("French Southern Territories", "TF", "ATF", "260", false);
				yield return new WorldCountry("Gabon", "GA", "GAB", "266", false);
				yield return new WorldCountry("Gambia", "GM", "GMB", "270", false);
				yield return new WorldCountry("Georgia", "GE", "GEO", "268", false);
				yield return new WorldCountry("Germany", "DE", "DEU", "276", false);
				yield return new WorldCountry("Ghana", "GH", "GHA", "288", false);
				yield return new WorldCountry("Gibraltar", "GI", "GIB", "292", false);
				yield return new WorldCountry("Greece", "GR", "GRC", "300", false);
				yield return new WorldCountry("Greenland", "GL", "GRL", "304", false);
				yield return new WorldCountry("Grenada", "GD", "GRD", "308", false);
				yield return new WorldCountry("Guadeloupe", "GP", "GLP", "312", false);
				yield return new WorldCountry("Guam", "GU", "GUM", "316", false);
				yield return new WorldCountry("Guatemala", "GT", "GTM", "320", false);
				yield return new WorldCountry("Guernsey", "GG", "GGY", "831", false);
				yield return new WorldCountry("Guinea", "GN", "GIN", "324", false);
				yield return new WorldCountry("Guinea-Bissau", "GW", "GNB", "624", false);
				yield return new WorldCountry("Guyana", "GY", "GUY", "328", false);
				yield return new WorldCountry("Haiti", "HT", "HTI", "332", false);
				yield return new WorldCountry("Heard Island and McDonald Islands", "HM", "HMD", "334", false);
				yield return new WorldCountry("Holy See (Vatican City State)", "VA", "VAT", "336", false);
				yield return new WorldCountry("Honduras", "HN", "HND", "340", false);
				yield return new WorldCountry("Hong Kong", "HK", "HKG", "344", false);
				yield return new WorldCountry("Hungary", "HU", "HUN", "348", false);
				yield return new WorldCountry("Iceland", "IS", "ISL", "352", false);
				yield return new WorldCountry("India", "IN", "IND", "356", false);
				yield return new WorldCountry("Indonesia", "ID", "IDN", "360", false);
				yield return new WorldCountry("Iran, Islamic Republic of", "IR", "IRN", "364", false);
				yield return new WorldCountry("Iraq", "IQ", "IRQ", "368", false);
				yield return new WorldCountry("Ireland", "IE", "IRL", "372", false);
				yield return new WorldCountry("Isle of Man", "IM", "IMN", "833", false);
				yield return new WorldCountry("Israel", "IL", "ISR", "376", false);
				yield return new WorldCountry("Italy", "IT", "ITA", "380", false);
				yield return new WorldCountry("Jamaica", "JM", "JAM", "388", false);
				yield return new WorldCountry("Japan", "JP", "JPN", "392", false);
				yield return new WorldCountry("Jersey", "JE", "JEY", "832", false);
				yield return new WorldCountry("Jordan", "JO", "JOR", "400", false);
				yield return new WorldCountry("Kazakhstan", "KZ", "KAZ", "398", false);
				yield return new WorldCountry("Kenya", "KE", "KEN", "404", false);
				yield return new WorldCountry("Kiribati", "KI", "KIR", "296", false);
				yield return new WorldCountry("Korea, Democratic People's Republic of", "KP", "PRK", "408", false);
				yield return new WorldCountry("Korea, Republic of", "KR", "KOR", "410", false);
				yield return new WorldCountry("Kuwait", "KW", "KWT", "414", false);
				yield return new WorldCountry("Kyrgyzstan", "KG", "KGZ", "417", false);
				yield return new WorldCountry("Lao People's Democratic Republic", "LA", "LAO", "418", false);
				yield return new WorldCountry("Latvia", "LV", "LVA", "428", false);
				yield return new WorldCountry("Lebanon", "LB", "LBN", "422", false);
				yield return new WorldCountry("Lesotho", "LS", "LSO", "426", false);
				yield return new WorldCountry("Liberia", "LR", "LBR", "430", false);
				yield return new WorldCountry("Libya", "LY", "LBY", "434", false);
				yield return new WorldCountry("Liechtenstein", "LI", "LIE", "438", false);
				yield return new WorldCountry("Lithuania", "LT", "LTU", "440", false);
				yield return new WorldCountry("Luxembourg", "LU", "LUX", "442", false);
				yield return new WorldCountry("Macao", "MO", "MAC", "446", false);
				yield return new WorldCountry("Macedonia, the former Yugoslav Republic of", "MK", "MKD", "807", false);
				yield return new WorldCountry("Madagascar", "MG", "MDG", "450", false);
				yield return new WorldCountry("Malawi", "MW", "MWI", "454", false);
				yield return new WorldCountry("Malaysia", "MY", "MYS", "458", false);
				yield return new WorldCountry("Maldives", "MV", "MDV", "462", false);
				yield return new WorldCountry("Mali", "ML", "MLI", "466", false);
				yield return new WorldCountry("Malta", "MT", "MLT", "470", false);
				yield return new WorldCountry("Marshall Islands", "MH", "MHL", "584", false);
				yield return new WorldCountry("Martinique", "MQ", "MTQ", "474", false);
				yield return new WorldCountry("Mauritania", "MR", "MRT", "478", false);
				yield return new WorldCountry("Mauritius", "MU", "MUS", "480", false);
				yield return new WorldCountry("Mayotte", "YT", "MYT", "175", false);
				yield return new WorldCountry("Mexico", "MX", "MEX", "484", false);
				yield return new WorldCountry("Micronesia, Federated States of", "FM", "FSM", "583", false);
				yield return new WorldCountry("Moldova, Republic of", "MD", "MDA", "498", false);
				yield return new WorldCountry("Monaco", "MC", "MCO", "492", false);
				yield return new WorldCountry("Mongolia", "MN", "MNG", "496", false);
				yield return new WorldCountry("Montenegro", "ME", "MNE", "499", false);
				yield return new WorldCountry("Montserrat", "MS", "MSR", "500", false);
				yield return new WorldCountry("Morocco", "MA", "MAR", "504", false);
				yield return new WorldCountry("Mozambique", "MZ", "MOZ", "508", false);
				yield return new WorldCountry("Myanmar", "MM", "MMR", "104", false);
				yield return new WorldCountry("Namibia", "NA", "NAM", "516", false);
				yield return new WorldCountry("Nauru", "NR", "NRU", "520", false);
				yield return new WorldCountry("Nepal", "NP", "NPL", "524", false);
				yield return new WorldCountry("Netherlands", "NL", "NLD", "528", false);
				yield return new WorldCountry("New Caledonia", "NC", "NCL", "540", false);
				yield return new WorldCountry("New Zealand", "NZ", "NZL", "554", false);
				yield return new WorldCountry("Nicaragua", "NI", "NIC", "558", false);
				yield return new WorldCountry("Niger", "NE", "NER", "562", false);
				yield return new WorldCountry("Nigeria", "NG", "NGA", "566", false);
				yield return new WorldCountry("Niue", "NU", "NIU", "570", false);
				yield return new WorldCountry("Norfolk Island", "NF", "NFK", "574", false);
				yield return new WorldCountry("Northern Mariana Islands", "MP", "MNP", "580", false);
				yield return new WorldCountry("Norway", "NO", "NOR", "578", false);
				yield return new WorldCountry("Oman", "OM", "OMN", "512", false);
				yield return new WorldCountry("Pakistan", "PK", "PAK", "586", false);
				yield return new WorldCountry("Palau", "PW", "PLW", "585", false);
				yield return new WorldCountry("Palestine, State of", "PS", "PSE", "275", false);
				yield return new WorldCountry("Panama", "PA", "PAN", "591", false);
				yield return new WorldCountry("Papua New Guinea", "PG", "PNG", "598", false);
				yield return new WorldCountry("Paraguay", "PY", "PRY", "600", false);
				yield return new WorldCountry("Peru", "PE", "PER", "604", false);
				yield return new WorldCountry("Philippines", "PH", "PHL", "608", false);
				yield return new WorldCountry("Pitcairn", "PN", "PCN", "612", false);
				yield return new WorldCountry("Poland", "PL", "POL", "616", false);
				yield return new WorldCountry("Portugal", "PT", "PRT", "620", false);
				yield return new WorldCountry("Puerto Rico", "PR", "PRI", "630", false);
				yield return new WorldCountry("Qatar", "QA", "QAT", "634", false);
				yield return new WorldCountry("Reunion", "RE", "REU", "638", false);
				yield return new WorldCountry("Romania", "RO", "ROU", "642", false);
				yield return new WorldCountry("Russian Federation", "RU", "RUS", "643", false);
				yield return new WorldCountry("Rwanda", "RW", "RWA", "646", false);
				yield return new WorldCountry("Saint BarthÃ©lemy", "BL", "BLM", "652", false);
				yield return new WorldCountry("Saint Helena, Ascension and Tristan da Cunha", "SH", "SHN", "654", false);
				yield return new WorldCountry("Saint Kitts and Nevis", "KN", "KNA", "659", false);
				yield return new WorldCountry("Saint Lucia", "LC", "LCA", "662", false);
				yield return new WorldCountry("Saint Martin (French part)", "MF", "MAF", "663", false);
				yield return new WorldCountry("Saint Pierre and Miquelon", "PM", "SPM", "666", false);
				yield return new WorldCountry("Saint Vincent and the Grenadines", "VC", "VCT", "670", false);
				yield return new WorldCountry("Samoa", "WS", "WSM", "882", false);
				yield return new WorldCountry("San Marino", "SM", "SMR", "674", false);
				yield return new WorldCountry("Sao Tome and Principe", "ST", "STP", "678", false);
				yield return new WorldCountry("Saudi Arabia", "SA", "SAU", "682", false);
				yield return new WorldCountry("Senegal", "SN", "SEN", "686", false);
				yield return new WorldCountry("Serbia", "RS", "SRB", "688", false);
				yield return new WorldCountry("Seychelles", "SC", "SYC", "690", false);
				yield return new WorldCountry("Sierra Leone", "SL", "SLE", "694", false);
				yield return new WorldCountry("Singapore", "SG", "SGP", "702", false);
				yield return new WorldCountry("Sint Maarten (Dutch part)", "SX", "SXM", "534", false);
				yield return new WorldCountry("Slovakia", "SK", "SVK", "703", false);
				yield return new WorldCountry("Slovenia", "SI", "SVN", "705", false);
				yield return new WorldCountry("Solomon Islands", "SB", "SLB", "090", false);
				yield return new WorldCountry("Somalia", "SO", "SOM", "706", false);
				yield return new WorldCountry("South Africa", "ZA", "ZAF", "710", false);
				yield return new WorldCountry("South Georgia and the South Sandwich Islands", "GS", "SGS", "239", false);
				yield return new WorldCountry("South Sudan", "SS", "SSD", "728", false);
				yield return new WorldCountry("Spain", "ES", "ESP", "724", false);
				yield return new WorldCountry("Sri Lanka", "LK", "LKA", "144", false);
				yield return new WorldCountry("Sudan", "SD", "SDN", "729", false);
				yield return new WorldCountry("Suriname", "SR", "SUR", "740", false);
				yield return new WorldCountry("Svalbard and Jan Mayen", "SJ", "SJM", "744", false);
				yield return new WorldCountry("Swaziland", "SZ", "SWZ", "748", false);
				yield return new WorldCountry("Sweden", "SE", "SWE", "752", false);
				yield return new WorldCountry("Switzerland", "CH", "CHE", "756", false);
				yield return new WorldCountry("Syrian Arab Republic", "SY", "SYR", "760", false);
				yield return new WorldCountry("Taiwan, Province of China", "TW", "TWN", "158", false);
				yield return new WorldCountry("Tajikistan", "TJ", "TJK", "762", false);
				yield return new WorldCountry("Tanzania, United Republic of", "TZ", "TZA", "834", false);
				yield return new WorldCountry("Thailand", "TH", "THA", "764", false);
				yield return new WorldCountry("Timor-Leste", "TL", "TLS", "626", false);
				yield return new WorldCountry("Togo", "TG", "TGO", "768", false);
				yield return new WorldCountry("Tokelau", "TK", "TKL", "772", false);
				yield return new WorldCountry("Tonga", "TO", "TON", "776", false);
				yield return new WorldCountry("Trinidad and Tobago", "TT", "TTO", "780", false);
				yield return new WorldCountry("Tunisia", "TN", "TUN", "788", false);
				yield return new WorldCountry("Turkey", "TR", "TUR", "792", false);
				yield return new WorldCountry("Turkmenistan", "TM", "TKM", "795", false);
				yield return new WorldCountry("Turks and Caicos Islands", "TC", "TCA", "796", false);
				yield return new WorldCountry("Tuvalu", "TV", "TUV", "798", false);
				yield return new WorldCountry("Uganda", "UG", "UGA", "800", false);
				yield return new WorldCountry("Ukraine", "UA", "UKR", "804", false);
				yield return new WorldCountry("United Arab Emirates", "AE", "ARE", "784", false);
				yield return new WorldCountry("United Kingdom", "GB", "GBR", "826", false);
				yield return new WorldCountry("United States", "US", "USA", "840", true);
				yield return new WorldCountry("United States Minor Outlying Islands", "UM", "UMI", "581", false);
				yield return new WorldCountry("Uruguay", "UY", "URY", "858", false);
				yield return new WorldCountry("Uzbekistan", "UZ", "UZB", "860", false);
				yield return new WorldCountry("Vanuatu", "VU", "VUT", "548", false);
				yield return new WorldCountry("Venezuela, Bolivarian Republic of", "VE", "VEN", "862", false);
				yield return new WorldCountry("Viet Nam", "VN", "VNM", "704", false);
				yield return new WorldCountry("Virgin Islands, British", "VG", "VGB", "092", false);
				yield return new WorldCountry("Virgin Islands, U.S.", "VI", "VIR", "850", false);
				yield return new WorldCountry("Wallis and Futuna", "WF", "WLF", "876", false);
				yield return new WorldCountry("Western Sahara", "EH", "ESH", "732", false);
				yield return new WorldCountry("Yemen", "YE", "YEM", "887", false);
				yield return new WorldCountry("Zambia", "ZM", "ZMB", "894", false);
				yield return new WorldCountry("Zimbabwe", "ZW", "ZWE", "716", false);
			}
		}

		public static IEnumerable<USState> States
		{
			get
			{
				yield return new USState("AL", "Alabama", "35801-35816", "Montgomery", "Yellowhammer", "Camellia", "4849377", "Birmingham", "32.738772", "86.638184", "52423", "December 14, 1819", "2,407 feet", "Sea level", "500 feet", "907", "Audemus Jura Nostra Defendere", "7", " Yellowhammer State", "George Washington Carver, who discovered more than 300 uses for peanuts", "Longleaf Pine Pinaceae Pinus palustris ", "Based on the Choctaw word albah amo meaning 'thicket clearers'");
				yield return new USState("AK", "Alaska", "99501-99524", "Juneau", "Willow Ptarmigan", "ForgetMeNot", "736732", "Anchorage", "66.160507", "153.369141", "656424", "January 3, 1959", "20,320 feet", "Sea level", "1,900 feet", "205, 251, 256, 334", "North to the Future", "7", "The Last Frontier ", "The longest coastline in the U.S., 6,640 miles, greater than that of all other states combined", "Sitka Spruce (Picea sitchensis) ", "Based on an Aleut word alaxsxaq literally meaning 'object toward which the action of the sea is directed' or more simply, 'the mainland'");
				yield return new USState("AZ", "Arizona", "85001-85055", "Phoenix", "Cactus Wren", "Saguaro Cactus Blossom", "6731484", "Phoenix", "34.048927", "111.093735", "114006", "February 14, 1912", "12,633 feet", "70 feet", "4,100 feet", "479, 501, 870", "Ditat Deus", "7", "The Grand Canyon State", "The most telescopes in the world, in Tucson", "Yellow Palo Verde (Parkinsonia microphylla) ", "Based on the Basque word aritz onak meaning 'good oak' or the Spanish word Arizonac meaning 'having a little spring'");
				yield return new USState("AR", "Arkansas", "72201", "Little Rock", "Mockingbird", "Apple Blossom", "2966369", "Little Rock", "34.820568", "91.999512", "53182", "June 15, 1836", "2,753 feet", "55 feet", "650 feet", "480, 520, 602, 623, 928", "Regnat Populus", "7", "The Natural State", "The only active diamond mine in the U.S.", "Loblolly Pine (Pinus taeda) ", "French interpretation of a Sioux word acansa meaning 'downstream people'");
				yield return new USState("CA", "California", "90001-90089,90209-90213,94203-94209", "Sacramento", "California Valley Quail", "Golden Poppy", "38802500", "Los Angeles", "36.778259", "119.417931", "163707", "September 9, 1850", "14,494 feet", "282 feet", "2,900 feet", "209, 213, 310, 323, 408, 415, 510, 530, 559, 562, 619, 626, 650, 661, 707, 714, 760, 805, 818, 831, 858, 909, 916, 925, 949, 951", "Eureka", "6L", "Golden State", "'General Sherman', a 3,500yearold tree, and a stand of bristlecone pines 4,000 years old are the world's oldest living things", "California Redwood (Sequoia sempervirens & Sequoia gigantea) ", "Named by the Spanish after Califia, a mythical paradise in a Spanish romance, written by Montalvo in 1510. ");
				yield return new USState("CO", "Colorado", "80201-80239", "Denver", "Lark Bunting", "Rocky Mountain Columbine", "5355866", "Denver", "39.113014", "105.358887", "104100", "August 1, 1876", "14,440 feet", "3,315 feet", "6,800 feet", "303, 719, 970", "Nil Sine Numine", "6", "Centennial State", "The world's largest silver nugget (1,840 pounds) found in 1894 near Aspen", "Colorado Blue Spruce (Picea pugens) ", "Taken from the Spanish for the color red, referring to the banks of the Colorado river. ");
				yield return new USState("CT", "Connecticut", "06101-06112", "Hartford", "Robin", "Mountain Laurel", "3596677", "Bridgeport", "41.481833", "72.663574", "5544", "January 9, 1788", "2,380 feet", "Sea level", "500 feet", "203, 860", "Qui Transtulit Sustinet", "6", "Constitution State", "The first American cookbook, published in Hartford in 1796: American Cookery by Amelia Simmons", "White Oak(Quercus alba) ", "From the Eastern Algonquin Indian word quinnitukqut meaning 'at the long tidal river', referring to the Connecticut River ");
				yield return new USState("DE", "Delaware", "19901-19905", "Dover", "Blue Hen Chicken", "Peach Blossom", "935614", "Wilmington", "39.102357", "75.388184", "2489", "December 7, 1787", "450 feet", "Sea level", "60 feet", "302", "Liberty and independence", "6L", "Blue Hen State", "The first log cabins in North America, built in 1683 by Swedish immigrants", "American Holly(Ilex opaca) ", "Named after an early Virginia governor, Lord de la Warr ");
				yield return new USState("FL", "Florida", "20001-20020", "Tallahassee", "Mockingbird", "Orange Blossom", "19893297", "Jacksonville", "28.659261", "81.89209", "59988", "March 3, 1845", "345 feet", "Sea level", "100 feet", "239, 305, 321, 352, 386, 407, 561, 727, 772, 813, 850, 863, 904, 941, 954", "In God we trust", "7", "Sunshine State", "U.S. spacecraft launchings from Cape Canaveral, formerly Cape Kennedy", "Sabal Palm (Sabal palmetto) ", "Named on Easter 1513 by Ponce de Leon for Pascua Florida, meaning 'Flowery Easter' ");
				yield return new USState("GA", "Georgia", "30301-30381", "Atlanta", "Brown Thrasher", "Cherokee Rose", "10097343", "Atlanta", "33.247875", "83.441162", "59441", "January 2, 1788", "4,784 feet", "Sea level", "600 feet", "229, 404, 478, 706, 770, 912", "Wisdom, Justice, and Moderation", "7", "Peach State", "The Girl Scouts, founded in Savannah by Juliette Gordon Low in 1912", "Southern Live Oak(Quercus virginiana) ", "Named for King George II of England ");
				yield return new USState("HI", "Hawaii", "96801-96830", "Honolulu", "Nene", "Hawaiian Hibiscus", "1419561", "Honolulu", "21.289373", "157.91748", "6459", "August 21, 1959", "13,796 feet", "Sea level", "3,030 feet", "808", "Agriculture and Commerce", "", "Aloha State", "The only royal palace in the U.S. (Iolani)", "Candlenut Tree (Aleurites moluccana) ", "Could be based on native Hawaiian word for homeland, Owhyhee ");
				yield return new USState("ID", "Idaho", "83254", "Boise", "Mountain Bluebird", "Syringa, mock orange", "1634464", "Boise", "44.068203", "114.742043", "83574", "July 3, 1890", "12,662 feet", "710 feet", "5,000 feet", "319, 515, 563, 641, 712", "Esto Perpetua", "7", "Gem State", "The longest main street in America, 33 miles, in Island Park", "Western White Pine(Pinus monticola) ", "Idaho is a coined, or invented, word ");
				yield return new USState("IL", "Illinois", "60601-60641,62701-62709", "Springfield", "Cardinal", "Violet", "12880580", "Chicago", "40.185168", "89.143066", "57918", "December 3, 1818", "1,235 feet", "279 feet", "600 feet", "208", "State sovereignty, national union", "7", "Prairie State", "The tallest building in the U.S., Sears Tower, in Chicago", "White Oak(Quercus alba) ", "Based on the Algonquin Indian word ilenweewa meaning 'warriors'");
				yield return new USState("IN", "Indiana", "46201-46209", "Indianapolis", "Cardinal", "Peony", "6596855", "Indianapolis", "40.267193", "86.134903", "36420", "December 11, 1816", "1,257 feet", "320 feet", "700 feet", "217, 309, 312, 618, 630, 708, 773, 815, 847", "The crossroads of America", "", "Hoosier State", "The famous car race: the Indy 500", "Tulip Tree (Liriodendron tulipifera) ", "Latin for 'Land of the Indians'");
				yield return new USState("IA", "Iowa", "50301-50323,52801-52809", "Des Moines", "Eastern Goldfinch", "Wild Prairie Rose", "3107126", "Des Moines", "42.032974", "93.581543", "56276", "December 28, 1846", "1,670 feet", "480 feet", "1,100 feet", "219, 260, 317, 574, 765, 812", "Our liberties we prize and our rights we will maintain", "7", "Hawkeye State", "The shortest and steepest railroad in the U.S., Dubuque: 60 incline, 296 feet", "Bur Oak (Quercus macrocarpa) ", "The name Iowa comes from Ioway, the French word for the Bahkhoje Indian tribe that lived in the area. ");
				yield return new USState("KS", "Kansas", "67201-67221", "Topeka", "Western Meadowlark", "Sunflower", "2904021", "Wichita", "38.588967", "98.415527", "82282", "January 29, 1861", "4,039 feet", "679 feet", "2,000 feet", "316, 620, 785, 913", "Ad Astra per Aspera", "6", "Sunflower State", "Helium discovered in 1905 at the University of Kansas", "Eastern Cottonwood(Populus deltoides) ", "From the Sioux Indian for 'south wind people'");
				yield return new USState("KY", "Kentucky", "41701-41702", "Frankfort", "Cardinal", "Goldenrod", "4413457", "Louisville", "37.839333", "84.27002", "40411", "June 1, 1792", "4,139 feet", "257 feet", "750 feet", "270, 502, 606, 859", "United we stand, divided we shall fall", "", "Bluegrass State", "The largest underground cave in the world: 300 miles long, the MammothFlint Cave system", "Tulip Tree (Liriodendron tulipifera) ", "Based on the Iroquois Indian word Kentahten meaning 'land of tomorrow' ");
				yield return new USState("LA", "Louisiana", "70112-70119", "Baton Rouge", "Eastern Brown Pelican", "Magnolia", "4649676", "New Orleans", "31.398191", "92.658691", "51843", "April 30, 1812", "535 feet", "8 feet", "100 feet", "225, 318, 337, 504, 985", "Union, justice, confidence ", "7", "Pelican State", "The most crayfish: 98% of the world's crayfish", "Bald Cypress(Taxodium distichum) ", "Named in honor of France's King Louis XIV ");
				yield return new USState("ME", "Maine", "04032-04034", "Augusta", "Chickadee", "Pine Cone and Tassel", "1330089", "Portland", "45.187844", "68.972168", "35387", "March 15, 1820", "5,276 feet", "Sea level", "600 feet", "413, 508, 617, 781, 978", "Dirigo", "", "Pine Tree State", "The most easterly point in the U.S., West Quoddy Head1", "Eastern White Pine(Pinus strobus) ", "Assumed to be a reference to the state region being a mainland, different from its many surrounding islands ");
				yield return new USState("MD", "Maryland", "2101-21237", "Annapolis", "Baltimore Oriole", "BlackEyed Susan", "5976407", "Baltimore", "39.045753", "76.641273", "12407", "April 28, 1788", "3,360 feet", "Sea level", "350 feet", "301, 410", "Fatti Maschii Parole Femine", "", "Old Line State", "The first umbrella factory in the U.S., 1928, Baltimore", "White Oak(Quercus alba) ", "Named to honor Henrietta Maria, wife of England's King Charles ");
				yield return new USState("MA", "Massachusetts", "02101-02137", "Boston", "Chickadee", "Mayflower", "6745408", "Boston", "42.407211", "71.382439", "10555", "February 6, 1788", "3,487 feet", "Sea level", "500 feet", "207", "Ense Petit Placidam Sub Libertate Quietem", "", "Bay State", "The first World Series, 1903: the Boston 'Americans' became the Red Sox in 1908) vs. the Pittsburg Pirates (Pittsburgh had no 'h' between 1890 1911)", "American Elm(Ulmus americana) ", "Based on the Algonquin Indian word massachussett meaning 'near the great little mountain'");
				yield return new USState("MI", "Michigan", "49036,39734-49725", "Lansing", "Robin", "Apple Blossom", "9909877", "Detroit", "43.522663", "84.70459", "96810", "Jan 26, 1837", "1,979 feet", "572 feet", "900 feet", "231, 248, 269, 313, 517, 586, 616, 734, 810, 906, 989", "Si Quaeris Peninsulam Amoenam Circumspice", "", "Wolverine State", "The Cereal Bowl of America, Battle Creek, produces most cereal in the U.S.", "Eastern White Pine(Pinus strobus) ", "Based on the Ojibwa Indian word misshikama meaning 'great water', referring to the Great Lakes ");
				yield return new USState("MN", "Minnesota", "55801-55808", "Saint Paul", "Common Loon", "Pink and White Lady's Slipper", "5457173", "Minneapolis", "46.392410", "94.63623", "86943", "May 11, 1858", "2,301 feet", "602 feet", "1,200 feet", "218, 320, 507, 612, 651, 763, 952", "L'Etoile du Nord", "7R", "Land of 10,000 Lakes", "The oldest rock in the world, 3.8 billion years old, found in Minnesota River valley", "Red Pine(Pinus resinosa) ", "Based on the Dakota Sioux Indian word mnisota for 'skytinted water', referring to the Minnesota River ");
				yield return new USState("MS", "Mississippi", "39530-39535", "Jackson", "Mockingbird", "Magnolia", "2994079", "Jackson", "32.701800", "89.626465", "48434", "December 10, 1817", "806 feet", "Sea level", "300 feet", "314, 417, 573, 636, 660, 816", "Virtute et Armis", "7", "Magnolia State", "CocaCola, first bottled in 1894 in Vicksburg", "Southern Magnolia(Magnolia grandiflora) ", "Based on the Ojibwa Indian word messipi meaning 'big river' ");
				yield return new USState("MO", "Missouri", "63101-63141", "Jefferson City", "Bluebird", "Hawthorn", "6063589", "Kansas City", "38.313646", "92.702637", "69709", "August 10, 1821", "1,772 feet", "230 feet", "800 feet", "228, 601, 662", "Salus Populi Suprema Lex Esto", "7", "Show Me State", "Mark Twain and some of his characters, such as Tom Sawyer and Huckleberry Finn", "Flowering Dogwood(Cornus florida) ", "Named after Missouri Indian tribe whose name means 'town of the large canoes'");
				yield return new USState("MT", "Montana", "59044", "Helena", "Western Meadowlark", "Bitterroot", "1023579", "Billings", "46.965260", "109.533691", "147046", "November 8, 1889", "12,799 feet", "1,800 feet", "3,400 feet", "406", "Oro y Plata", "6", "Treasure State", "Grasshopper Glacier, named for the grasshoppers that can still be seen frozen in ice", "Ponderosa Pine (Pinus ponderosa) ", "Based on the Spanish word monta a meaning 'mountain'");
				yield return new USState("NE", "Nebraska", "68901-68902", "Lincoln", "Western Meadowlark", "Goldenrod", "1881503", "Omaha", "41.317013", "99.558105", "77358", "March 1, 1867", "5,424 feet", "840 feet", "2,600 feet", "252, 336, 704, 828, 910, 919", "Equality before the law", "6", "Cornhusker State", "The only roller skating museum in the world, in Lincoln", "Eastern Cottonwood(Populus deltoides) ", "Name based on an Otoe Indian word meaning 'flat water', referring to the Platte River ");
				yield return new USState("NV", "Nevada", "89501-89513", "Carson City", "Mountain Bluebird", "Sagebrush", "2839099", "Las Vegas", "39.442557", "116.784668", "110567", "October 31, 1864", "13,140 feet", "479 feet", "5,500 feet", "701", "All for our country", "6L", "The Silver State", "Rare fish such as the Devils Hole pup, found only in Devils Hole, and other rare fish from prehistoric lakes; also the driest state", "SingleLeaf Pinon & Bristlecone Pine (Pinus monophylla & Pinus longaeva) ", " Nevada is from the Spanish word meaning 'snowcapped'.");
				yield return new USState("NH", "New Hampshire", "03217", "Concord", "Purple Finch", "Purple Lilac", "1326813", "Manchester", "43.458900", "71.696777", "9351", "June 21, 1788", "6,288 feet", "Sea level", "1,000 feet", "308, 402", "Live free or die", "", "Granite State", "Artificial rain, first used near Concord in 1947 to fight a forest fire", "Paper Birch (Betula papyrifera) ", "From the English county of Hampshire");
				yield return new USState("NJ", "New Jersey", "07039", "Trenton", "Eastern Goldfinch", "Violet", "8938175", "Newark", "39.833851", "74.871826", "8722", ".incember 18, 1787", "1,803 feet", "Sea level", "250 feet", "603", "Liberty and Prosperity", "", "Gar.inn State", "The world's first drivein movie theater, built in 1933 near Cam.inn", "Northern Red Oak (Quercus rubra) ", "From the Channel Isle of Jersey");
				yield return new USState("NM", "New Mexico", "87500-87506", "Albany", "Roadrunner", "Yucca Flower", "2085572", "Albuquerque", "34.307144", "106.018066", "121598", "January 6, 1912", "13,161 feet", "2,842 feet", "5,700 feet", "201, 609, 732, 856, 908, 973", "Crescit Eundo", "7", "Land of Enchantment", "'Smokey Bear', a cub orphaned by fire in 1950, buried in Smokey Bear Historical State Park in1976", "Pi on Tree (Pinus edulis) ", "Named by the Spanish for lands north of the Rio Grande River ");
				yield return new USState("NY", "New York", "10001-10048", "Santa Fe", "Bluebird", "Rose", "19746227", "New York", "42.882002", "75.256348", "54475", "July 26, 1788", "5,344 feet", "Sea level", "1,000 feet", "505, 575", "Excelsior", "7", "Empire State", "The first presidential inauguration: George Washington took the oath of office in New York City on April 30, 1789.", "Sugar Maple(Acer saccharum) ", "In honor of the Duke of York");
				yield return new USState("NC", "North Carolina", "27565", "Raleigh", "Cardinal", "Flowering Dogwood", "9943964", "Charlotte", "35.782169", "80.793457", "52672", "November 21, 1789", "6,684 feet", "Sea level", "700 feet", "702, 775", "Esse Quam Videri", "7", "Tar Heel State", "Virginia Dare, the first English child born in America, on Roanoake Island in 1587", "Longleaf Pine(Pinus palustris) ", "Taken from Carolus, the Latin word for Charles, and named after England's King Charles I ");
				yield return new USState("ND", "North Dakota", "58282", "Bismark", "Western Meadowlark", "Wild Praire Rose", "739482", "Fargo", "47.650589", "100.437012", "70704", "November 2, 1889", "3,506 feet", "750 feet", "1,900 feet", "212, 315, 516, 518, 585, 607, 631, 716, 718, 845, 914", "Liberty and union, now and forever, one and inseparable", "6", "Peace Garden State", "The geographic center of North America, in Pierce County, near Balta", "American Elm (Ulmus americana) ", "Based on the Sioux Indian word dakhota meaning 'friend'");
				yield return new USState("OH", "Ohio", "44101-44179", "Columbus", "Cardinal", "Scarlet Carnation", "11594163", "Columbus", "40.620207", "82.770996", "44828", "March 1, 1803", "1,549 feet", "455 feet", "850 feet", "216, 330, 419, 440, 513, 614, 740, 937", "With God, all things are possible", "7", "Buckeye State", "The first electric traffic lights, invented and installed in Cleveland in 1914", "Ohio Buckeye (Aesculus glabra) ", "From an Iroquoian word meaning 'great river'");
				yield return new USState("OK", "Oklahoma", "74101-74110", "Oklahoma City", "Scissortailed Flycatcher", "Oklahoma Rose", "3878051", "Oklahoma City", "36.084621", "96.921387", "69903", "November 16, 1907", "4,973 feet", "289 feet", "1,300 feet", "405, 580, 918", "Labor Omnia Vincit", "6", "Sooner State", "The first parking meter, installed in Oklahoma City in 1935", "Eastern Redbud(Cercis canadensis) ", "From two Choctaw Indian words meaning 'red people'.");
				yield return new USState("OR", "Oregon", "97201-97225", "Salem", "Western Meadowlark", "Oregon Grape", "3970239", "Portland", "43.745305", "120.739746", "98386", "February 14, 1859", "11,239 feet", "Sea level", "3,300 feet", "503, 541", "Alis Volat Propriis", "6", "Beaver State", "The world's smallest park, totaling 452 inches, created in Portland on St. Patrick's Day for leprechauns and snail races", "Douglas Fir(Pseudotsuga menziesii) ", "Unknown. However, it is generally accepted that the name, first used by Jonathan Carver in 1778, was taken from the writings of Maj. Robert Rogers, an English army officer.");
				yield return new USState("PA", "Pennsylvania", "15201-15244", "Harrisburg", "Ruffed Grouse", "Mountain Laurel", "12787209", "Philadelphia", "41.203323", "77.194527", "46058", "December 12, 1787", "3,213 feet", "Sea level", "1,100 feet", "215, 412, 570, 610, 717, 724, 814", "Virtue, liberty and independence", "7", "Keystone State", "The first magazine in America: the American Magazine, published in Philadelphia for 3 months in1741", "Eastern Hemlock(Tsuga canadensis) ", "In honor of Adm. Sir William Penn, father of William Penn. It means 'Penn's Woodland.'");
				yield return new USState("RI", "Rhode Island", "02840-02841", "Providence", "Rhode Island Red", "Violet", "1055173", "Providence", "41.514747", "71.38916", "1545", "May 29, 1790", "812 feet", "Sea level", "200 feet", "401", "Hope", "", "The Ocean State", "Rhode Island Red chickens, first bred in 1854; the start of poultry as a major American industry", "Red Maple(Acer rubrum) ", "Possibly named in honor of the Greek Island of Rhodes or was named Roode Eylandt by Adriaen Block, Dutch explorer, because of its red clay ");
				yield return new USState("SC", "South Carolina", "29020", "Columbia", "Great Carolina Wren", "Yellow Jessamine", "4832482", "Columbia", "33.836082", "81.163727", "32007", "May 23, 1788", "3,560 feet", "Sea level", "350 feet", "803, 843, 864", "Dum spiro spero Animis opibusque parati", "", "Palmetto State", "The first tea farm in the U.S., created in 1890 near Summerville", "Sabal Palm (Sabal palmetto) ", "Taken from Carolus, the Latin word for Charles, and named after England's King Charles I ");
				yield return new USState("SD", "South Dakota", "57401-57402", "Pierre", "Ringnecked Pheasant", "Pasque Flower", "853175", "Sioux Falls", "44.251101", "100.217285", "77121", "November 2, 1889", "7,242 feet", "966 feet", "2,200 feet", "605", "Under God, the people rule", "6", "Mount Rushmore State", "The world's largest natural, indoor warmwater pool, Evans' Plunge in Hot Springs", "White Spruce(Picea glauca) ", "From the Sioux tribe, meaning 'allies'");
				yield return new USState("TN", "Tennessee", "37201-37222", "Nashville", "Mockingbird", "Purple Passionflower", "6549352", "Memphis", "35.860119", "86.660156", "42146", "June 1, 1796", "6,643 feet", "178 feet", "900 feet", "423, 615, 731, 865, 901, 931", "Agriculture and commerce", "7", "Volunteer State", "Graceland, the estate and gravesite of Elvis Presley", "Tulip Tree (Liriodendron tulipfera) ", "Of Cherokee origin; the exact meaning is unknown");
				yield return new USState("TX", "Texas", "78701-78705", "Austin", "Mockingbird", "Bluebonnet Sp.", "26956958", "Houston", "31.360673", "99.338379", "268601", "December 29, 1845", "8,749 feet", "Sea level", "1,700 feet", "210, 214, 254, 281, 325, 361, 409, 432, 512, 713, 806, 817, 830, 903, 915, 936, 940, 956, 972, 979", "Friendship", "", "Lone Star State", "NASA, in Houston, headquarters for all piloted U.S. space projects", "Pecan(Carya illinoinensis) ", "From an Indian word meaning 'friends'");
				yield return new USState("UT", "Utah", "84321-84323", "Salt Lake City", "Common American Gull", "Sego Lily", "2942902", "Salt Lake City", "39.419220", "111.950684", "84904", "January 4, 1896", "13,528 feet", "2,000 feet", "6,100 feet", "435, 801", "Industry", "7", "The Beehive State", "Rainbow Bridge, the largest natural stone bridge in the world, 290 feet high, 275 feet across", "Quaking Aspen (Populus tremuloides) ", " ");
				yield return new USState("VT", "Vermont", "05751", "Montpelier", "Hermit Thrush", "Red Clover", "626562", "Burlington", "43.903829", "72.79541", "9615", "March 4, 1791", "4,393 feet", "95 feet", "1,000 feet", "276, 434, 540, 703, 757, 804", "Freedom and Unity", "", "Green Mountain State", "The largest production of maple syrup in the U.S.", "Sugar Maple (Acer saccharum) ", "From the French 'vert mont', meaning 'green mountain'");
				yield return new USState("VA", "Virginia", "24517", "Richmond", "Cardinal", "American Dogwood", "8326289", "Virginia Beach", "37.926868", "78.024902", "42769", "June 25, 1788", "5,729 feet", "Sea level", "950 feet", "802", "Sic semper tyrannis ", "7", "Old Dominion State", "The only fulllength statue of George Washington, placed in capitol in 1796", "Flowering Dogwood(Cornus florida) ", "In honor of Elizabeth 'Virgin Queen' of England");
				yield return new USState("WA", "Washington", "98004-98009", "Olympia", "Willow Goldfinch", "Coast Rhododendrum", "7061530", "Seattle", "47.751076", "120.740135", "71303", "November 11, 1889", "14,410 feet", "Sea level", "1,700 feet", "206, 253, 360, 425, 509", "Alki", "6", "The Evergreen State", "Lunar Rover, the vehicle used by astronauts on the moon; Boeing, in Seattle, makes aircraft and spacecraft", "Western Hemlock(Tsuga heterophylla) ", "In honor of George Washington");
				yield return new USState("WV", "West Virginia", "25813", "Charleston", "Cardinal", "Rhododendron", "1850326", "Charleston", "38.657633", "80.617676", "24231", "June 20, 1863", "4,863 feet", "240 feet", "1,500 feet", "262, 414, 608, 715, 920", "Montani Semper Liberi", "", "Mountain State", "Marbles; most of the country's glass marbles made around Parkersburg", "Sugar Maple(Acer saccharum) ", "In honor of Elizabeth, 'Virgin Queen' of England");
				yield return new USState("WI", "Wisconsin", "53201-53228", "Madison", "Robin", "Wood Violet", "5757564", "Milwaukee", "44.376877", "89.758301", "65503", "May 29, 1848", "1,951 feet", "581 feet", "1,050 feet", "304", "Forward", "7", "Badger State", "The typewriter, invented in Milwaukee in 1867", "Sugar Maple(Acer saccharum) ", "Based on an Indian word Ouisconsin believed to mean 'grassy place'");
				yield return new USState("WY", "Wyoming", "82941", "Cheyenne", "Western Meadowlark", "Indian Paintbrush", "584153", "Cheyenne", "43.075970", "107.290283", "97818", "July 10, 1890", "13,804 feet", "3,099 feet", "6,700 feet", "307", "Equal rights", "6", "Equality State", "The 'Register of the Desert' a huge granite boulder covering 27 acres with 5,000 early pioneer names carved on it", "Eastern Cottonwood (Populus deltoides) ", "From the Delaware Indian word, meaning 'mountains and valleys alternating'; the same as the Wyoming Valley in Pennsylvania");
			}
		}

		public static class StreetSuffixes
		{
			public static string[] Names =
			{
				"Avenue", "Boulevard", "Center", "Circle", "Court", "Drive", "Extension", "Glen", "Grove", "Heights", "Highway", "Junction", "Key", "Lane", "Loop", "Manor", "Mill", "Park", "Parkway", "Pass", "Path", "Pike", "Place", "Plaza", "Point", "Ridge", "Ridge", "River", "Road", "Square", "Street", "Terrace", "Trail", "Turnpike", "View", "Way"
			};

			public static string[] Abbreviations =
			{
				"Ave", "Blvd", "Ctr", "Cir", "Ct", "Dr", "Ext", "Gln", "Grv", "Hts", "Hwy", "Jct", "Key", "Ln", "Loop", "Mnr", "Mill", "Park", "Pkwy", "Pass", "Path", "Pike", "Pl", "Plz", "Pt", "Rdg", "Riv", "Rd", "Sq", "St", "Ter", "Trl", "Tpke", "Vw", "Way"
			};
		}

		public static IEnumerable<CreditCardType> CreditCardTypes
		{
			get
			{
				yield return new CreditCardType(ChanceNET.CreditCardTypes.AmericanExpress, "American Express", "amex", "34", 15, "4-6-5");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.Bankcard, "Bankcard", "bankcard", "5610", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.ChinaUnionPay, "China UnionPay", "chinaunion", "62", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.Dankort, "Dankort", "dankort", "5019", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.DinersClubCarteBlanche, "Diners Club Carte Blanche", "dcarte", "300", 14, "4-6-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.DinersClubEnRoute, "Diners Club enRoute", "dcenroute", "2014", 15, "4-7-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.DinersClubInternational, "Diners Club International", "dcintl", "36", 14, "4-6-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.DinersClubUnitedStatesAndCanada, "Diners Club United States & Canada", "dcusc", "54", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.DiscoverCard, "Discover Card", "discover", "6011", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.InstaPayment, "InstaPayment", "instapay", "637", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.InterPayment, "InterPayment", "inter", "636", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.JCB, "JCB", "jcb", "3528", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.Laser, "Laser", "laser", "6304", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.Maestro, "Maestro", "maestro", "5018", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.Mastercard, "Mastercard", "mc", "51", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.Solo, "Solo", "solo", "6334", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.Switch, "Switch", "switch", "4903", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.UATP, "UATP", "uatp", "1", 15, "4-5-6");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.Visa, "Visa", "visa", "4", 16, "4-4-4-4");
				yield return new CreditCardType(ChanceNET.CreditCardTypes.VisaElectron, "Visa Electron", "electron", "4026", 16, "4-4-4-4");
			}
		}

		public static string[] ColorNames =
		{
			"AliceBlue", "Black", "Navy", "DarkBlue", "MediumBlue", "Blue", "DarkGreen", "Green", "Teal", "DarkCyan", "DeepSkyBlue", "DarkTurquoise", "MediumSpringGreen", "Lime", "SpringGreen",
			"Aqua", "Cyan", "MidnightBlue", "DodgerBlue", "LightSeaGreen", "ForestGreen", "SeaGreen", "DarkSlateGray", "LimeGreen", "MediumSeaGreen", "Turquoise", "RoyalBlue", "SteelBlue", "DarkSlateBlue", "MediumTurquoise",
			"Indigo", "DarkOliveGreen", "CadetBlue", "CornflowerBlue", "RebeccaPurple", "MediumAquaMarine", "DimGray", "SlateBlue", "OliveDrab", "SlateGray", "LightSlateGray", "MediumSlateBlue", "LawnGreen", "Chartreuse",
			"Aquamarine", "Maroon", "Purple", "Olive", "Gray", "SkyBlue", "LightSkyBlue", "BlueViolet", "DarkRed", "DarkMagenta", "SaddleBrown", "Ivory", "White",
			"DarkSeaGreen", "LightGreen", "MediumPurple", "DarkViolet", "PaleGreen", "DarkOrchid", "YellowGreen", "Sienna", "Brown", "DarkGray", "LightBlue", "GreenYellow", "PaleTurquoise", "LightSteelBlue", "PowderBlue",
			"FireBrick", "DarkGoldenRod", "MediumOrchid", "RosyBrown", "DarkKhaki", "Silver", "MediumVioletRed", "IndianRed", "Peru", "Chocolate", "Tan", "LightGray", "Thistle", "Orchid", "GoldenRod", "PaleVioletRed",
			"Crimson", "Gainsboro", "Plum", "BurlyWood", "LightCyan", "Lavender", "DarkSalmon", "Violet", "PaleGoldenRod", "LightCoral", "Khaki", "AliceBlue", "HoneyDew", "Azure", "SandyBrown", "Wheat", "Beige", "WhiteSmoke",
			"MintCream", "GhostWhite", "Salmon", "AntiqueWhite", "Linen", "LightGoldenRodYellow", "OldLace", "Red", "Fuchsia", "Magenta", "DeepPink", "OrangeRed", "Tomato", "HotPink", "Coral", "DarkOrange", "LightSalmon", "Orange",
			"LightPink", "Pink", "Gold", "PeachPuff", "NavajoWhite", "Moccasin", "Bisque", "MistyRose", "BlanchedAlmond", "PapayaWhip", "LavenderBlush", "SeaShell", "Cornsilk", "LemonChiffon", "FloralWhite", "Snow", "Yellow", "LightYellow"
		};

		public static IEnumerable<Currency> Currencies
		{
			get
			{
				yield return new Currency("USD", "US Dollar", "$", "US dollars");
				yield return new Currency("CAD", "Canadian Dollar", "CA$", "Canadian dollars");
				yield return new Currency("EUR", "Euro", "€", "euros");
				yield return new Currency("AED", "United Arab Emirates Dirham", "AED", "UAE dirhams");
				yield return new Currency("AFN", "Afghan Afghani", "Af", "Afghan Afghanis");
				yield return new Currency("ALL", "Albanian Lek", "ALL", "Albanian lekë");
				yield return new Currency("AMD", "Armenian Dram", "AMD", "Armenian drams");
				yield return new Currency("ARS", "Argentine Peso", "AR$", "Argentine pesos");
				yield return new Currency("AUD", "Australian Dollar", "AU$", "Australian dollars");
				yield return new Currency("AZN", "Azerbaijani Manat", "man.", "Azerbaijani manats");
				yield return new Currency("BAM", "Bosnia-Herzegovina Convertible Mark", "KM", "Bosnia-Herzegovina convertible marks");
				yield return new Currency("BDT", "Bangladeshi Taka", "Tk", "Bangladeshi takas");
				yield return new Currency("BGN", "Bulgarian Lev", "BGN", "Bulgarian leva");
				yield return new Currency("BHD", "Bahraini Dinar", "BD", "Bahraini dinars");
				yield return new Currency("BIF", "Burundian Franc", "FBu", "Burundian francs");
				yield return new Currency("BND", "Brunei Dollar", "BN$", "Brunei dollars");
				yield return new Currency("BOB", "Bolivian Boliviano", "Bs", "Bolivian bolivianos");
				yield return new Currency("BRL", "Brazilian Real", "R$", "Brazilian reals");
				yield return new Currency("BWP", "Botswanan Pula", "BWP", "Botswanan pulas");
				yield return new Currency("BYR", "Belarusian Ruble", "BYR", "Belarusian rubles");
				yield return new Currency("BZD", "Belize Dollar", "BZ$", "Belize dollars");
				yield return new Currency("CDF", "Congolese Franc", "CDF", "Congolese francs");
				yield return new Currency("CHF", "Swiss Franc", "CHF", "Swiss francs");
				yield return new Currency("CLP", "Chilean Peso", "CL$", "Chilean pesos");
				yield return new Currency("CNY", "Chinese Yuan", "CN¥", "Chinese yuan");
				yield return new Currency("COP", "Colombian Peso", "CO$", "Colombian pesos");
				yield return new Currency("CRC", "Costa Rican Colón", "₡", "Costa Rican colóns");
				yield return new Currency("CVE", "Cape Verdean Escudo", "CV$", "Cape Verdean escudos");
				yield return new Currency("CZK", "Czech Republic Koruna", "Kč", "Czech Republic korunas");
				yield return new Currency("DJF", "Djiboutian Franc", "Fdj", "Djiboutian francs");
				yield return new Currency("DKK", "Danish Krone", "Dkr", "Danish kroner");
				yield return new Currency("DOP", "Dominican Peso", "RD$", "Dominican pesos");
				yield return new Currency("DZD", "Algerian Dinar", "DA", "Algerian dinars");
				yield return new Currency("EEK", "Estonian Kroon", "Ekr", "Estonian kroons");
				yield return new Currency("EGP", "Egyptian Pound", "EGP", "Egyptian pounds");
				yield return new Currency("ERN", "Eritrean Nakfa", "Nfk", "Eritrean nakfas");
				yield return new Currency("ETB", "Ethiopian Birr", "Br", "Ethiopian birrs");
				yield return new Currency("GBP", "British Pound Sterling", "£", "British pounds sterling");
				yield return new Currency("GEL", "Georgian Lari", "GEL", "Georgian laris");
				yield return new Currency("GHS", "Ghanaian Cedi", "GH₵", "Ghanaian cedis");
				yield return new Currency("GNF", "Guinean Franc", "FG", "Guinean francs");
				yield return new Currency("GTQ", "Guatemalan Quetzal", "GTQ", "Guatemalan quetzals");
				yield return new Currency("HKD", "Hong Kong Dollar", "HK$", "Hong Kong dollars");
				yield return new Currency("HNL", "Honduran Lempira", "HNL", "Honduran lempiras");
				yield return new Currency("HRK", "Croatian Kuna", "kn", "Croatian kunas");
				yield return new Currency("HUF", "Hungarian Forint", "Ft", "Hungarian forints");
				yield return new Currency("IDR", "Indonesian Rupiah", "Rp", "Indonesian rupiahs");
				yield return new Currency("ILS", "Israeli New Sheqel", "₪", "Israeli new sheqels");
				yield return new Currency("INR", "Indian Rupee", "Rs", "Indian rupees");
				yield return new Currency("IQD", "Iraqi Dinar", "IQD", "Iraqi dinars");
				yield return new Currency("IRR", "Iranian Rial", "IRR", "Iranian rials");
				yield return new Currency("ISK", "Icelandic Króna", "Ikr", "Icelandic krónur");
				yield return new Currency("JMD", "Jamaican Dollar", "J$", "Jamaican dollars");
				yield return new Currency("JOD", "Jordanian Dinar", "JD", "Jordanian dinars");
				yield return new Currency("JPY", "Japanese Yen", "¥", "Japanese yen");
				yield return new Currency("KES", "Kenyan Shilling", "Ksh", "Kenyan shillings");
				yield return new Currency("KHR", "Cambodian Riel", "KHR", "Cambodian riels");
				yield return new Currency("KMF", "Comorian Franc", "CF", "Comorian francs");
				yield return new Currency("KRW", "South Korean Won", "₩", "South Korean won");
				yield return new Currency("KWD", "Kuwaiti Dinar", "KD", "Kuwaiti dinars");
				yield return new Currency("KZT", "Kazakhstani Tenge", "KZT", "Kazakhstani tenges");
				yield return new Currency("LBP", "Lebanese Pound", "LB£", "Lebanese pounds");
				yield return new Currency("LKR", "Sri Lankan Rupee", "SLRs", "Sri Lankan rupees");
				yield return new Currency("LTL", "Lithuanian Litas", "Lt", "Lithuanian litai");
				yield return new Currency("LVL", "Latvian Lats", "Ls", "Latvian lati");
				yield return new Currency("LYD", "Libyan Dinar", "LD", "Libyan dinars");
				yield return new Currency("MAD", "Moroccan Dirham", "MAD", "Moroccan dirhams");
				yield return new Currency("MDL", "Moldovan Leu", "MDL", "Moldovan lei");
				yield return new Currency("MGA", "Malagasy Ariary", "MGA", "Malagasy Ariaries");
				yield return new Currency("MKD", "Macedonian Denar", "MKD", "Macedonian denari");
				yield return new Currency("MMK", "Myanma Kyat", "MMK", "Myanma kyats");
				yield return new Currency("MOP", "Macanese Pataca", "MOP$", "Macanese patacas");
				yield return new Currency("MUR", "Mauritian Rupee", "MURs", "Mauritian rupees");
				yield return new Currency("MXN", "Mexican Peso", "MX$", "Mexican pesos");
				yield return new Currency("MYR", "Malaysian Ringgit", "RM", "Malaysian ringgits");
				yield return new Currency("MZN", "Mozambican Metical", "MTn", "Mozambican meticals");
				yield return new Currency("NAD", "Namibian Dollar", "N$", "Namibian dollars");
				yield return new Currency("NGN", "Nigerian Naira", "₦", "Nigerian nairas");
				yield return new Currency("NIO", "Nicaraguan Córdoba", "C$", "Nicaraguan córdobas");
				yield return new Currency("NOK", "Norwegian Krone", "Nkr", "Norwegian kroner");
				yield return new Currency("NPR", "Nepalese Rupee", "NPRs", "Nepalese rupees");
				yield return new Currency("NZD", "New Zealand Dollar", "NZ$", "New Zealand dollars");
				yield return new Currency("OMR", "Omani Rial", "OMR", "Omani rials");
				yield return new Currency("PAB", "Panamanian Balboa", "B/.", "Panamanian balboas");
				yield return new Currency("PEN", "Peruvian Nuevo Sol", "S/.", "Peruvian nuevos soles");
				yield return new Currency("PHP", "Philippine Peso", "₱", "Philippine pesos");
				yield return new Currency("PKR", "Pakistani Rupee", "PKRs", "Pakistani rupees");
				yield return new Currency("PLN", "Polish Zloty", "zł", "Polish zlotys");
				yield return new Currency("PYG", "Paraguayan Guarani", "₲", "Paraguayan guaranis");
				yield return new Currency("QAR", "Qatari Rial", "QR", "Qatari rials");
				yield return new Currency("RON", "Romanian Leu", "RON", "Romanian lei");
				yield return new Currency("RSD", "Serbian Dinar", "din.", "Serbian dinars");
				yield return new Currency("RUB", "Russian Ruble", "RUB", "Russian rubles");
				yield return new Currency("RWF", "Rwandan Franc", "RWF", "Rwandan francs");
				yield return new Currency("SAR", "Saudi Riyal", "SR", "Saudi riyals");
				yield return new Currency("SDG", "Sudanese Pound", "SDG", "Sudanese pounds");
				yield return new Currency("SEK", "Swedish Krona", "Skr", "Swedish kronor");
				yield return new Currency("SGD", "Singapore Dollar", "S$", "Singapore dollars");
				yield return new Currency("SOS", "Somali Shilling", "Ssh", "Somali shillings");
				yield return new Currency("SYP", "Syrian Pound", "SY£", "Syrian pounds");
				yield return new Currency("THB", "Thai Baht", "฿", "Thai baht");
				yield return new Currency("TND", "Tunisian Dinar", "DT", "Tunisian dinars");
				yield return new Currency("TOP", "Tongan Paʻanga", "T$", "Tongan paʻanga");
				yield return new Currency("TRY", "Turkish Lira", "TL", "Turkish Lira");
				yield return new Currency("TTD", "Trinidad and Tobago Dollar", "TT$", "Trinidad and Tobago dollars");
				yield return new Currency("TWD", "New Taiwan Dollar", "NT$", "New Taiwan dollars");
				yield return new Currency("TZS", "Tanzanian Shilling", "TSh", "Tanzanian shillings");
				yield return new Currency("UAH", "Ukrainian Hryvnia", "₴", "Ukrainian hryvnias");
				yield return new Currency("UGX", "Ugandan Shilling", "USh", "Ugandan shillings");
				yield return new Currency("UYU", "Uruguayan Peso", "$U", "Uruguayan pesos");
				yield return new Currency("UZS", "Uzbekistan Som", "UZS", "Uzbekistan som");
				yield return new Currency("VEF", "Venezuelan Bolívar", "Bs.F.", "Venezuelan bolívars");
				yield return new Currency("VND", "Vietnamese Dong", "₫", "Vietnamese dong");
				yield return new Currency("XAF", "CFA Franc BEAC", "FCFA", "CFA francs BEAC");
				yield return new Currency("XOF", "CFA Franc BCEAO", "CFA", "CFA francs BCEAO");
				yield return new Currency("YER", "Yemeni Rial", "YR", "Yemeni rials");
				yield return new Currency("ZAR", "South African Rand", "R", "South African rand");
				yield return new Currency("ZMK", "Zambian Kwacha", "ZK", "Zambian kwachas");
			}
		}

		public static Dictionary<AnimalTypes, string[]> Animals = new Dictionary<AnimalTypes, string[]>()
		{
			{
				AnimalTypes.Ocean,
				new string[]
				{
					// https://owlcation.com/stem/list-of-ocean-animals
					"Acantharea","Anemone","Angelfish King","Ahi Tuna","Albacore","American Oyster","Anchovy","Armored Snail","Arctic Char","Atlantic Bluefin Tuna","Atlantic Cod","Atlantic Goliath Grouper","Atlantic Trumpetfish","Atlantic Wolffish","Baleen Whale","Banded Butterflyfish","Banded Coral Shrimp","Banded Sea Krait","Barnacle","Barndoor Skate","Barracuda","Basking Shark","Bass","Beluga Whale","Bluebanded Goby","Bluehead Wrasse","Bluefish","Bluestreak Cleaner-Wrasse","Blue Marlin","Blue Shark","Blue Spiny Lobster","Blue Tang","Blue Whale","Broadclub Cuttlefish","Bull Shark","Chambered Nautilus","Chilean Basket Star","Chilean Jack Mackerel","Chinook Salmon","Christmas Tree Worm","Clam","Clown Anemonefish","Clown Triggerfish","Cod","Coelacanth","Cockscomb Cup Coral","Common Fangtooth","Conch","Cookiecutter Shark","Copepod","Coral","Corydoras","Cownose Ray","Crab","Crown-of-Thorns Starfish","Cushion Star","Cuttlefish","California Sea Otters","Dolphin","Dolphinfish","Dory","Devil Fish","Dugong","Dumbo Octopus","Dungeness Crab","Eccentric Sand Dollar","Edible Sea Cucumber","Eel","Elephant Seal","Elkhorn Coral","Emperor Shrimp","Estuarine Crocodile","Fathead Sculpin","Fiddler Crab","Fin Whale","Flameback","Flamingo Tongue Snail","Flashlight Fish","Flatback Turtle","Flatfish","Flying Fish","Flounder","Fluke","French Angelfish","Frilled Shark","Fugu (also called Pufferfish)","Gar","Geoduck","Giant Barrel Sponge","Giant Caribbean Sea Anemone","Giant Clam","Giant Isopod","Giant Kingfish","Giant Oarfish","Giant Pacific Octopus","Giant Pyrosome","Giant Sea Star","Giant Squid","Glowing Sucker Octopus","Giant Tube Worm","Goblin Shark","Goosefish","Great White Shark","Greenland Shark","Grey Atlantic Seal","Grouper","Grunion","Guineafowl Puffer","Haddock","Hake","Halibut","Hammerhead Shark","Hapuka","Harbor Porpoise","Harbor Seal","Hatchetfish","Hawaiian Monk Seal","Hawksbill Turtle","Hector's Dolphin","Hermit Crab","Herring","Hoki","Horn Shark","Horseshoe Crab","Humpback Anglerfish","Humpback Whale","Icefish","Imperator Angelfish","Irukandji Jellyfish","Isopod","Ivory Bush Coral","Japanese Spider Crab","Jellyfish","John Dory","Juan Fernandez Fur Seal","Killer Whale","Kiwa Hirsuta","Krill","Lagoon Triggerfish","Lamprey","Leafy Seadragon","Leopard Seal","Limpet","Ling","Lionfish","Lions Mane Jellyfish","Lobe Coral","Lobster","Loggerhead Turtle","Longnose Sawshark","Longsnout Seahorse","Lophelia Coral","Marrus Orthocanna","Manatee","Manta Ray","Marlin","Megamouth Shark","Mexican Lookdown","Mimic Octopus","Moon Jelly","Mollusk","Monkfish","Moray Eel","Mullet","Mussel","Megaladon","Napoleon Wrasse","Nassau Grouper","Narwhal","Nautilus","Needlefish","Northern Seahorse","North Atlantic Right Whale","Northern Red Snapper","Norway Lobster","Nudibranch","Nurse Shark","Oarfish","Ocean Sunfish","Oceanic Whitetip Shark","Octopus","Olive Sea Snake","Orange Roughy","Ostracod","Otter","Oyster","Pacific Angelshark","Pacific Blackdragon","Pacific Halibut","Pacific Sardine","Pacific Sea Nettle Jellyfish","Pacific White Sided Dolphin","Pantropical Spotted Dolphin","Patagonian Toothfish","Peacock Mantis Shrimp","Pelagic Thresher Shark","Penguin","Peruvian Anchoveta","Pilchard","Pink Salmon","Pinniped","Plankton","Porpoise","Polar Bear","Portuguese Man o' War","Pycnogonid Sea Spider","Quahog","Queen Angelfish","Queen Conch","Queen Parrotfish","Queensland Grouper","Ragfish","Ratfish","Rattail Fish","Ray","Red Drum","Red King Crab","Ringed Seal","Risso's Dolphin","Ross Seals","Sablefish","Salmon","Sand Dollar","Sandbar Shark","Sawfish","Sarcastic Fringehead","Scalloped Hammerhead Shark","Seahorse","Sea Cucumber","Sea Lion","Sea Urchin","Seal","Shark","Shortfin Mako Shark","Shovelnose Guitarfish","Shrimp","Silverside Fish","Skipjack Tuna","Slender Snipe Eel","Smalltooth Sawfish","Smelts","Sockeye Salmon","Southern Stingray","Sponge","Spotted Porcupinefish","Spotted Dolphin","Spotted Eagle Ray","Spotted Moray","Squid","Squidworm","Starfish","Stickleback","Stonefish","Stoplight Loosejaw","Sturgeon","Swordfish","Tan Bristlemouth","Tasseled Wobbegong","Terrible Claw Lobster","Threespot Damselfish","Tiger Prawn","Tiger Shark","Tilefish","Toadfish","Tropical Two-Wing Flyfish","Tuna","Umbrella Squid","Velvet Crab","Venus Flytrap Sea Anemone","Vigtorniella Worm","Viperfish","Vampire Squid","Vaquita","Wahoo","Walrus","West Indian Manatee","Whale","Whale Shark","Whiptail Gulper","White-Beaked Dolphin","White-Ring Garden Eel","White Shrimp","Wobbegong","Wrasse","Wreckfish","Xiphosura","Yellowtail Damselfish","Yelloweye Rockfish","Yellow Cup Black Coral","Yellow Tube Sponge","Yellowfin Tuna","Zebrashark","Zooplankton"
				}
			},
			{
				AnimalTypes.Desert,
				new string[]
				{
					// http://www.skyenimals.com/
					"Aardwolf","Addax","African Wild Ass","Ant","Antelope","Armadillo","Baboon","Badger","Bat","Bearded Dragon","Beetle","Bird","Black-footed Cat","Boa","Brown Bear","Bustard","Butterfly","Camel","Caracal","Caracara","Caterpillar","Centipede","Cheetah","Chipmunk","Chuckwalla","Climbing Mouse","Coati","Cobra","Cotton Rat","Cougar","Courser","Crane Fly","Crow","Dassie Rat","Dove","Dunnart","Eagle","Echidna","Elephant","Emu","Falcon","Fly","Fox","Frogmouth","Gecko","Geoffroy's Cat","Gerbil","Grasshopper","Guanaco","Gundi","Hamster","Hawk","Hedgehog","Hyena","Hyrax","Jackal","Kangaroo","Kangaroo Rat","Kestrel","Kowari","Kultarr","Leopard","Lion","Macaw","Meerkat","Mouse","Oryx","Ostrich","Owl","Pronghorn","Python","Rabbit","Raccoon","Rattlesnake","Rhinoceros","Sand Cat","Spectacled Bear","Spiny Mouse","Starling","Stick Bug","Tarantula","Tit","Toad","Tortoise","Tyrant Flycatcher","Viper","Vulture","Waxwing","Xerus","Zebra"
				}
			},
			{
				AnimalTypes.Grassland,
				new string[]
				{
					"Aardvark","Aardwolf","Accentor","African Buffalo","African Wild Dog","Alpaca","Anaconda","Ant","Anteater","Antelope","Armadillo","Baboon","Badger","Bandicoot","Barbet","Bat","Bee","Bee-eater","Beetle","Bird","Bison","Black-footed Cat","Black-footed Ferret","Bluebird","Boa","Bowerbird","Brown Bear","Bush Dog","Bushshrike","Bustard","Butterfly","Buzzard","Caracal","Caracara","Cardinal","Caterpillar","Cheetah","Chipmunk","Civet","Climbing Mouse","Clouded Leopard","Coati","Cobra","Cockatoo","Cockroach","Common Genet","Cotton Rat","Cougar","Courser","Coyote","Crane","Crane Fly","Cricket","Crow","Culpeo","Death Adder","Deer","Deer Mouse","Dingo","Dinosaur","Dove","Drongo","Duck","Duiker","Dunnart","Eagle","Echidna","Elephant","Elk","Emu","Falcon","Finch","Flea","Fly","Flying Frog","Fox","Frog","Frogmouth","Garter Snake","Gazelle","Gecko","Geoffroy's Cat","Gerbil","Giant Tortoise","Giraffe","Grasshopper","Grison","Groundhog","Grouse","Guanaco","Guinea Pig","Hamster","Harrier","Hartebeest","Hawk","Hedgehog","Helmetshrike","Hippopotamus","Hornbill","Hyena","Hyrax","Impala","Jackal","Jaguar","Jaguarundi","Kangaroo","Kangaroo Rat","Kestrel","Kultarr","Ladybug","Leopard","Lion","Macaw","Meerkat","Mouse","Newt","Oryx","Ostrich","Owl","Pangolin","Pheasant","Prairie Dog","Pronghorn","Przewalski's Horse","Python","Quoll","Rabbit","Raven","Rhinoceros","Shelduck","Sloth Bear","Spectacled Bear","Squirrel","Starling","Stick Bug","Tamandua","Tasmanian Devil","Thornbill","Thrush","Toad","Tortoise"
				}
			},
			{
				AnimalTypes.Forest,
				new string[]
				{
					"Agouti","Anaconda","Anoa","Ant","Anteater","Antelope","Armadillo","Asian Black Bear","Aye-aye","Babirusa","Baboon","Badger","Bandicoot","Banteng","Barbet","Basilisk","Bat","Bearded Dragon","Bee","Bee-eater","Beetle","Bettong","Binturong","Bird-of-paradise","Bongo","Bowerbird","Bulbul","Bush Dog","Bushbaby","Bushshrike","Butterfly","Buzzard","Caecilian","Cardinal","Cassowary","Caterpillar","Centipede","Chameleon","Chimpanzee","Cicada","Civet","Clouded Leopard","Coati","Cobra","Cockatoo","Cockroach","Colugo","Cotinga","Cotton Rat","Cougar","Crane Fly","Cricket","Crocodile","Crow","Cuckoo","Cuscus","Death Adder","Deer","Dhole","Dingo","Dinosaur","Drongo","Duck","Duiker","Eagle","Echidna","Elephant","Finch","Flat-headed Cat","Flea","Flowerpecker","Fly","Flying Frog","Fossa","Frog","Frogmouth","Gaur","Gecko","Gorilla","Grison","Hawaiian Honeycreeper","Hawk","Hedgehog","Helmetshrike","Hornbill","Hyrax","Iguana","Jackal","Jaguar","Jaguarundi","Kestrel","Ladybug","Lemur","Leopard","Lion","Macaw","Mandrill","Margay","Monkey","Mouse","Mouse Deer","Newt","Okapi","Old World Flycatcher","Orangutan","Owl","Pangolin","Peafowl","Pheasant","Possum","Python","Quokka","Rabbit","Raccoon","Red Panda","Red River Hog","Rhinoceros","Sloth Bear","Spectacled Bear","Squirrel","Starling","Stick Bug","Sun Bear","Tamandua","Tamarin","Tapir","Tarantula","Thrush","Tiger","Tit","Toad","Tortoise","Toucan","Trogon","Trumpeter","Turaco","Turtle","Tyrant Flycatcher","Viper","Vulture","Wallaby","Warbler","Wasp","Waxwing","Weaver","Weaver-finch","Whistler","White-eye","Whydah","Woodswallow","Worm","Wren","Xenops","Yellowjacket","Accentor","African Buffalo","American Black Bear","Anole","Bird","Bison","Boa","Brown Bear","Chipmunk","Common Genet","Copperhead","Coyote","Deer Mouse","Dormouse","Elk","Emu","Fisher","Fox","Garter Snake","Giant Panda","Giant Tortoise","Groundhog","Grouse","Guanaco","Himalayan Tahr","Kangaroo","Koala","Numbat","Quoll","Raccoon dog","Tasmanian Devil","Thornbill","Turkey","Vole","Weasel","Wildcat","Wolf","Wombat","Woodchuck","Woodpecker"
				}
			},
			{
				AnimalTypes.Farm,
				new string[]
				{
					"Alpaca","Buffalo","Banteng","Cow","Cat","Chicken","Carp","Camel","Donkey","Dog","Duck","Emu","Goat","Gayal","Guinea","Goose","Horse","Honey","Llama","Pig","Pigeon","Rhea","Rabbit","Sheep","Silkworm","Turkey","Yak","Zebu"
				}
			},
			{
				AnimalTypes.Pets,
				new string[]
				{
					"Bearded Dragon","Birds","Burro","Cats","Chameleons","Chickens","Chinchillas","Chinese Water Dragon","Cows","Dogs","Donkey","Ducks","Ferrets","Fish","Geckos","Geese","Gerbils","Goats","Guinea Fowl","Guinea Pigs","Hamsters","Hedgehogs","Horses","Iguanas","Llamas","Lizards","Mice","Mule","Peafowl","Pigs and Hogs","Pigeons","Ponies","Pot Bellied Pig","Rabbits","Rats","Sheep","Skinks","Snakes","Stick Insects","Sugar Gliders","Tarantula","Turkeys","Turtles"
				}
			},
			{
				AnimalTypes.Zoo,
				new string[]
				{
					"Aardvark","African Wild Dog","Aldabra Tortoise","American Alligator","American Bison","Amur Tiger","Anaconda","Andean Condor","Asian Elephant","Baby Doll Sheep","Bald Eagle","Barred Owl","Blue Iguana","Boer Goat","California Sea Lion","Caribbean Flamingo","Chinchilla","Collared Lemur","Coquerel's Sifaka","Cuban Amazon Parrot","Ebony Langur","Fennec Fox","Fossa","Gelada","Giant Anteater","Giraffe","Gorilla","Grizzly Bear","Henkel's Leaf-tailed Gecko","Indian Gharial","Indian Rhinoceros","King Cobra","King Vulture","Komodo Dragon","Linne's Two-toed Sloth","Lion","Little Penguin","Madagascar Tree Boa","Magellanic Penguin","Malayan Tapir","Malayan Tiger","Matschies Tree Kangaroo","Mini Donkey","Monarch Butterfly","Nile crocodile","North American Porcupine","Nubian Ibex","Okapi","Poison Dart Frog","Polar Bear","Pygmy Marmoset","Radiated Tortoise","Red Panda","Red Ruffed Lemur","Ring-tailed Lemur","Ring-tailed Mongoose","Rock Hyrax","Small Clawed Asian Otter","Snow Leopard","Snowy Owl","Southern White-faced Owl","Southern White Rhinocerous","Squirrel Monkey","Tufted Puffin","White Cheeked Gibbon","White-throated Bee Eater","Zebra"
				}
			}
		};
	}
}
