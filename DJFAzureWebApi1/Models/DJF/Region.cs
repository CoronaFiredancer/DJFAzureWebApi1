using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DJFAzureWebApi1.Models.DJF
{
	public class DjfRegionContext : DbContext
	{
		public DbSet<Region> Regions { get; set; }
	}


	public class Region
	{
		public int RegionId { get; set; }
		public string RegionName { get; set; }
		public List<JKF> Municipalities { get; set; }


		public Region()
		{
			Municipalities = new List<JKF>();
		}
	}
}