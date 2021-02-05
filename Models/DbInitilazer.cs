using System.Linq;

namespace BookingService.Models
{
    public class DbInitilazer
    {

        public static void Initialize(DBContext context)
        {

            if (context.HousePosts.Any())
            {
                return;
            }
            context.HousePosts.AddRange(
                new HousePost
                {

                    Title = "TOP House",
                    Description = "4-rooms",
                    Price = 24.30,
                    Country = "Ukraine",
                    City = "Kharkiv",
                    Address = "Heroiv Ukraine 22",
                    Status = false,
                    Score = 0
                    
                },
                new HousePost
                {

                    Title = "Medium house",
                    Description = "New smart house in Kyiv",
                    Price = 24.30,
                    Country = "Ukraine",
                    City = "Kyiv",
                    Address = "Heroiv Ukraine 12",
                    Status = false,
                    Score = 0
                },
                 new HousePost
                 {

                     Title = "Cool apartment in Russia",
                     Description = "fdsdgfdsaf",
                     Price = 24.30,
                     Country = "Russia",
                     City = "Moscow",
                     Address = "Pronicianskaya 11",
                     Status = false,
                     Score = 0
                 },
                  new HousePost
                  {

                      Title = "FZFSD",
                      Description = "fdsdgfdsaf",
                      Price = 24.30,
                      Country = "Ukraine",
                      City = "Kharkiv",
                      Address = "Heroiv Ukraine 22",
                      Status = false,
                      Score = 0
                  },
                   new HousePost
                   {

                       Title = "FZFSD",
                       Description = "fdsdgfdsaf",
                       Price = 24.30,
                       Country = "Ukraine",
                       City = "Kharkiv",
                       Address = "Heroiv Ukraine 22",
                       Status = false,
                       Score = 0
                   },
                    new HousePost
                    {

                        Title = "T-house",
                        Description = "fdsdgfdsaf",
                        Price = 24.30,
                        Country = "Ukraine",
                        City = "Chernigiv",
                        Address = "Heroiv Ukraine 22",
                        Status = false,
                        Score = 0
                    },
                     new HousePost
                     {

                         Title = "FZFSD",
                         Description = "fdsdgfdsaf",
                         Price = 24.30,
                         Country = "Ukraine",
                         City = "Lviv",
                         Address = "Trunskiwka 52",
                         Status = false,
                         Score = 0
                     }
            );
            context.SaveChanges();
        }

    }
}


