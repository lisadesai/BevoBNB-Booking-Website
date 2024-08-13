using Team24_Final_Project.DAL;
using Team24_Final_Project.Models;
using Team24_Final_Project.Utilities;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Linq;

namespace Team24_Final_Project.Seeding
{
	public static class SeedUsers
	{
		public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
		{
			//Create list of AddUserModel function from Utilities
			List<AddUserModel> AllUsers = new List<AddUserModel>();

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "cbaker@freezing.co.uk",
					Email = "cbaker@freezing.co.uk",
					PhoneNumber = "5125595133",
					// Now add handmade properties
					FirstName = "Christopher",
					MiddleInitial = "L",
					LastName = "Baker",
					Address = "1245 Lake America Blvd.",
					Zip = "78733",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1968, 11, 28),
					Adult = true,
					IsActive = true
				},
				Password = "hellothere",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "mb@puppy.com",
					Email = "mb@puppy.com",
					PhoneNumber = "2102702860",
					// Now add handmade properties
					FirstName = "Michelle",
					MiddleInitial = "Q",
					LastName = "Bradicus",
					Address = "1300 Small Pine Lane",
					Zip = "78261",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1988, 2, 7),
					Adult = true,
					IsActive = true
				},
				Password = "555533",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "fd@puppy.com",
					Email = "fd@puppy.com",
					PhoneNumber = "8175683686",
					// Now add handmade properties
					FirstName = "Franco",
					MiddleInitial = "V",
					LastName = "Broccoli",
					Address = "62 Cookie Rd",
					Zip = "77019",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1999, 11, 7),
					Adult = true,
					IsActive = true
				},
				Password = "666645",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "wendy@puppy.com",
					Email = "wendy@puppy.com",
					PhoneNumber = "5125967209",
					// Now add handmade properties
					FirstName = "Wendy",
					MiddleInitial = "L",
					LastName = "Charile",
					Address = "202 Bellmoth Hall",
					Zip = "78713",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1992, 10, 27),
					Adult = true,
					IsActive = true
				},
				Password = "Kansas",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "limchou@puppy.com",
					Email = "limchou@puppy.com",
					PhoneNumber = "2107748586",
					// Now add handmade properties
					FirstName = "Lim",
					MiddleInitial = "Q",
					LastName = "Chou",
					Address = "1600 Barbara Lane",
					Zip = "78266",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1961, 11, 11),
					Adult = true,
					IsActive = true
				},
				Password = "Rockwall",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "444444.Dave@aool.com",
					Email = "444444.Dave@aool.com",
					PhoneNumber = "2142667242",
					// Now add handmade properties
					FirstName = "Shan",
					MiddleInitial = "D",
					LastName = "Dave",
					Address = "234 Puppy Circle",
					Zip = "75208",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1972, 12, 19),
					Adult = true,
					IsActive = true
				},
				Password = "444444",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "louann@puppy.com",
					Email = "louann@puppy.com",
					PhoneNumber = "8172580736",
					// Now add handmade properties
					FirstName = "Lou Ann",
					MiddleInitial = "K",
					LastName = "Feeley",
					Address = "700 S 9th Street W",
					Zip = "77010",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1958, 8, 1),
					Adult = true,
					IsActive = true
				},
				Password = "longhorns",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "tfreeley@puppy.com",
					Email = "tfreeley@puppy.com",
					PhoneNumber = "8173279674",
					// Now add handmade properties
					FirstName = "Tesa",
					MiddleInitial = "P",
					LastName = "Freeley",
					Address = "4334 Meanview Ave.",
					Zip = "77009",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(2001, 7, 12),
					Adult = true,
					IsActive = true
				},
				Password = "puppies",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "mgar@puppy.com",
					Email = "mgar@puppy.com",
					PhoneNumber = "8176617531",
					// Now add handmade properties
					FirstName = "Margaret",
					MiddleInitial = "L",
					LastName = "Garcia",
					Address = "594 Puppyview",
					Zip = "77003",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1956, 11, 17),
					Adult = true,
					IsActive = true
				},
				Password = "horses",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "chaley@thug.com",
					Email = "chaley@thug.com",
					PhoneNumber = "2148499570",
					// Now add handmade properties
					FirstName = "Charles",
					MiddleInitial = "E",
					LastName = "Harley",
					Address = "One Ranger Pkwy",
					Zip = "75261",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1998, 5, 29),
					Adult = true,
					IsActive = true
				},
				Password = "mycats",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "jeff@puppy.com",
					Email = "jeff@puppy.com",
					PhoneNumber = "5127002600",
					// Now add handmade properties
					FirstName = "Jeffrey",
					MiddleInitial = "T",
					LastName = "Stark",
					Address = "337 40th St.",
					Zip = "78705",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1974, 5, 2),
					Adult = true,
					IsActive = true
				},
				Password = "jeffery",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "wjhearniii@umch.edu",
					Email = "wjhearniii@umch.edu",
					PhoneNumber = "2148989608",
					// Now add handmade properties
					FirstName = "John",
					MiddleInitial = "B",
					LastName = "Hearn",
					Address = "4445 South First",
					Zip = "75237",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1983, 12, 29),
					Adult = true,
					IsActive = true
				},
				Password = "posicles",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "hicks43@puppy.com",
					Email = "hicks43@puppy.com",
					PhoneNumber = "2105812952",
					// Now add handmade properties
					FirstName = "Mark",
					MiddleInitial = "J",
					LastName = "Hicks",
					Address = "32 NE Mark Ln., Ste 910",
					Zip = "78239",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1989, 12, 16),
					Adult = true,
					IsActive = true
				},
				Password = "guac45",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "bradsingram@mall.utexas.edu",
					Email = "bradsingram@mall.utexas.edu",
					PhoneNumber = "5124702808",
					// Now add handmade properties
					FirstName = "Brad",
					MiddleInitial = "S",
					LastName = "Ingram",
					Address = "6548 La Chess St.",
					Zip = "78736",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1958, 9, 18),
					Adult = true,
					IsActive = true
				},
				Password = "father",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "father.Ingram@aool.com",
					Email = "father.Ingram@aool.com",
					PhoneNumber = "5124677352",
					// Now add handmade properties
					FirstName = "Todd",
					MiddleInitial = "L",
					LastName = "Jacobs",
					Address = "4564 Palm St.",
					Zip = "78731",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1975, 12, 9),
					Adult = true,
					IsActive = true
				},
				Password = "555897",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "victoria@puppy.com",
					Email = "victoria@puppy.com",
					PhoneNumber = "5129481386",
					// Now add handmade properties
					FirstName = "Victoria",
					MiddleInitial = "M",
					LastName = "Lawrence",
					Address = "6639 Butterfly Ln.",
					Zip = "78761",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1981, 5, 29),
					Adult = true,
					IsActive = true
				},
				Password = "something",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "lineback@flush.net",
					Email = "lineback@flush.net",
					PhoneNumber = "2102473963",
					// Now add handmade properties
					FirstName = "Brad",
					MiddleInitial = "W",
					LastName = "Lineback",
					Address = "1300 Pirateland St",
					Zip = "78293",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1973, 5, 19),
					Adult = true,
					IsActive = true
				},
				Password = "treelover",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "elowe@netscrape.net",
					Email = "elowe@netscrape.net",
					PhoneNumber = "2105368614",
					// Now add handmade properties
					FirstName = "Evan",
					MiddleInitial = "S",
					LastName = "Lowe",
					Address = "3201 Pineapple Drive",
					Zip = "78279",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1993, 6, 7),
					Adult = true,
					IsActive = true
				},
				Password = "headear",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "luce_chuck@puppy.com",
					Email = "luce_chuck@puppy.com",
					PhoneNumber = "2107007535",
					// Now add handmade properties
					FirstName = "Chuck",
					MiddleInitial = "B",
					LastName = "Luce",
					Address = "2345 Silent Clouds",
					Zip = "78268",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1995, 6, 11),
					Adult = true,
					IsActive = true
				},
				Password = "gooseyloosey",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "mackcloud@pimpdaddy.com",
					Email = "mackcloud@pimpdaddy.com",
					PhoneNumber = "5124772125",
					// Now add handmade properties
					FirstName = "Jennifer",
					MiddleInitial = "D",
					LastName = "MacLeod",
					Address = "2504 Far East Blvd.",
					Zip = "78731",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1965, 10, 11),
					Adult = true,
					IsActive = true
				},
				Password = "rainyday",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "liz@puppy.com",
					Email = "liz@puppy.com",
					PhoneNumber = "5124603832",
					// Now add handmade properties
					FirstName = "Elizabeth",
					MiddleInitial = "P",
					LastName = "Markham",
					Address = "7861 Chevy Mace Rd",
					Zip = "78732",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1989, 6, 18),
					Adult = true,
					IsActive = true
				},
				Password = "ember22",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "mclarence@puppy.com",
					Email = "mclarence@puppy.com",
					PhoneNumber = "8174979188",
					// Now add handmade properties
					FirstName = "Clarence",
					MiddleInitial = "A",
					LastName = "Martin",
					Address = "87 Alcedo St.",
					Zip = "77045",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1984, 4, 28),
					Adult = true,
					IsActive = true
				},
				Password = "lamemartin",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "lamemartin.Martin@aool.com",
					Email = "lamemartin.Martin@aool.com",
					PhoneNumber = "8178770705",
					// Now add handmade properties
					FirstName = "Gregory",
					MiddleInitial = "R",
					LastName = "Martinez",
					Address = "8295 Moon Blvd.",
					Zip = "77030",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1981, 12, 27),
					Adult = true,
					IsActive = true
				},
				Password = "gregory",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "cmiller@mapster.com",
					Email = "cmiller@mapster.com",
					PhoneNumber = "8177482602",
					// Now add handmade properties
					FirstName = "Charles",
					MiddleInitial = "R",
					LastName = "Miller",
					Address = "8962 Side St.",
					Zip = "77031",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1987, 5, 5),
					Adult = true,
					IsActive = true
				},
				Password = "mucky44",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "nelson.Kelly@puppy.com",
					Email = "nelson.Kelly@puppy.com",
					PhoneNumber = "5122950953",
					// Now add handmade properties
					FirstName = "Kelly",
					MiddleInitial = "T",
					LastName = "Nelson",
					Address = "2601 Green River",
					Zip = "78703",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1969, 8, 3),
					Adult = true,
					IsActive = true
				},
				Password = "Tree34",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "jojoe@puppy.com",
					Email = "jojoe@puppy.com",
					PhoneNumber = "2143149884",
					// Now add handmade properties
					FirstName = "Joe",
					MiddleInitial = "C",
					LastName = "Nguyen",
					Address = "1249 4th NW St.",
					Zip = "75238",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1956, 2, 6),
					Adult = true,
					IsActive = true
				},
				Password = "jvb485bg",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "orielly@foxnets.com",
					Email = "orielly@foxnets.com",
					PhoneNumber = "2103474912",
					// Now add handmade properties
					FirstName = "Bill",
					MiddleInitial = "T",
					LastName = "O'Reilly",
					Address = "8800 Gringo Drive",
					Zip = "78260",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1989, 3, 14),
					Adult = true,
					IsActive = true
				},
				Password = "Bobbygirl",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "or@puppy.com",
					Email = "or@puppy.com",
					PhoneNumber = "2142369553",
					// Now add handmade properties
					FirstName = "Anka",
					MiddleInitial = "L",
					LastName = "Radkovich",
					Address = "1300 Freaky",
					Zip = "75260",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1952, 10, 26),
					Adult = true,
					IsActive = true
				},
				Password = "radioactive",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "megrhodes@freezing.co.uk",
					Email = "megrhodes@freezing.co.uk",
					PhoneNumber = "5123768733",
					// Now add handmade properties
					FirstName = "Megan",
					MiddleInitial = "C",
					LastName = "Rhodes",
					Address = "4587 Rightfield Rd.",
					Zip = "78707",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1958, 3, 18),
					Adult = true,
					IsActive = true
				},
				Password = "gopigs",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "erynrice@puppy.com",
					Email = "erynrice@puppy.com",
					PhoneNumber = "5123900644",
					// Now add handmade properties
					FirstName = "Eryn",
					MiddleInitial = "M",
					LastName = "Rice",
					Address = "3405 Rio Small",
					Zip = "78705",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(2000, 11, 2),
					Adult = true,
					IsActive = true
				},
				Password = "iloveme",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "jorge@hootmail.com",
					Email = "jorge@hootmail.com",
					PhoneNumber = "8178928361",
					// Now add handmade properties
					FirstName = "Jorge",
					MiddleInitial = "",
					LastName = "Rodriguez",
					Address = "6788 Cotten Street",
					Zip = "77057",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1979, 1, 1),
					Adult = true,
					IsActive = true
				},
				Password = "565656",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "ra@aoo.com",
					Email = "ra@aoo.com",
					PhoneNumber = "5128776930",
					// Now add handmade properties
					FirstName = "Allen",
					MiddleInitial = "B",
					LastName = "Rogers",
					Address = "4965 Rabbit Hill",
					Zip = "78732",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(2000, 3, 12),
					Adult = true,
					IsActive = true
				},
				Password = "treeman",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "o_st-jean@home.com",
					Email = "o_st-jean@home.com",
					PhoneNumber = "2104169665",
					// Now add handmade properties
					FirstName = "Olivier",
					MiddleInitial = "M",
					LastName = "Saint-Jean",
					Address = "255 Slap Dr.",
					Zip = "78292",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1997, 5, 1),
					Adult = true,
					IsActive = true
				},
				Password = "55htrq",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "ss34@puppy.com",
					Email = "ss34@puppy.com",
					PhoneNumber = "5123521797",
					// Now add handmade properties
					FirstName = "Sarah",
					MiddleInitial = "J",
					LastName = "Saunders",
					Address = "332 Fish C",
					Zip = "78705",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1994, 5, 31),
					Adult = true,
					IsActive = true
				},
				Password = "leaves",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "willsheff@email.com",
					Email = "willsheff@email.com",
					PhoneNumber = "5124534071",
					// Now add handmade properties
					FirstName = "William",
					MiddleInitial = "T",
					LastName = "Sewell",
					Address = "2365 34st St.",
					Zip = "78709",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1951, 12, 10),
					Adult = true,
					IsActive = true
				},
				Password = "borbj44",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "sheff44@puppy.com",
					Email = "sheff44@puppy.com",
					PhoneNumber = "5125503154",
					// Now add handmade properties
					FirstName = "Martin",
					MiddleInitial = "J",
					LastName = "Sheffield",
					Address = "3886 Road A",
					Zip = "78705",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1993, 7, 2),
					Adult = true,
					IsActive = true
				},
				Password = "ldiul485",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "johnsmith187@puppy.com",
					Email = "johnsmith187@puppy.com",
					PhoneNumber = "2108345875",
					// Now add handmade properties
					FirstName = "John",
					MiddleInitial = "A",
					LastName = "Smith",
					Address = "23 Known Forge Dr.",
					Zip = "78280",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1985, 6, 13),
					Adult = true,
					IsActive = true
				},
				Password = "kribv75",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "dustroud@mail.com",
					Email = "dustroud@mail.com",
					PhoneNumber = "2142370654",
					// Now add handmade properties
					FirstName = "Dustin",
					MiddleInitial = "P",
					LastName = "Stroud",
					Address = "1212 Henrietta Rd",
					Zip = "75221",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1974, 7, 14),
					Adult = true,
					IsActive = true
				},
				Password = "klavjkb48",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "eric_stuart@puppy.com",
					Email = "eric_stuart@puppy.com",
					PhoneNumber = "5128202322",
					// Now add handmade properties
					FirstName = "Eric",
					MiddleInitial = "D",
					LastName = "Stuart",
					Address = "5576 Big Ring",
					Zip = "78746",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1968, 6, 17),
					Adult = true,
					IsActive = true
				},
				Password = "vkb451",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "peterstump@hootmail.com",
					Email = "peterstump@hootmail.com",
					PhoneNumber = "8174584890",
					// Now add handmade properties
					FirstName = "Peter",
					MiddleInitial = "L",
					LastName = "Stump",
					Address = "1300 Kellen Square",
					Zip = "77018",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(2001, 7, 23),
					Adult = true,
					IsActive = true
				},
				Password = "kdsiu4",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "tanner@puppy.com",
					Email = "tanner@puppy.com",
					PhoneNumber = "8174614916",
					// Now add handmade properties
					FirstName = "Jeremy",
					MiddleInitial = "S",
					LastName = "Tanner",
					Address = "4347 Palmstead",
					Zip = "77044",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1973, 12, 28),
					Adult = true,
					IsActive = true
				},
				Password = "klrfbj45",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "taylordjay@puppy.com",
					Email = "taylordjay@puppy.com",
					PhoneNumber = "5124772439",
					// Now add handmade properties
					FirstName = "Allison",
					MiddleInitial = "R",
					LastName = "Taylor",
					Address = "467 Nueces St.",
					Zip = "78705",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1999, 9, 30),
					Adult = true,
					IsActive = true
				},
				Password = "lraggrhb854",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "lraggrhb854.Taylor@aool.com",
					Email = "lraggrhb854.Taylor@aool.com",
					PhoneNumber = "5124536618",
					// Now add handmade properties
					FirstName = "Rachel",
					MiddleInitial = "K",
					LastName = "Taylor",
					Address = "345 Shortview Dr.",
					Zip = "78705",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1956, 2, 24),
					Adult = true,
					IsActive = true
				},
				Password = "alsuib95",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "tee_frank@hootmail.com",
					Email = "tee_frank@hootmail.com",
					PhoneNumber = "8178789530",
					// Now add handmade properties
					FirstName = "Frank",
					MiddleInitial = "J",
					LastName = "Tee",
					Address = "5590 Big Dr.",
					Zip = "77004",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1964, 11, 11),
					Adult = true,
					IsActive = true
				},
				Password = "kd1734",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "tuck33@puppy.com",
					Email = "tuck33@puppy.com",
					PhoneNumber = "2148495141",
					// Now add handmade properties
					FirstName = "Clent",
					MiddleInitial = "J",
					LastName = "Tucker",
					Address = "3132 Main St.",
					Zip = "75315",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1990, 6, 25),
					Adult = true,
					IsActive = true
				},
				Password = "kjdb983",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "avelasco@puppy.com",
					Email = "avelasco@puppy.com",
					PhoneNumber = "2144009625",
					// Now add handmade properties
					FirstName = "Allen",
					MiddleInitial = "G",
					LastName = "Velasco",
					Address = "634 W. 4th",
					Zip = "75207",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1966, 12, 13),
					Adult = true,
					IsActive = true
				},
				Password = "odrb02",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "westj@pioneer.net",
					Email = "westj@pioneer.net",
					PhoneNumber = "2148499231",
					// Now add handmade properties
					FirstName = "Jake",
					MiddleInitial = "T",
					LastName = "West",
					Address = "RR 3244",
					Zip = "75323",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1968, 2, 6),
					Adult = true,
					IsActive = true
				},
				Password = "kndl847",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "louielouie@puppy.com",
					Email = "louielouie@puppy.com",
					PhoneNumber = "2145674085",
					// Now add handmade properties
					FirstName = "Louis",
					MiddleInitial = "L",
					LastName = "Winthorpe",
					Address = "2500 Madre Blvd",
					Zip = "78746",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1961, 7, 23),
					Adult = true,
					IsActive = true
				},
				Password = "lb2394",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "rwood@voyager.net",
					Email = "rwood@voyager.net",
					PhoneNumber = "5124569229",
					// Now add handmade properties
					FirstName = "Reagan",
					MiddleInitial = "B",
					LastName = "Wood",
					Address = "447 Westlake Dr.",
					Zip = "78746",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1988, 10, 24),
					Adult = true,
					IsActive = true
				},
				Password = "drai494",
				RoleName = "Customer"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "jacobs@yahoo.com",
					Email = "jacobs@yahoo.com",
					PhoneNumber = "8176663948",
					// Now add handmade properties
					FirstName = "Todd",
					MiddleInitial = "L",
					LastName = "Jacobs",
					Address = "4564 Elm St.",
					Zip = "77003",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1978, 1, 29),
					Adult = true,
					IsActive = true
				},
				Password = "tj2245",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "rice@yahoo.com",
					Email = "rice@yahoo.com",
					PhoneNumber = "2148545987",
					// Now add handmade properties
					FirstName = "Eryn",
					MiddleInitial = "M",
					LastName = "Rice",
					Address = "3405 Rio Grande",
					Zip = "75261",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(2003, 6, 11),
					Adult = true,
					IsActive = true
				},
				Password = "ricearoni",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "ingram@gmail.com",
					Email = "ingram@gmail.com",
					PhoneNumber = "5127049017",
					// Now add handmade properties
					FirstName = "John",
					MiddleInitial = "R",
					LastName = "Ingram",
					Address = "6548 La Posada Ct.",
					Zip = "78705",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1980, 6, 25),
					Adult = true,
					IsActive = true
				},
				Password = "ingram68",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "martinez@aol.com",
					Email = "martinez@aol.com",
					PhoneNumber = "2105859369",
					// Now add handmade properties
					FirstName = "Paul",
					MiddleInitial = "G",
					LastName = "Martinez",
					Address = "8295 Sunset Blvd.",
					Zip = "78239",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1969, 6, 25),
					Adult = true,
					IsActive = true
				},
				Password = "party1",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "tanner@utexas.edu",
					Email = "tanner@utexas.edu",
					PhoneNumber = "5129527803",
					// Now add handmade properties
					FirstName = "Jared",
					MiddleInitial = "F",
					LastName = "Tanner",
					Address = "4347 Almstead",
					Zip = "78761",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1979, 6, 2),
					Adult = true,
					IsActive = true
				},
				Password = "sandman",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "chung@yahoo.com",
					Email = "chung@yahoo.com",
					PhoneNumber = "2107053952",
					// Now add handmade properties
					FirstName = "Lauren",
					MiddleInitial = "R",
					LastName = "Chung",
					Address = "234 RR 12",
					Zip = "78268",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1976, 3, 24),
					Adult = true,
					IsActive = true
				},
				Password = "listen",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "loter@yahoo.com",
					Email = "loter@yahoo.com",
					PhoneNumber = "5124650249",
					// Now add handmade properties
					FirstName = "Wandavison",
					MiddleInitial = "T",
					LastName = "Loter",
					Address = "3453 RR 3235",
					Zip = "78732",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1966, 9, 23),
					Adult = true,
					IsActive = true
				},
				Password = "pottery",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "morales@aol.com",
					Email = "morales@aol.com",
					PhoneNumber = "8177529019",
					// Now add handmade properties
					FirstName = "Heather",
					MiddleInitial = "R",
					LastName = "Morales",
					Address = "4501 RR 140",
					Zip = "77031",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1971, 1, 16),
					Adult = true,
					IsActive = true
				},
				Password = "heckin",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "rankin@yahoo.com",
					Email = "rankin@yahoo.com",
					PhoneNumber = "5122997370",
					// Now add handmade properties
					FirstName = "Martin",
					MiddleInitial = "P",
					LastName = "Rankin",
					Address = "340 Second St",
					Zip = "78703",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1961, 5, 16),
					Adult = true,
					IsActive = true
				},
				Password = "rankmark",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "gonzalez@aol.com",
					Email = "gonzalez@aol.com",
					PhoneNumber = "2142415970",
					// Now add handmade properties
					FirstName = "Garth",
					MiddleInitial = "R",
					LastName = "Gonzalez",
					Address = "103 Manor Rd",
					Zip = "75260",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1993, 12, 10),
					Adult = true,
					IsActive = true
				},
				Password = "gg2017",
				RoleName = "Host"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "taylor@bevobnb.com",
					Email = "taylor@bevobnb.com",
					PhoneNumber = "2149036025",
					// Now add handmade properties
					FirstName = "Albert",
					MiddleInitial = "F",
					LastName = "Taylor",
					Address = "467 Nueces St.",
					Zip = "75237",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1954, 8, 14),
					Adult = true,
					IsActive = true
				},
				Password = "TRY563",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "sheffield@bevobnb.com",
					Email = "sheffield@bevobnb.com",
					PhoneNumber = "5124749225",
					// Now add handmade properties
					FirstName = "Molly",
					MiddleInitial = "R",
					LastName = "Sheffield",
					Address = "3886 Avenue A",
					Zip = "78736",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1986, 8, 27),
					Adult = true,
					IsActive = true
				},
				Password = "longsnores",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "macleod@bevobnb.com",
					Email = "macleod@bevobnb.com",
					PhoneNumber = "5124723769",
					// Now add handmade properties
					FirstName = "Jenny",
					MiddleInitial = "I",
					LastName = "MacLeod",
					Address = "2504 Far West Blvd.",
					Zip = "78731",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1984, 12, 5),
					Adult = true,
					IsActive = true
				},
				Password = "kittys",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "rhodes@bevobnb.com",
					Email = "rhodes@bevobnb.com",
					PhoneNumber = "2102520380",
					// Now add handmade properties
					FirstName = "Michelle",
					MiddleInitial = "N",
					LastName = "Rhodes",
					Address = "4587 Enfield Rd.",
					Zip = "78293",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1972, 7, 2),
					Adult = true,
					IsActive = true
				},
				Password = "puppies",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "stuart@bevobnb.com",
					Email = "stuart@bevobnb.com",
					PhoneNumber = "2105415031",
					// Now add handmade properties
					FirstName = "Evan",
					MiddleInitial = "Q",
					LastName = "Stuart",
					Address = "5576 Toro Ring",
					Zip = "78279",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1984, 4, 17),
					Adult = true,
					IsActive = true
				},
				Password = "coolboi",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "swanson@bevobnb.com",
					Email = "swanson@bevobnb.com",
					PhoneNumber = "5124818542",
					// Now add handmade properties
					FirstName = "Ron",
					MiddleInitial = "P",
					LastName = "Swanson",
					Address = "245 River Rd",
					Zip = "78731",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1991, 7, 25),
					Adult = true,
					IsActive = true
				},
				Password = "swanbong",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "white@bevobnb.com",
					Email = "white@bevobnb.com",
					PhoneNumber = "8175025605",
					// Now add handmade properties
					FirstName = "Jabriel",
					MiddleInitial = "M",
					LastName = "White",
					Address = "12 Valley View",
					Zip = "77045",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1986, 3, 17),
					Adult = true,
					IsActive = true
				},
				Password = "456789",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "montgomery@bevobnb.com",
					Email = "montgomery@bevobnb.com",
					PhoneNumber = "8178817122",
					// Now add handmade properties
					FirstName = "Washington",
					MiddleInitial = "X",
					LastName = "Montgomery",
					Address = "210 Blanco Dr",
					Zip = "77030",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1961, 5, 4),
					Adult = true,
					IsActive = true
				},
				Password = "python4",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "walker@bevobnb.com",
					Email = "walker@bevobnb.com",
					PhoneNumber = "2143196301",
					// Now add handmade properties
					FirstName = "Lisa",
					MiddleInitial = "O",
					LastName = "Walker",
					Address = "9 Bison Circle",
					Zip = "75238",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(2003, 4, 18),
					Adult = true,
					IsActive = true
				},
				Password = "walkameter",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "chang@bevobnb.com",
					Email = "chang@bevobnb.com",
					PhoneNumber = "2103521329",
					// Now add handmade properties
					FirstName = "Gregory",
					MiddleInitial = "J",
					LastName = "Chang",
					Address = "9003 Joshua St",
					Zip = "78260",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(1958, 4, 26),
					Adult = true,
					IsActive = true
				},
				Password = "pupgang",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "derek@bevobnb.com",
					Email = "derek@bevobnb.com",
					PhoneNumber = "5125556789",
					// Now add handmade properties
					FirstName = "Derek",
					MiddleInitial = "X",
					LastName = "Dreibrodt",
					Address = "4 Privet Dr",
					Zip = "78705",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(2001, 1, 1),
					Adult = true,
					IsActive = true
				},
				Password = "2cool4u",
				RoleName = "Admin"
			});

			AllUsers.Add(new AddUserModel()
			{
				User = new AppUser()
				{
					// Use Identity base class here
					UserName = "rester@bevobnb.com",
					Email = "rester@bevobnb.com",
					PhoneNumber = "2103521329",
					// Now add handmade properties
					FirstName = "Amy",
					MiddleInitial = "K",
					LastName = "Rester",
					Address = "2110 Speedway",
					Zip = "78705",
					// Birthday is set as a DateTime variable
					Birthday = new DateTime(2000, 1, 1),
					Adult = true,
					IsActive = true
				},
				Password = "KIzGreat",
				RoleName = "Admin"
			});

			//create flag to help with errors
			String errorFlag = "Start";
			//create an identity result
			IdentityResult result = new IdentityResult();
			//call the method to seed the user
			try
			{
				foreach (AddUserModel aum in AllUsers)
				{
					errorFlag = aum.User.Email;
					result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
				}
			}
			catch (Exception ex)
			{
				throw new Exception("There was a problem adding the user with email: " + errorFlag, ex);
			}

			return result;
		}
	}
}
