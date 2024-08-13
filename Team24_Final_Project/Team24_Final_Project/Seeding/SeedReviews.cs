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
	public static class SeedReviews
	{
		public static void SeedAllReviews(AppDbContext context)
		{
			//Create a counter and flag to know where problem is
			Int32 intReviewsAdded = 0;
			//Create a list from the Category model class
			List<Review> Reviews = new List<Review>();

			try
			{
				Review r1 = new Review()
				{
					Rating = 4,
					CustomerComment = " "
                };
                r1.User = context.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com");
				r1.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "588 Alan Rest");
				Reviews.Add(r1);

				Review r2 = new Review()
				{
					Rating = 3,
					CustomerComment = "It was meh, ya know? It was really close to the coast, but the beaches were kinda trashed. The apartment was nice, but there wasn't an elevator."
				};
				r2.User = context.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");
				r2.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "1168 Gary Fords Apt. 308");
				Reviews.Add(r2);

				Review r3 = new Review()
				{
					Rating = 4,
					CustomerComment = ""
				};
				r3.User = context.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com");
				r3.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "03541 Ryan Islands Apt. 562");
				Reviews.Add(r3);

				Review r4 = new Review()
				{
					Rating = 2,
					CustomerComment = " "
				};
				r4.User = context.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com");
				r4.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "588 Alan Rest");
				Reviews.Add(r4);

				Review r5 = new Review()
				{
					Rating = 3,
					CustomerComment = "Nebraska was... interesting"
				};
				r5.User = context.Users.FirstOrDefault(u => u.Email == "father.Ingram@aool.com");
				r5.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "94102 Sims Port Suite 187");
				Reviews.Add(r5);

				Review r6 = new Review()
				{
					Rating = 1,
					CustomerComment = "There was corn EVERYWHERE! I looked left and BAM, CORN. Looked right, BAM, CORN"
				};
				r6.User = context.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com");
				r6.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "94102 Sims Port Suite 187");
				Reviews.Add(r6);

				Review r7 = new Review()
				{
					Rating = 1,
					CustomerComment = "Worst. Stay. Ever. Never using BevoBnB again"
				};
				r7.User = context.Users.FirstOrDefault(u => u.Email == "ra@aoo.com");
				r7.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "94102 Sims Port Suite 187");
				Reviews.Add(r7);

				Review r8 = new Review()
				{
					Rating = 5,
					CustomerComment = " "
				};
				r8.User = context.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");
				r8.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "693 Michael Estate");
				Reviews.Add(r8);

				Review r9 = new Review()
				{
					Rating = 2,
					CustomerComment = " "
				};
				r9.User = context.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");
				r9.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "457 Vargas Island Suite 853");
				Reviews.Add(r9);

				Review r10 = new Review()
				{
					Rating = 1,
					CustomerComment = "It was SO hard to book this place. Who coded this site anyway? ;)"
				};
				r10.User = context.Users.FirstOrDefault(u => u.Email == "tfreeley@puppy.com");
				r10.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "693 Michael Estate");
				Reviews.Add(r10);

				Review r11 = new Review()
				{
					Rating = 4,
					CustomerComment = " "
				};
				r11.User = context.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com");
				r11.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "71664 Kim Throughway");
				Reviews.Add(r11);

				Review r12 = new Review()
				{
					Rating = 5,
					CustomerComment = "This place rocked!"
				};
				r12.User = context.Users.FirstOrDefault(u => u.Email == "ra@aoo.com");
				r12.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "693 Michael Estate");
				Reviews.Add(r12);

				Review r13 = new Review()
				{
					Rating = 4,
					CustomerComment = " "
				};
				r13.User = context.Users.FirstOrDefault(u => u.Email == "fd@puppy.com");
				r13.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "693 Michael Estate");
				Reviews.Add(r13);

				Review r14 = new Review()
				{
					Rating = 4,
					CustomerComment = " "
				};
				r14.User = context.Users.FirstOrDefault(u => u.Email == "lamemartin.Martin@aool.com");
				r14.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "457 Vargas Island Suite 853");
				Reviews.Add(r14);

				Review r15 = new Review()
				{
					Rating = 1,
					CustomerComment = "There were 1...5...22 roaches? I lost count."
				};
				r15.User = context.Users.FirstOrDefault(u => u.Email == "fd@puppy.com");
				r15.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "94102 Sims Port Suite 187");
				Reviews.Add(r15);

				Review r16 = new Review()
				{
					Rating = 1,
					CustomerComment = " "
				};
				r16.User = context.Users.FirstOrDefault(u => u.Email == "sheff44@puppy.com");
				r16.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "1168 Gary Fords Apt. 308");
				Reviews.Add(r16);

				Review r17 = new Review()
				{
					Rating = 4,
					CustomerComment = "I LOVED the place! Had a nice view of the mountains"
				};
				r17.User = context.Users.FirstOrDefault(u => u.Email == "fd@puppy.com");
				r17.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "1220 Heidi Rue Apt. 998");
				Reviews.Add(r17);

				Review r18 = new Review()
				{
					Rating = 5,
					CustomerComment = " "
				};
				r18.User = context.Users.FirstOrDefault(u => u.Email == "tuck33@puppy.com");
				r18.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "1220 Heidi Rue Apt. 998");
				Reviews.Add(r18);

				Review r19 = new Review()
				{
					Rating = 5,
					CustomerComment = "My stay was amazing! Saved my marriage"
				};
				r19.User = context.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");
				r19.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "588 Alan Rest");
				Reviews.Add(r19);

				Review r20 = new Review()
				{
					Rating = 2,
					CustomerComment = " "
				};
				r20.User = context.Users.FirstOrDefault(u => u.Email == "sheff44@puppy.com");
				r20.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "457 Vargas Island Suite 853");
				Reviews.Add(r20);

				Review r21 = new Review()
				{
					Rating = 2,
					CustomerComment = "My wife's attitude was the only thing rougher than the sand at the nearby beaches"
				};
				r21.User = context.Users.FirstOrDefault(u => u.Email == "orielly@foxnets.com");
				r21.Property = context.Properties.FirstOrDefault(p => p.PropertyAddress == "03541 Ryan Islands Apt. 562");
				Reviews.Add(r21);

				foreach (Review revToAdd in Reviews)
				{
					Review dbReview = context.Reviews.FirstOrDefault(r => r.ReviewID == revToAdd.ReviewID);
					if (dbReview == null)
					{
						context.Reviews.Add(revToAdd);
						context.SaveChanges();
						intReviewsAdded++;
					}
					else
					{ 
						dbReview.Rating = revToAdd.Rating;
						dbReview.CustomerComment = revToAdd.CustomerComment;
						context.Update(revToAdd);
						context.SaveChanges();
						intReviewsAdded++;
					}
				}
			}
			catch
			{
				String msg = "Reviews added: " + intReviewsAdded.ToString();
				throw new InvalidOperationException(msg);
			}
		}
	}
}
