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

                         Title = "FZFSD",
                         Description = "fdsdgfdsaf",
                         Price = 24.30,
                         Country = "Ukraine",
                         City = "Kharkiv",
                         Address = "Heroiv Ukraine 22",
                         Status = false,
                         Score = 0
                     }
            );
            context.SaveChanges();
        }

    }
}


