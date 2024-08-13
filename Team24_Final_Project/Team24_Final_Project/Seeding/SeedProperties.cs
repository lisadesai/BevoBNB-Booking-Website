using Team24_Final_Project.DAL;
using Team24_Final_Project.Models;
using Team24_Final_Project;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Linq;
using System.Text;

namespace Team24_Final_Project.Seeding
{
	public static class SeedProperties
	{
		public static void SeedAllProperties(AppDbContext context)
		{
			//Create a counter and flag to know where problem is
			Int32 intPropsAdded = 0;
			String strProperty = "Begin";
			//Create a list from the Property model class
			List<Property> Properties = new List<Property>();
			Int32 propNum = 3001;

			try
			{
				Property p1 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "72227",
					State = "PA",
					PropertyAddress = "8714 Mann Plaza",
					City = "Lisaside",
					WeekendPrice = 171.57m,
					WeekdayPrice = 152.68m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 8.88m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 6,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p1.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p1.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p1);
				propNum++;

				Property p2 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "05565",
					State = "FL",
					PropertyAddress = "96593 White View Apt. 094",
					City = "Jonesberg",
					WeekendPrice = 148.15m,
					WeekdayPrice = 120.81m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 8.02m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 8,
					GuestLimit = 8,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p2.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p2.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p2);
				propNum++;

				Property p3 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "80819",
					State = "MD",
					PropertyAddress = "848 Melissa Springs Suite 947",
					City = "Kellerstad",
					WeekendPrice = 132.99m,
					WeekdayPrice = 127.96m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 13.37m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 8,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p3.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p3.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p3);
				propNum++;

				Property p4 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "79428",
					State = "ND",
					PropertyAddress = "30413 Norton Isle Suite 012",
					City = "North Lisa",
					WeekendPrice = 185.35m,
					WeekdayPrice = 80.2m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 5.57m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p4.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p4.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p4);
				propNum++;

				Property p5 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "63315",
					State = "DE",
					PropertyAddress = "39916 Mitchell Crescent",
					City = "New Andrewburgh",
					WeekendPrice = 100.37m,
					WeekdayPrice = 170.25m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 18.64m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 3,
					GuestLimit = 12,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p5.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p5.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p5);
				propNum++;

				Property p6 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "24135",
					State = "NE",
					PropertyAddress = "086 Mary Cliff",
					City = "North Deborah",
					WeekendPrice = 162.6m,
					WeekdayPrice = 220.24m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 10.83m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 9,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p6.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p6.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p6);
				propNum++;

				Property p7 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "58475",
					State = "PA",
					PropertyAddress = "91634 Strong Mountains Apt. 302",
					City = "West Alyssa",
					WeekendPrice = 204.87m,
					WeekdayPrice = 213.37m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 25.04m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p7.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p7.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p7);
				propNum++;

				Property p8 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "10865",
					State = "WA",
					PropertyAddress = "6984 Price Shoals",
					City = "Erictown",
					WeekendPrice = 140.89m,
					WeekdayPrice = 159.69m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 27.13m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 3,
					GuestLimit = 8,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p8.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p8.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p8);
				propNum++;

				Property p9 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "51359",
					State = "ME",
					PropertyAddress = "423 Bell Heights",
					City = "Brittanyberg",
					WeekendPrice = 295.39m,
					WeekdayPrice = 200.73m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 14.91m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 3,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p9.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p9.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p9);
				propNum++;

				Property p10 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "87296",
					State = "WI",
					PropertyAddress = "93523 Dana Lane",
					City = "Johnsonshire",
					WeekendPrice = 110.8m,
					WeekdayPrice = 170.39m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 8.67m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 6,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p10.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p10.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p10);
				propNum++;

				Property p11 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "07035",
					State = "NH",
					PropertyAddress = "1427 Odonnell Rapids",
					City = "North Troyport",
					WeekendPrice = 126.29m,
					WeekdayPrice = 217.15m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 26.48m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 3,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p11.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p11.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p11);
				propNum++;

				Property p12 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "37198",
					State = "ME",
					PropertyAddress = "81206 Stewart Forest Apt. 089",
					City = "East Davidborough",
					WeekendPrice = 293.26m,
					WeekdayPrice = 205.21m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 28.74m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 5,
					GuestLimit = 8,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p12.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p12.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p12);
				propNum++;

				Property p13 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "85034",
					State = "SD",
					PropertyAddress = "76104 Marsh Crescent",
					City = "Dennishaven",
					WeekendPrice = 126.99m,
					WeekdayPrice = 123.13m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 18.73m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 7,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p13.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p13.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p13);
				propNum++;

				Property p14 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "60619",
					State = "SD",
					PropertyAddress = "0003 Grant Lakes",
					City = "Port Karafort",
					WeekendPrice = 188.81m,
					WeekdayPrice = 89.19m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 11.98m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 5,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p14.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p14.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p14);
				propNum++;

				Property p15 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "21978",
					State = "KY",
					PropertyAddress = "236 Smith Drive Suite 555",
					City = "West Kimberlyton",
					WeekendPrice = 132.96m,
					WeekdayPrice = 198.3m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 13.96m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p15.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p15.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p15);
				propNum++;

				Property p16 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "14742",
					State = "MT",
					PropertyAddress = "6824 Timothy Garden Apt. 428",
					City = "West Richardmouth",
					WeekendPrice = 297.31m,
					WeekdayPrice = 181.5m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 10.09m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 6,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p16.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p16.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p16);
				propNum++;

				Property p17 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "11894",
					State = "SC",
					PropertyAddress = "5517 Holly Meadow Apt. 452",
					City = "Lake Anne",
					WeekendPrice = 139.22m,
					WeekdayPrice = 134.09m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 9.75m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p17.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p17.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p17);
				propNum++;

				Property p18 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "28976",
					State = "TX",
					PropertyAddress = "30601 Hawkins Highway",
					City = "Morashire",
					WeekendPrice = 160.61m,
					WeekdayPrice = 187.65m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 7.5m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 5,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p18.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p18.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p18);
				propNum++;

				Property p19 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "28798",
					State = "AZ",
					PropertyAddress = "49263 Wilson View Apt. 873",
					City = "South Raymondborough",
					WeekendPrice = 133.25m,
					WeekdayPrice = 206.95m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 14.04m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 5,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p19.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p19.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p19);
				propNum++;

				Property p20 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "68819",
					State = "NE",
					PropertyAddress = "76582 Vanessa Oval",
					City = "New Richard",
					WeekendPrice = 242.89m,
					WeekdayPrice = 99.54m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 6.61m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 4,
					GuestLimit = 12,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p20.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p20.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p20);
				propNum++;

				Property p21 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "50177",
					State = "FL",
					PropertyAddress = "7389 Alec Squares Suite 508",
					City = "Port Jonathan",
					WeekendPrice = 165.32m,
					WeekdayPrice = 112.62m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 24.26m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 7,
					GuestLimit = 12,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p21.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p21.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p21);
				propNum++;

				Property p22 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "66355",
					State = "NC",
					PropertyAddress = "18013 Billy Bridge Suite 522",
					City = "Schmitthaven",
					WeekendPrice = 119.02m,
					WeekdayPrice = 199.21m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 11.63m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 4,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p22.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p22.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p22);
				propNum++;

				Property p23 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "51431",
					State = "NJ",
					PropertyAddress = "891 Bullock Ford",
					City = "Amandachester",
					WeekendPrice = 244.93m,
					WeekdayPrice = 179.05m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 21.78m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 6,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p23.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p23.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p23);
				propNum++;

				Property p24 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "50853",
					State = "MT",
					PropertyAddress = "02489 Cook Park",
					City = "Sherriport",
					WeekendPrice = 227.35m,
					WeekdayPrice = 207.24m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 5.5m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 3,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p24.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p24.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p24);
				propNum++;

				Property p25 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "20341",
					State = "UT",
					PropertyAddress = "23450 Timothy Divide",
					City = "Wuland",
					WeekendPrice = 278.36m,
					WeekdayPrice = 116.01m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 24.73m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 4,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p25.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p25.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p25);
				propNum++;

				Property p26 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "85565",
					State = "OH",
					PropertyAddress = "0976 Williams Mountains Apt. 009",
					City = "Lake Mario",
					WeekendPrice = 293.42m,
					WeekdayPrice = 225.14m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 10.42m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 7,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p26.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p26.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p26);
				propNum++;

				Property p27 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "51884",
					State = "WY",
					PropertyAddress = "1097 Santos Springs Suite 264",
					City = "New Michelleborough",
					WeekendPrice = 126.45m,
					WeekdayPrice = 70.24m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 18.69m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 2,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p27.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p27.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p27);
				propNum++;

				Property p28 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "66353",
					State = "SC",
					PropertyAddress = "5100 Scott Burg",
					City = "East Clayton",
					WeekendPrice = 224.07m,
					WeekdayPrice = 186.38m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 28.24m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 3,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p28.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p28.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p28);
				propNum++;

				Property p29 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "57004",
					State = "NV",
					PropertyAddress = "412 Snow Manors Apt. 161",
					City = "South Kimtown",
					WeekendPrice = 120.93m,
					WeekdayPrice = 112.47m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 23.28m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p29.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p29.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p29);
				propNum++;

				Property p30 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "48447",
					State = "IN",
					PropertyAddress = "5415 David Square",
					City = "West Michaeltown",
					WeekendPrice = 100.02m,
					WeekdayPrice = 214.81m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 17.78m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 9,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p30.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p30.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p30);
				propNum++;

				Property p31 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "62982",
					State = "DE",
					PropertyAddress = "03104 Norris Rapids",
					City = "Port Donald",
					WeekendPrice = 161.6m,
					WeekdayPrice = 159.87m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 10.34m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p31.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p31.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p31);
				propNum++;

				Property p32 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "16915",
					State = "FL",
					PropertyAddress = "03557 Phillips Wells Suite 291",
					City = "New Beverlyburgh",
					WeekendPrice = 203.6m,
					WeekdayPrice = 70.55m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 5.09m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 6,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p32.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p32.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p32);
				propNum++;

				Property p33 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "39742",
					State = "MT",
					PropertyAddress = "332 Watson Shore Apt. 290",
					City = "Millerland",
					WeekendPrice = 299.34m,
					WeekdayPrice = 176.37m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 17.38m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 3,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p33.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p33.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p33);
				propNum++;

				Property p34 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "54060",
					State = "MS",
					PropertyAddress = "645 John Roads",
					City = "Danahaven",
					WeekendPrice = 229.98m,
					WeekdayPrice = 172.83m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 23.55m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 6,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p34.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p34.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p34);
				propNum++;

				Property p35 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "55774",
					State = "HI",
					PropertyAddress = "3547 Stephanie Underpass Apt. 418",
					City = "Port Jacqueline",
					WeekendPrice = 143.71m,
					WeekdayPrice = 177.08m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 19.21m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 1,
					GuestLimit = 5,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p35.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p35.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p35);
				propNum++;

				Property p36 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "59363",
					State = "UT",
					PropertyAddress = "5825 Welch Corners",
					City = "Fischerport",
					WeekendPrice = 113.86m,
					WeekdayPrice = 76.66m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 27.87m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 4,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p36.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p36.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p36);
				propNum++;

				Property p37 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "71770",
					State = "IN",
					PropertyAddress = "41489 Roger Terrace",
					City = "Davisfort",
					WeekendPrice = 299.09m,
					WeekdayPrice = 177.37m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 23.78m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 8,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p37.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p37.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p37);
				propNum++;

				Property p38 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "05147",
					State = "CO",
					PropertyAddress = "014 Aaron Locks Suite 714",
					City = "Justinborough",
					WeekendPrice = 158.42m,
					WeekdayPrice = 104.05m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 5.36m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 2,
					GuestLimit = 5,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p38.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p38.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p38);
				propNum++;

				Property p39 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "28062",
					State = "SC",
					PropertyAddress = "8518 Pamela Track Apt. 164",
					City = "Aprilshire",
					WeekendPrice = 210.59m,
					WeekdayPrice = 199.37m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 8.83m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 2,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p39.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p39.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p39);
				propNum++;

				Property p40 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "88090",
					State = "OH",
					PropertyAddress = "864 Ramos Port Apt. 211",
					City = "Moralesmouth",
					WeekendPrice = 153.69m,
					WeekdayPrice = 94.48m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 16.85m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 5,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p40.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p40.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p40);
				propNum++;

				Property p41 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "28775",
					State = "RI",
					PropertyAddress = "637 Neal Island Suite 074",
					City = "Lake Tyler",
					WeekendPrice = 196.14m,
					WeekdayPrice = 88.82m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 6.97m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 3,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p41.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p41.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p41);
				propNum++;

				Property p42 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "75585",
					State = "WV",
					PropertyAddress = "0811 Smith Canyon Apt. 904",
					City = "Jessicabury",
					WeekendPrice = 123.22m,
					WeekdayPrice = 119.58m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 18.45m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 5,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p42.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p42.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p42);
				propNum++;

				Property p43 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "17438",
					State = "MD",
					PropertyAddress = "7562 Fisher Spur",
					City = "Hernandezberg",
					WeekendPrice = 283.77m,
					WeekdayPrice = 218.87m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 19.07m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p43.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p43.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p43);
				propNum++;

				Property p44 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "07027",
					State = "VT",
					PropertyAddress = "5667 Blair Underpass",
					City = "South Shelby",
					WeekendPrice = 239.76m,
					WeekdayPrice = 76.19m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 11.37m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 4,
					GuestLimit = 13,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p44.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p44.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p44);
				propNum++;

				Property p45 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "01008",
					State = "MI",
					PropertyAddress = "6708 Carpenter Overpass Suite 735",
					City = "Bobbyton",
					WeekendPrice = 229.04m,
					WeekdayPrice = 161.17m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 25.01m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 7,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p45.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p45.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p45);
				propNum++;

				Property p46 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "60236",
					State = "ND",
					PropertyAddress = "16396 Shawn Junction",
					City = "New Nicolemouth",
					WeekendPrice = 220.69m,
					WeekdayPrice = 106.06m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 11.82m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 4,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p46.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p46.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p46);
				propNum++;

				Property p47 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "01707",
					State = "CA",
					PropertyAddress = "4486 Olson Well",
					City = "North Kevin",
					WeekendPrice = 138.96m,
					WeekdayPrice = 151.44m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 6.72m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 7,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p47.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p47.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p47);
				propNum++;

				Property p48 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "33233",
					State = "HI",
					PropertyAddress = "67771 Christopher Courts Apt. 637",
					City = "Port Ronaldfurt",
					WeekendPrice = 134.28m,
					WeekdayPrice = 102.43m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 19.81m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 5,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p48.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p48.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p48);
				propNum++;

				Property p49 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "79756",
					State = "NY",
					PropertyAddress = "5561 Bishop Turnpike",
					City = "Lake Kenneth",
					WeekendPrice = 259.87m,
					WeekdayPrice = 94.31m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 22.33m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p49.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p49.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p49);
				propNum++;

				Property p50 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "36216",
					State = "SD",
					PropertyAddress = "3019 Gerald Mall Apt. 340",
					City = "Trevinoville",
					WeekendPrice = 263.32m,
					WeekdayPrice = 151.69m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 13.27m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 5,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p50.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p50.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p50);
				propNum++;

				Property p51 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "43477",
					State = "NY",
					PropertyAddress = "84331 Leonard Fort Suite 749",
					City = "East Lisa",
					WeekendPrice = 204.28m,
					WeekdayPrice = 204.04m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 11.07m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 8,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p51.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p51.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p51);
				propNum++;

				Property p52 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "17819",
					State = "VA",
					PropertyAddress = "62281 Kathy Tunnel",
					City = "Hudsonborough",
					WeekendPrice = 224.19m,
					WeekdayPrice = 165.51m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 24.26m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 1,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p52.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p52.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p52);
				propNum++;

				Property p53 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "97149",
					State = "NM",
					PropertyAddress = "9927 Christina Burg Suite 774",
					City = "East Angelaburgh",
					WeekendPrice = 121.74m,
					WeekdayPrice = 106.87m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 5.62m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 9,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p53.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p53.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p53);
				propNum++;

				Property p54 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "45480",
					State = "IA",
					PropertyAddress = "142 Warner View Suite 460",
					City = "North Leslie",
					WeekendPrice = 148.76m,
					WeekdayPrice = 212.32m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 20.2m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p54.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p54.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p54);
				propNum++;

				Property p55 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "03720",
					State = "AR",
					PropertyAddress = "5240 Berry Centers",
					City = "West Andrew",
					WeekendPrice = 111.01m,
					WeekdayPrice = 164.02m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 26.21m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 6,
					GuestLimit = 12,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p55.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p55.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p55);
				propNum++;

				Property p56 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "85576",
					State = "HI",
					PropertyAddress = "51056 Patricia Forge",
					City = "Grahamstad",
					WeekendPrice = 167.53m,
					WeekdayPrice = 117.45m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 24.75m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 9,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p56.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p56.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p56);
				propNum++;

				Property p57 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "92199",
					State = "VA",
					PropertyAddress = "0648 Malone Port Apt. 662",
					City = "New Devonhaven",
					WeekendPrice = 176.53m,
					WeekdayPrice = 209.47m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 5.83m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 5,
					GuestLimit = 12,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p57.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p57.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p57);
				propNum++;

				Property p58 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "05261",
					State = "SC",
					PropertyAddress = "23028 Jennifer Meadow Apt. 972",
					City = "West Matthewfurt",
					WeekendPrice = 199.1m,
					WeekdayPrice = 153.04m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 18.62m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p58.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p58.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p58);
				propNum++;

				Property p59 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "72649",
					State = "LA",
					PropertyAddress = "2738 Martin Terrace Suite 547",
					City = "Smithhaven",
					WeekendPrice = 199.22m,
					WeekdayPrice = 196.56m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 20.71m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 1,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p59.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p59.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p59);
				propNum++;

				Property p60 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "97488",
					State = "KY",
					PropertyAddress = "984 Stephen Stravenue",
					City = "South Michaelton",
					WeekendPrice = 178.29m,
					WeekdayPrice = 117.03m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 6.47m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 6,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p60.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p60.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p60);
				propNum++;

				Property p61 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "42837",
					State = "LA",
					PropertyAddress = "98522 Mathis Viaduct Apt. 909",
					City = "West Michael",
					WeekendPrice = 252.79m,
					WeekdayPrice = 133.35m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 9.15m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 4,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p61.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p61.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p61);
				propNum++;

				Property p62 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "56059",
					State = "OH",
					PropertyAddress = "620 Ashley Mills Apt. 507",
					City = "Julieborough",
					WeekendPrice = 296.05m,
					WeekdayPrice = 171.15m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 18.26m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p62.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p62.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p62);
				propNum++;

				Property p63 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "02288",
					State = "LA",
					PropertyAddress = "212 Shelly Roads",
					City = "Fischerview",
					WeekendPrice = 163.88m,
					WeekdayPrice = 132.81m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 7.46m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p63.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p63.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p63);
				propNum++;

				Property p64 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "50851",
					State = "OK",
					PropertyAddress = "8885 Lee Tunnel Suite 208",
					City = "Port Donna",
					WeekendPrice = 140.73m,
					WeekdayPrice = 228.84m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 17.13m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 7,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p64.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p64.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p64);
				propNum++;

				Property p65 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "03009",
					State = "NM",
					PropertyAddress = "693 Michael Estate",
					City = "Lake Michael",
					WeekendPrice = 139.83m,
					WeekdayPrice = 155.03m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 21.05m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 5,
					GuestLimit = 13,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p65.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p65.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p65);
				propNum++;

				Property p66 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "92905",
					State = "NY",
					PropertyAddress = "342 Miller Mission",
					City = "Lake Jennifer",
					WeekendPrice = 249.24m,
					WeekdayPrice = 128.41m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 6.63m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 5,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p66.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p66.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p66);
				propNum++;

				Property p67 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "65056",
					State = "AK",
					PropertyAddress = "71664 Kim Throughway",
					City = "Chelsealand",
					WeekendPrice = 286.53m,
					WeekdayPrice = 163.68m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 25.57m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 8,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p67.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p67.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p67);
				propNum++;

				Property p68 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "11181",
					State = "AZ",
					PropertyAddress = "66660 Gomez Port Apt. 945",
					City = "South Thomashaven",
					WeekendPrice = 137.17m,
					WeekdayPrice = 93.86m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 28.18m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 3,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p68.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p68.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p68);
				propNum++;

				Property p69 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "53480",
					State = "FL",
					PropertyAddress = "0131 Williams Ville Apt. 562",
					City = "Richardberg",
					WeekendPrice = 120.61m,
					WeekdayPrice = 86.25m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 11.39m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 5,
					GuestLimit = 13,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p69.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p69.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p69);
				propNum++;

				Property p70 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "11353",
					State = "OR",
					PropertyAddress = "22708 Madison Spurs",
					City = "Herringstad",
					WeekendPrice = 241.25m,
					WeekdayPrice = 182.46m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 18.29m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 7,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p70.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p70.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p70);
				propNum++;

				Property p71 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "05560",
					State = "FL",
					PropertyAddress = "3454 Holmes Motorway",
					City = "Port Rachel",
					WeekendPrice = 123.04m,
					WeekdayPrice = 89.88m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 19.14m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 3,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p71.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p71.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p71);
				propNum++;

				Property p72 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "93500",
					State = "GA",
					PropertyAddress = "805 James Turnpike",
					City = "Carrmouth",
					WeekendPrice = 219.86m,
					WeekdayPrice = 81.55m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 13.38m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 5,
					GuestLimit = 12,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p72.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p72.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p72);
				propNum++;

				Property p73 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "44515",
					State = "NV",
					PropertyAddress = "8081 Smith Trail",
					City = "North Ronaldstad",
					WeekendPrice = 196.09m,
					WeekdayPrice = 130.47m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 14.53m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 7,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p73.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p73.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p73);
				propNum++;

				Property p74 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "07347",
					State = "MS",
					PropertyAddress = "125 Ian Crossroad Apt. 593",
					City = "South Deannaport",
					WeekendPrice = 136.82m,
					WeekdayPrice = 148.1m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 15.57m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 1,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p74.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p74.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p74);
				propNum++;

				Property p75 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "54532",
					State = "NH",
					PropertyAddress = "1607 Munoz River",
					City = "Emilyshire",
					WeekendPrice = 209.77m,
					WeekdayPrice = 147.55m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 27.65m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 7,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p75.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p75.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p75);
				propNum++;

				Property p76 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "65516",
					State = "UT",
					PropertyAddress = "3615 David Keys Apt. 269",
					City = "West Stephenside",
					WeekendPrice = 126.47m,
					WeekdayPrice = 86.8m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 17.6m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 4,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p76.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p76.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p76);
				propNum++;

				Property p77 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "20721",
					State = "AZ",
					PropertyAddress = "640 Mary Common",
					City = "Michaelville",
					WeekendPrice = 173.01m,
					WeekdayPrice = 121.75m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 12.53m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 4,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p77.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p77.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p77);
				propNum++;

				Property p78 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "43567",
					State = "LA",
					PropertyAddress = "395 Timothy Road",
					City = "Williamsbury",
					WeekendPrice = 198.1m,
					WeekdayPrice = 160.23m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 10.82m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 5,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p78.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p78.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p78);
				propNum++;

				Property p79 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "01239",
					State = "OR",
					PropertyAddress = "3267 Walter Dam",
					City = "Cunninghamtown",
					WeekendPrice = 127.7m,
					WeekdayPrice = 110.64m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 26.67m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p79.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p79.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p79);
				propNum++;

				Property p80 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "03966",
					State = "MS",
					PropertyAddress = "00580 Brandon Creek",
					City = "Port Eric",
					WeekendPrice = 236.71m,
					WeekdayPrice = 227.6m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 20.22m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 5,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p80.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p80.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p80);
				propNum++;

				Property p81 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "29996",
					State = "MS",
					PropertyAddress = "325 Amanda Cliffs Apt. 695",
					City = "South Paulabury",
					WeekendPrice = 135.59m,
					WeekdayPrice = 115.37m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 29.8m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 6,
					GuestLimit = 13,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p81.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p81.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p81);
				propNum++;

				Property p82 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "93980",
					State = "CT",
					PropertyAddress = "40956 Amanda Walk Apt. 260",
					City = "Simonfurt",
					WeekendPrice = 271.49m,
					WeekdayPrice = 93.35m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 8.54m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 4,
					GuestLimit = 5,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p82.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p82.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p82);
				propNum++;

				Property p83 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "23687",
					State = "KS",
					PropertyAddress = "25762 Gill Creek Suite 525",
					City = "Mccoyton",
					WeekendPrice = 247.15m,
					WeekdayPrice = 171.37m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 17.22m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 5,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p83.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p83.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p83);
				propNum++;

				Property p84 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "04593",
					State = "GA",
					PropertyAddress = "6048 Johnson Loop Suite 635",
					City = "East Daniel",
					WeekendPrice = 299.6m,
					WeekdayPrice = 95.59m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 24.3m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 8,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p84.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p84.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p84);
				propNum++;

				Property p85 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "96954",
					State = "RI",
					PropertyAddress = "1168 Gary Fords Apt. 308",
					City = "Port Trevor",
					WeekendPrice = 278.17m,
					WeekdayPrice = 194.84m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 5.88m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p85.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p85.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p85);
				propNum++;

				Property p86 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "62271",
					State = "MS",
					PropertyAddress = "164 Matthew Parkway Suite 826",
					City = "Jimmyfurt",
					WeekendPrice = 100.08m,
					WeekdayPrice = 112.03m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 28.82m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 8,
					GuestLimit = 8,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p86.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p86.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p86);
				propNum++;

				Property p87 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "05222",
					State = "CO",
					PropertyAddress = "1220 Heidi Rue Apt. 998",
					City = "West Haleyburgh",
					WeekendPrice = 182.77m,
					WeekdayPrice = 127.97m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 13.02m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 4,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p87.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p87.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p87);
				propNum++;

				Property p88 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "22365",
					State = "SD",
					PropertyAddress = "751 Wood Square Suite 732",
					City = "Port Melissaburgh",
					WeekendPrice = 186.01m,
					WeekdayPrice = 120.07m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 26.71m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 7,
					GuestLimit = 13,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p88.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p88.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p88);
				propNum++;

				Property p89 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "53609",
					State = "OR",
					PropertyAddress = "376 Smith Dale Suite 279",
					City = "South Sarahland",
					WeekendPrice = 122.31m,
					WeekdayPrice = 137.96m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 26.29m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 2,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p89.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p89.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p89);
				propNum++;

				Property p90 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "09478",
					State = "CA",
					PropertyAddress = "79148 Pierce Lock Suite 423",
					City = "Erikberg",
					WeekendPrice = 234.61m,
					WeekdayPrice = 226.57m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 16.41m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 5,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p90.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p90.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p90);
				propNum++;

				Property p91 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "01425",
					State = "ID",
					PropertyAddress = "147 Lisa Hill Apt. 512",
					City = "Port Elizabethshire",
					WeekendPrice = 145.15m,
					WeekdayPrice = 95.73m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 9.93m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 6,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p91.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p91.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p91);
				propNum++;

				Property p92 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "29941",
					State = "KY",
					PropertyAddress = "971 Hansen Well Suite 103",
					City = "South Mary",
					WeekendPrice = 145.72m,
					WeekdayPrice = 161.68m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 24.36m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 8,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p92.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p92.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p92);
				propNum++;

				Property p93 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "47577",
					State = "WY",
					PropertyAddress = "511 Berry Fork Suite 623",
					City = "Sharonfort",
					WeekendPrice = 260.18m,
					WeekdayPrice = 183.81m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 7.46m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 5,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p93.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p93.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p93);
				propNum++;

				Property p94 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "94134",
					State = "WI",
					PropertyAddress = "65873 Chen Knolls",
					City = "Ramirezfurt",
					WeekendPrice = 117.17m,
					WeekdayPrice = 215.38m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 24.31m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 3,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p94.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p94.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p94);
				propNum++;

				Property p95 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "57039",
					State = "IN",
					PropertyAddress = "8799 Emma Parkway Suite 735",
					City = "North Thomasfurt",
					WeekendPrice = 242.21m,
					WeekdayPrice = 145.51m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 11.89m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 5,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p95.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p95.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p95);
				propNum++;

				Property p96 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "23718",
					State = "ND",
					PropertyAddress = "30068 David View Apt. 173",
					City = "New Peggychester",
					WeekendPrice = 161.21m,
					WeekdayPrice = 142.76m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 20.92m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 6,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p96.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p96.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p96);
				propNum++;

				Property p97 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "26932",
					State = "MD",
					PropertyAddress = "298 Johnathan Cove Apt. 402",
					City = "South Jamie",
					WeekendPrice = 176.37m,
					WeekdayPrice = 170.07m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 8.54m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 7,
					GuestLimit = 13,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p97.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p97.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p97);
				propNum++;

				Property p98 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "74554",
					State = "CO",
					PropertyAddress = "171 Harrison Motorway",
					City = "Davidview",
					WeekendPrice = 234.81m,
					WeekdayPrice = 145.08m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 26.14m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 8,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p98.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p98.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p98);
				propNum++;

				Property p99 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "32097",
					State = "NE",
					PropertyAddress = "3576 Sergio Avenue",
					City = "Benjaminmouth",
					WeekendPrice = 260.62m,
					WeekdayPrice = 111.73m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 15.89m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 1,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p99.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p99.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p99);
				propNum++;

				Property p100 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "21519",
					State = "RI",
					PropertyAddress = "37457 Tanya Pike Apt. 348",
					City = "North Ericton",
					WeekendPrice = 214.62m,
					WeekdayPrice = 70.63m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 5.29m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 1,
					GuestLimit = 13,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p100.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p100.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p100);
				propNum++;

				Property p101 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "76875",
					State = "PA",
					PropertyAddress = "3673 Peter Turnpike Suite 835",
					City = "New Sandra",
					WeekendPrice = 172.79m,
					WeekdayPrice = 229.03m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 14.05m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 4,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p101.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p101.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p101);
				propNum++;

				Property p102 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "80451",
					State = "TX",
					PropertyAddress = "939 Johnson Oval Suite 830",
					City = "North Dennismouth",
					WeekendPrice = 133.53m,
					WeekdayPrice = 169.34m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 18.06m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 5,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p102.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p102.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p102);
				propNum++;

				Property p103 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "51726",
					State = "NV",
					PropertyAddress = "645 Jennings Estates",
					City = "Angelastad",
					WeekendPrice = 109.44m,
					WeekdayPrice = 155.52m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 8.28m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 3,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p103.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p103.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p103);
				propNum++;

				Property p104 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "77240",
					State = "MT",
					PropertyAddress = "1231 Stephanie Lock Suite 835",
					City = "North Richardland",
					WeekendPrice = 182.33m,
					WeekdayPrice = 180.2m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 17.78m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 5,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p104.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p104.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p104);
				propNum++;

				Property p105 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "98152",
					State = "CO",
					PropertyAddress = "302 Parker Plains Apt. 197",
					City = "East Robertstad",
					WeekendPrice = 212.7m,
					WeekdayPrice = 212.86m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 6.82m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 2,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p105.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p105.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p105);
				propNum++;

				Property p106 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "98277",
					State = "MS",
					PropertyAddress = "098 Hernandez Green",
					City = "New Sergiobury",
					WeekendPrice = 262.3m,
					WeekdayPrice = 188.71m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 21.88m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 6,
					GuestLimit = 8,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p106.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p106.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p106);
				propNum++;

				Property p107 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "80082",
					State = "NE",
					PropertyAddress = "94102 Sims Port Suite 187",
					City = "Florestown",
					WeekendPrice = 128.05m,
					WeekdayPrice = 83.34m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 11.29m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 4,
					GuestLimit = 8,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p107.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p107.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p107);
				propNum++;

				Property p108 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "71531",
					State = "ND",
					PropertyAddress = "01630 Baker Crescent",
					City = "Kellyborough",
					WeekendPrice = 125.27m,
					WeekdayPrice = 204.02m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 21.15m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 1,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p108.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p108.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p108);
				propNum++;

				Property p109 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "14157",
					State = "OK",
					PropertyAddress = "70452 Forbes Courts",
					City = "Mosesland",
					WeekendPrice = 172.1m,
					WeekdayPrice = 90.98m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 18.09m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 3,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p109.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p109.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p109);
				propNum++;

				Property p110 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "26899",
					State = "MO",
					PropertyAddress = "0835 Angela Station",
					City = "East Heather",
					WeekendPrice = 299.91m,
					WeekdayPrice = 158.64m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 23.09m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p110.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p110.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p110);
				propNum++;

				Property p111 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "42872",
					State = "VT",
					PropertyAddress = "2458 Jason Village Suite 248",
					City = "North Donnamouth",
					WeekendPrice = 189.3m,
					WeekdayPrice = 107.97m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 9.05m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 4,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p111.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p111.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p111);
				propNum++;

				Property p112 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "78301",
					State = "CO",
					PropertyAddress = "1243 Grimes Corners",
					City = "Shawchester",
					WeekendPrice = 193.24m,
					WeekdayPrice = 214.14m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 26.1m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 3,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p112.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p112.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p112);
				propNum++;

				Property p113 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "34523",
					State = "DC",
					PropertyAddress = "558 Williams Station",
					City = "Port Pamela",
					WeekendPrice = 192.46m,
					WeekdayPrice = 106.3m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 17.59m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 7,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p113.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p113.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p113);
				propNum++;

				Property p114 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "63064",
					State = "VT",
					PropertyAddress = "4934 Lozano Place Suite 716",
					City = "Gavinton",
					WeekendPrice = 257.37m,
					WeekdayPrice = 116.99m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 5.63m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 6,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p114.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p114.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p114);
				propNum++;

				Property p115 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "35700",
					State = "LA",
					PropertyAddress = "41227 Patricia Lake",
					City = "Martinezbury",
					WeekendPrice = 108.28m,
					WeekdayPrice = 203.03m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 11.35m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 1,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p115.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p115.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p115);
				propNum++;

				Property p116 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "55206",
					State = "VA",
					PropertyAddress = "028 Harris Drive Apt. 422",
					City = "Amyburgh",
					WeekendPrice = 262.77m,
					WeekdayPrice = 163.3m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 13.74m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 2,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p116.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p116.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p116);
				propNum++;

				Property p117 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "98240",
					State = "IA",
					PropertyAddress = "06268 Lewis Place Suite 121",
					City = "Port Patriciatown",
					WeekendPrice = 108.52m,
					WeekdayPrice = 156.25m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 23.66m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 2,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p117.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p117.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p117);
				propNum++;

				Property p118 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "87205",
					State = "WI",
					PropertyAddress = "5641 Brenda Streets Apt. 008",
					City = "Lake Seanmouth",
					WeekendPrice = 153.42m,
					WeekdayPrice = 178.27m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 24.69m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 6,
					GuestLimit = 12,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p118.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p118.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p118);
				propNum++;

				Property p119 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "58221",
					State = "ME",
					PropertyAddress = "92555 Shaw Spurs Suite 207",
					City = "New Randy",
					WeekendPrice = 184.92m,
					WeekdayPrice = 92.51m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 12.82m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 8,
					GuestLimit = 13,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p119.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p119.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p119);
				propNum++;

				Property p120 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "18885",
					State = "NY",
					PropertyAddress = "559 Foster Locks Suite 933",
					City = "Robinsonhaven",
					WeekendPrice = 225.85m,
					WeekdayPrice = 224.62m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 17.9m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 6,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p120.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p120.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p120);
				propNum++;

				Property p121 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "00638",
					State = "WY",
					PropertyAddress = "4647 Kristine Fields Suite 710",
					City = "New Dakota",
					WeekendPrice = 174.02m,
					WeekdayPrice = 112.61m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 17.48m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p121.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p121.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p121);
				propNum++;

				Property p122 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "31451",
					State = "ME",
					PropertyAddress = "92594 Emily Shoals",
					City = "North Cathyburgh",
					WeekendPrice = 119.06m,
					WeekdayPrice = 189.98m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 25.11m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 5,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p122.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p122.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p122);
				propNum++;

				Property p123 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "26297",
					State = "MS",
					PropertyAddress = "551 Casey Squares Apt. 209",
					City = "Michaelborough",
					WeekendPrice = 114.73m,
					WeekdayPrice = 72.03m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 18.38m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 1,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p123.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p123.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p123);
				propNum++;

				Property p124 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "04610",
					State = "PA",
					PropertyAddress = "2998 Willis Wall",
					City = "North Brian",
					WeekendPrice = 144.51m,
					WeekdayPrice = 216.21m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 10.81m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 4,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p124.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p124.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p124);
				propNum++;

				Property p125 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "86618",
					State = "MD",
					PropertyAddress = "164 Schultz Road",
					City = "Lake Bryan",
					WeekendPrice = 233.9m,
					WeekdayPrice = 132.69m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 15.8m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 13,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p125.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p125.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p125);
				propNum++;

				Property p126 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "80124",
					State = "GA",
					PropertyAddress = "9541 Brock Estate Apt. 848",
					City = "Franklinchester",
					WeekendPrice = 285.05m,
					WeekdayPrice = 220.97m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 20.98m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 1,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p126.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p126.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p126);
				propNum++;

				Property p127 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "63590",
					State = "MS",
					PropertyAddress = "588 Alan Rest",
					City = "Port Stephanieville",
					WeekendPrice = 180.86m,
					WeekdayPrice = 224.98m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 11.91m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 6,
					GuestLimit = 12,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p127.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p127.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p127);
				propNum++;

				Property p128 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "53548",
					State = "MT",
					PropertyAddress = "216 Brandon Loop Apt. 096",
					City = "New Jessica",
					WeekendPrice = 239.97m,
					WeekdayPrice = 221.98m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 9.24m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 12,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p128.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p128.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p128);
				propNum++;

				Property p129 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "35611",
					State = "LA",
					PropertyAddress = "782 Dawn Radial",
					City = "Port Christopher",
					WeekendPrice = 297.25m,
					WeekdayPrice = 76.56m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 20.42m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p129.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p129.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p129);
				propNum++;

				Property p130 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "42879",
					State = "WA",
					PropertyAddress = "008 Nancy Route Suite 228",
					City = "North Stephanie",
					WeekendPrice = 129.36m,
					WeekdayPrice = 128.71m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 23.76m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 3,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p130.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p130.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p130);
				propNum++;

				Property p131 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "71569",
					State = "MO",
					PropertyAddress = "115 Jon Isle Suite 788",
					City = "North Lesliefurt",
					WeekendPrice = 210.63m,
					WeekdayPrice = 114.21m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 21.08m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p131.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p131.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p131);
				propNum++;

				Property p132 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "87566",
					State = "DE",
					PropertyAddress = "132 Poole Pass Suite 212",
					City = "North Patrick",
					WeekendPrice = 280.37m,
					WeekdayPrice = 146.82m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 26.78m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 6,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p132.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p132.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p132);
				propNum++;

				Property p133 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "67652",
					State = "WY",
					PropertyAddress = "457 Vargas Island Suite 853",
					City = "Lake Patrickstad",
					WeekendPrice = 249.39m,
					WeekdayPrice = 134.72m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 19.19m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 3,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p133.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p133.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p133);
				propNum++;

				Property p134 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "45184",
					State = "HI",
					PropertyAddress = "1569 Amy Path",
					City = "North Ashleyton",
					WeekendPrice = 111.23m,
					WeekdayPrice = 111.6m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 13.48m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 8,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p134.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p134.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p134);
				propNum++;

				Property p135 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "04078",
					State = "IL",
					PropertyAddress = "0375 Sandra Trace Suite 826",
					City = "Gailshire",
					WeekendPrice = 168.47m,
					WeekdayPrice = 89m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 14.93m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 6,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p135.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p135.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p135);
				propNum++;

				Property p136 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "50437",
					State = "MN",
					PropertyAddress = "759 Good Port",
					City = "New Russell",
					WeekendPrice = 208.35m,
					WeekdayPrice = 208.64m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 7.09m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 5,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p136.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p136.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p136);
				propNum++;

				Property p137 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "34147",
					State = "WV",
					PropertyAddress = "3895 Allen Junction",
					City = "West John",
					WeekendPrice = 195.41m,
					WeekdayPrice = 172.51m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 21.53m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p137.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p137.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p137);
				propNum++;

				Property p138 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "36340",
					State = "MS",
					PropertyAddress = "7329 Jacobs Station",
					City = "New Tylerborough",
					WeekendPrice = 146.12m,
					WeekdayPrice = 163.15m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 18.98m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 8,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p138.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p138.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p138);
				propNum++;

				Property p139 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "88806",
					State = "MD",
					PropertyAddress = "5003 Cassandra Estates Suite 148",
					City = "Haleychester",
					WeekendPrice = 161.49m,
					WeekdayPrice = 81.5m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 16.41m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 7,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p139.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p139.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p139);
				propNum++;

				Property p140 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "76853",
					State = "TN",
					PropertyAddress = "10524 Parker Mall Suite 531",
					City = "Port Courtneyhaven",
					WeekendPrice = 120.73m,
					WeekdayPrice = 177.94m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 9.5m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 7,
					GuestLimit = 13,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p140.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Hotel");
				p140.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p140);
				propNum++;

				Property p141 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "93533",
					State = "MO",
					PropertyAddress = "300 Madison Stream",
					City = "Christophershire",
					WeekendPrice = 187.08m,
					WeekdayPrice = 121.01m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 16.48m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 4,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p141.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p141.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p141);
				propNum++;

				Property p142 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "96763",
					State = "FL",
					PropertyAddress = "4229 Derrick Wells",
					City = "West Tyler",
					WeekendPrice = 241.45m,
					WeekdayPrice = 199.68m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 25.94m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 4,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p142.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p142.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p142);
				propNum++;

				Property p143 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "92174",
					State = "VA",
					PropertyAddress = "26239 Michael Shoals",
					City = "Gregoryview",
					WeekendPrice = 111.91m,
					WeekdayPrice = 162.01m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 14.35m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p143.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p143.User = context.Users.FirstOrDefault(u => u.Email == "morales@aol.com");
				Properties.Add(p143);
				propNum++;

				Property p144 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "88294",
					State = "IN",
					PropertyAddress = "302 Joy Spring Apt. 622",
					City = "Ryanhaven",
					WeekendPrice = 163.73m,
					WeekdayPrice = 173.36m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 25.35m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 12,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p144.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p144.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p144);
				propNum++;

				Property p145 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "23464",
					State = "CA",
					PropertyAddress = "734 Craig Overpass Suite 589",
					City = "Jefferyside",
					WeekendPrice = 287.28m,
					WeekdayPrice = 216.1m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 22.2m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 8,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p145.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p145.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p145);
				propNum++;

				Property p146 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "35243",
					State = "CA",
					PropertyAddress = "272 Green Street",
					City = "Port Lacey",
					WeekendPrice = 247.34m,
					WeekdayPrice = 211.51m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 11.73m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 3,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p146.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p146.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p146);
				propNum++;

				Property p147 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "61935",
					State = "IL",
					PropertyAddress = "8056 Dunn Trail Apt. 049",
					City = "Blackshire",
					WeekendPrice = 189.08m,
					WeekdayPrice = 111.4m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 19.58m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 6,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p147.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p147.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p147);
				propNum++;

				Property p148 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "72324",
					State = "CA",
					PropertyAddress = "86187 Antonio Fort",
					City = "North Carmen",
					WeekendPrice = 109.87m,
					WeekdayPrice = 150.69m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 13.3m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 9,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p148.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p148.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p148);
				propNum++;

				Property p149 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "84393",
					State = "NJ",
					PropertyAddress = "71318 Cassandra Plaza",
					City = "Burkeview",
					WeekendPrice = 227.55m,
					WeekdayPrice = 184.21m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 19.52m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 7,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p149.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p149.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p149);
				propNum++;

				Property p150 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "62346",
					State = "NH",
					PropertyAddress = "5303 Lewis Springs",
					City = "Port Adrian",
					WeekendPrice = 207.51m,
					WeekdayPrice = 204.67m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 26.36m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 1,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p150.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p150.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p150);
				propNum++;

				Property p151 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "02837",
					State = "IA",
					PropertyAddress = "465 Wiley Corners Apt. 759",
					City = "East Michellechester",
					WeekendPrice = 213.84m,
					WeekdayPrice = 129.14m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 12.81m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 5,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p151.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p151.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p151);
				propNum++;

				Property p152 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "68847",
					State = "LA",
					PropertyAddress = "521 Flores Stream",
					City = "West Rebeccaborough",
					WeekendPrice = 254.37m,
					WeekdayPrice = 77.06m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 6.03m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 5,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p152.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p152.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p152);
				propNum++;

				Property p153 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "35218",
					State = "NE",
					PropertyAddress = "0271 Soto Drives Apt. 975",
					City = "New Edgar",
					WeekendPrice = 233.17m,
					WeekdayPrice = 179.91m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 11.04m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 5,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p153.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p153.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p153);
				propNum++;

				Property p154 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "32697",
					State = "NM",
					PropertyAddress = "27862 Kent Mountains",
					City = "Lake Michaelville",
					WeekendPrice = 153.38m,
					WeekdayPrice = 90.54m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 6.91m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 5,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p154.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p154.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p154);
				propNum++;

				Property p155 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "95889",
					State = "OR",
					PropertyAddress = "917 Mclaughlin Glens",
					City = "Martinville",
					WeekendPrice = 226.89m,
					WeekdayPrice = 225.59m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 28.99m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 6,
					GuestLimit = 2,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p155.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p155.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p155);
				propNum++;

				Property p156 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "82153",
					State = "KY",
					PropertyAddress = "3032 Michelle Drives",
					City = "North Daniel",
					WeekendPrice = 157.15m,
					WeekdayPrice = 203.25m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 15.68m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 4,
					GuestLimit = 13,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p156.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p156.User = context.Users.FirstOrDefault(u => u.Email == "rankin@yahoo.com");
				Properties.Add(p156);
				propNum++;

				Property p157 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "32202",
					State = "SD",
					PropertyAddress = "601 Maria Mission Apt. 554",
					City = "Myerstown",
					WeekendPrice = 269.55m,
					WeekdayPrice = 223.27m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 11.35m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 9,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p157.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p157.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p157);
				propNum++;

				Property p158 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "17431",
					State = "OH",
					PropertyAddress = "238 Shawn Well",
					City = "Port Johnshire",
					WeekendPrice = 112.64m,
					WeekdayPrice = 173.63m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 6.38m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 8,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p158.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p158.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p158);
				propNum++;

				Property p159 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "37901",
					State = "SC",
					PropertyAddress = "41743 Berger Inlet Apt. 527",
					City = "South Tammymouth",
					WeekendPrice = 163.2m,
					WeekdayPrice = 176.23m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 14.77m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 9,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p159.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p159.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p159);
				propNum++;

				Property p160 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "17895",
					State = "MO",
					PropertyAddress = "9983 Mary Grove Apt. 643",
					City = "Beardview",
					WeekendPrice = 209.33m,
					WeekdayPrice = 219.53m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 24.51m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 6,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p160.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p160.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p160);
				propNum++;

				Property p161 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "90576",
					State = "HI",
					PropertyAddress = "03541 Ryan Islands Apt. 562",
					City = "East Michaelfort",
					WeekendPrice = 269.63m,
					WeekdayPrice = 126.25m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 8.27m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p161.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p161.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p161);
				propNum++;

				Property p162 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "94980",
					State = "SC",
					PropertyAddress = "6591 Angela Mission Apt. 108",
					City = "Penabury",
					WeekendPrice = 286.86m,
					WeekdayPrice = 143.98m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 20.48m,
					NumberOfBedrooms = 5,
					NumberOfBathrooms = 6,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p162.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p162.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p162);
				propNum++;

				Property p163 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "44974",
					State = "CO",
					PropertyAddress = "492 Ramirez Crossing",
					City = "Aaronberg",
					WeekendPrice = 144.6m,
					WeekdayPrice = 121.91m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = true,
					CleaningFee = 10.12m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p163.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p163.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p163);
				propNum++;

				Property p164 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "66170",
					State = "DE",
					PropertyAddress = "35974 Sharon Locks Apt. 101",
					City = "Jennyport",
					WeekendPrice = 114.46m,
					WeekdayPrice = 137.8m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 17.74m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 9,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p164.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p164.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p164);
				propNum++;

				Property p165 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "22495",
					State = "UT",
					PropertyAddress = "89403 Gabriella Mills",
					City = "East Steven",
					WeekendPrice = 155.1m,
					WeekdayPrice = 128.63m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 23.05m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 4,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p165.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p165.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p165);
				propNum++;

				Property p166 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "85059",
					State = "NH",
					PropertyAddress = "601 Kyle Roads",
					City = "Clarkfurt",
					WeekendPrice = 284.39m,
					WeekdayPrice = 209.11m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 6.25m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 5,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p166.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p166.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p166);
				propNum++;

				Property p167 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "61092",
					State = "IN",
					PropertyAddress = "60969 Justin Passage Suite 774",
					City = "Joshuaburgh",
					WeekendPrice = 121m,
					WeekdayPrice = 128.59m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 19.36m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 1,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p167.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p167.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p167);
				propNum++;

				Property p168 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "43986",
					State = "PA",
					PropertyAddress = "7943 Tina Mount",
					City = "East Lisa",
					WeekendPrice = 104.47m,
					WeekdayPrice = 122.88m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 25.31m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 3,
					GuestLimit = 14,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p168.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p168.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p168);
				propNum++;

				Property p169 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "91397",
					State = "NC",
					PropertyAddress = "6775 James Ford",
					City = "South Victorialand",
					WeekendPrice = 275.5m,
					WeekdayPrice = 211.24m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 15.74m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 3,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p169.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p169.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p169);
				propNum++;

				Property p170 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "67849",
					State = "VT",
					PropertyAddress = "431 Johnson Neck Suite 039",
					City = "Mariechester",
					WeekendPrice = 126.24m,
					WeekdayPrice = 124.65m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 24.3m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 1,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p170.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p170.User = context.Users.FirstOrDefault(u => u.Email == "rice@yahoo.com");
				Properties.Add(p170);
				propNum++;

				Property p171 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "20687",
					State = "NM",
					PropertyAddress = "15666 Justin Locks",
					City = "Lake Ryanport",
					WeekendPrice = 112.05m,
					WeekdayPrice = 70.11m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 27.45m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 6,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p171.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p171.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p171);
				propNum++;

				Property p172 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "30222",
					State = "TX",
					PropertyAddress = "9947 Torres Viaduct Apt. 506",
					City = "Benjaminport",
					WeekendPrice = 152.09m,
					WeekdayPrice = 174.87m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 18.44m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 11,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p172.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Apartment");
				p172.User = context.Users.FirstOrDefault(u => u.Email == "ingram@gmail.com");
				Properties.Add(p172);
				propNum++;

				Property p173 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "21190",
					State = "NJ",
					PropertyAddress = "20866 Keith Mill",
					City = "Susanton",
					WeekendPrice = 174.06m,
					WeekdayPrice = 96.8m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 28.15m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 4,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p173.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p173.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p173);
				propNum++;

				Property p174 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "04838",
					State = "AL",
					PropertyAddress = "04374 Nicholas Cliff Suite 001",
					City = "Adrianport",
					WeekendPrice = 108.24m,
					WeekdayPrice = 205.01m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 6.56m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 1,
					GuestLimit = 10,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p174.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Condo");
				p174.User = context.Users.FirstOrDefault(u => u.Email == "jacobs@yahoo.com");
				Properties.Add(p174);
				propNum++;

				Property p175 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "80130",
					State = "CA",
					PropertyAddress = "271 Andrew Summit",
					City = "Port Craig",
					WeekendPrice = 148.39m,
					WeekdayPrice = 197.52m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 20.55m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 6,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p175.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p175.User = context.Users.FirstOrDefault(u => u.Email == "gonzalez@aol.com");
				Properties.Add(p175);
				propNum++;

				Property p176 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "96166",
					State = "MN",
					PropertyAddress = "17611 Robbins Mission",
					City = "New Curtis",
					WeekendPrice = 286.13m,
					WeekdayPrice = 219.69m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 10.64m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 3,
					GuestLimit = 9,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p176.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p176.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p176);
				propNum++;

				Property p177 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "40702",
					State = "MO",
					PropertyAddress = "80831 Kemp Pines",
					City = "Annashire",
					WeekendPrice = 123.93m,
					WeekdayPrice = 91.26m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 19.36m,
					NumberOfBedrooms = 1,
					NumberOfBathrooms = 2,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p177.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p177.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p177);
				propNum++;

				Property p178 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "86023",
					State = "IL",
					PropertyAddress = "96545 Smith Alley",
					City = "West Joy",
					WeekendPrice = 254.38m,
					WeekdayPrice = 132.54m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 14.83m,
					NumberOfBedrooms = 6,
					NumberOfBathrooms = 8,
					GuestLimit = 7,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p178.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p178.User = context.Users.FirstOrDefault(u => u.Email == "martinez@aol.com");
				Properties.Add(p178);
				propNum++;

				Property p179 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "70897",
					State = "MT",
					PropertyAddress = "6146 Johnson Isle",
					City = "South Arthur",
					WeekendPrice = 228.04m,
					WeekdayPrice = 227.96m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 6.99m,
					NumberOfBedrooms = 2,
					NumberOfBathrooms = 4,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p179.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p179.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p179);
				propNum++;

				Property p180 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "69154",
					State = "MN",
					PropertyAddress = "0415 Smith Springs",
					City = "Jeremyburgh",
					WeekendPrice = 228.81m,
					WeekdayPrice = 140.93m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 29.74m,
					NumberOfBedrooms = 4,
					NumberOfBathrooms = 4,
					GuestLimit = 3,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p180.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p180.User = context.Users.FirstOrDefault(u => u.Email == "loter@yahoo.com");
				Properties.Add(p180);
				propNum++;

				Property p181 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "53524",
					State = "HI",
					PropertyAddress = "3999 Ricky Via",
					City = "West Adamburgh",
					WeekendPrice = 255.43m,
					WeekdayPrice = 137.35m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = true,
					CleaningFee = 16.62m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 6,
					GuestLimit = 6,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p181.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "House");
				p181.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p181);
				propNum++;

				Property p182 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "24886",
					State = "MN",
					PropertyAddress = "83787 Stuart Key",
					City = "Davetown",
					WeekendPrice = 146.75m,
					WeekdayPrice = 172.99m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = true,
					FreeParking = false,
					CleaningFee = 26.24m,
					NumberOfBedrooms = 7,
					NumberOfBathrooms = 6,
					GuestLimit = 4,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p182.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p182.User = context.Users.FirstOrDefault(u => u.Email == "chung@yahoo.com");
				Properties.Add(p182);
				propNum++;

				Property p183 = new Property()
				{
					PropertyNumber = propNum,
					Zip = "56713",
					State = "TX",
					PropertyAddress = "690 Christina Park",
					City = "Toddburgh",
					WeekendPrice = 157.96m,
					WeekdayPrice = 188.53m,
					DiscountRate = 0m,
					DaysToDiscount = 0,
					PetsAllowed = false,
					FreeParking = false,
					CleaningFee = 6.69m,
					NumberOfBedrooms = 3,
					NumberOfBathrooms = 5,
					GuestLimit = 1,
					PropertyStatus = PropertyStatusEnum.Active
				};
				p183.Category = context.Categories.FirstOrDefault(c => c.CategoryName == "Cabin");
				p183.User = context.Users.FirstOrDefault(u => u.Email == "tanner@utexas.edu");
				Properties.Add(p183);
				propNum++;

				// help with errors
				try
				{
					foreach (Property propToAdd in Properties)
					{
						strProperty = propToAdd.PropertyAddress;
						Property dbProperty = context.Properties.FirstOrDefault(p => p.PropertyAddress == propToAdd.PropertyAddress);
						if (dbProperty == null) // This property does not exist
						{
							context.Properties.Add(propToAdd);
							context.SaveChanges();
							intPropsAdded++;
						}
						else
						{
							dbProperty.Zip = propToAdd.Zip;
							dbProperty.State = propToAdd.State;
							dbProperty.PropertyAddress = propToAdd.PropertyAddress;
							dbProperty.City = propToAdd.City;
							dbProperty.WeekendPrice = propToAdd.WeekendPrice;
							dbProperty.WeekdayPrice = propToAdd.WeekdayPrice;
							dbProperty.PetsAllowed = propToAdd.PetsAllowed;
							dbProperty.FreeParking = propToAdd.FreeParking;
							dbProperty.NumberOfBedrooms = propToAdd.NumberOfBedrooms;
							dbProperty.NumberOfBathrooms = propToAdd.NumberOfBathrooms;
							dbProperty.GuestLimit = propToAdd.GuestLimit;
							context.Update(dbProperty);
							context.SaveChanges();
							intPropsAdded++;
						}
					}
				}
				catch (Exception ex)
				{
					String msg = " Repositories added:" + intPropsAdded + "; Error on " + strProperty;
					throw new InvalidOperationException(ex.Message + msg);
				}
			}
			catch (Exception e)
			{
				throw new InvalidOperationException(e.Message);
			}
		}
	}
}
