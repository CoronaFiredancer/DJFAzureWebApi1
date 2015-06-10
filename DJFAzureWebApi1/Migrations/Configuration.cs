using DJFAzureWebApi1.Models.DJF;

namespace DJFAzureWebApi1.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	internal sealed class Configuration : DbMigrationsConfiguration<DJFAzureWebApi1.Models.DJF.DjfRegionContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}

		protected override void Seed(DJFAzureWebApi1.Models.DJF.DjfRegionContext context)
		{
			//  This method will be called after migrating to the latest version.

			//  You can use the DbSet<T>.AddOrUpdate() helper extension method 
			//  to avoid creating duplicate seed data. E.g.
			//
			//    context.People.AddOrUpdate(
			//      p => p.FullName,
			//      new Person { FullName = "Andrew Peters" },
			//      new Person { FullName = "Brice Lambson" },
			//      new Person { FullName = "Rowan Miller" }
			//    );
			//

			context.Regions.AddOrUpdate(x => x.RegionId,
				new Region { RegionId = 1, RegionName = "Nordjylland" },
				new Region { RegionId = 2, RegionName = "Vestjylland" },
				new Region { RegionId = 3, RegionName = "Østjylland" },
				new Region { RegionId = 4, RegionName = "Sønderjylland" }
				);
		}
	}
}
