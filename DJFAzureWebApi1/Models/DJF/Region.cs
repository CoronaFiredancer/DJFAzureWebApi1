using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DJFAzureWebApi1.Models.DJF
{
	public class Region
	{
		public string RegionName { get; set; }
		public List<JKF> Municipalities { get; set; }


		public Region()
		{
			Municipalities = new List<JKF>();
		}
	}
}