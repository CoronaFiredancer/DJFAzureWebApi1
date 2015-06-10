using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DJFAzureWebApi1.Models.DJF
{
	public class JKF
	{
		public int JkfId { get; set; }
		public string Name { get; set; }



		public Region Region { get; set; }
		public List<Association> Associations { get; set; }
		public Member GreenCouncil { get; set; }
		public Member HunterCounsellor { get; set; }

		public JKF()
		{
			Associations = new List<Association>();
		}
	}
}