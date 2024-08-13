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
	public static class SeedCategories
	{
		public static void SeedAllCategories(AppDbContext context)
		{
			//Create a counter and flag to know where problem is
			Int32 intCatsAdded = 0;
			String strCategory = "Begin";
			//Create a list from the Category model class
			List<Category> Categories = new List<Category>();

			try
			{
				Category c1 = new Category()
				{
					CategoryName = "House"
				};
				Categories.Add(c1);

				Category c2 = new Category()
				{
					CategoryName = "Cabin"
				};
				Categories.Add(c2);

				Category c3 = new Category()
				{
					CategoryName = "Apartment"
				};
				Categories.Add(c3);

				Category c4 = new Category()
				{
					CategoryName = "Condo"
				};
				Categories.Add(c4);

				Category c5 = new Category()
				{
					CategoryName = "Hotel"
				};
				Categories.Add(c5);

				foreach (Category catToAdd in Categories)
				{
					Category dbCategory = context.Categories.FirstOrDefault(c => c.CategoryName == catToAdd.CategoryName);
					if (dbCategory == null)
					{
						context.Categories.Add(catToAdd);
						context.SaveChanges();
						intCatsAdded++;
					}
				}
			}
			catch
			{
				String msg = "Categories added: " + intCatsAdded.ToString();
				throw new InvalidOperationException(msg);
			}
		}
	}
}
