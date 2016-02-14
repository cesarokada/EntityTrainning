using EntityFrameworkTrainning.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkTrainning
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MeContext, Configuration>());

            using (var db = new MeContext())
            {
                var vid = new Video
                {
                    Title = "Xuxa e os doentes",
                    Description = "hahahahahaha",
                    PublicationData = DateTime.Parse("01/01/2001")
                };
                db.Videos.Add(vid);
                db.SaveChanges();

                foreach (var i in db.Videos)
                {
                    Console.WriteLine(i.Title + "-" + i.Description);
                }
            }

            Console.ReadKey();
        }
    }
}
