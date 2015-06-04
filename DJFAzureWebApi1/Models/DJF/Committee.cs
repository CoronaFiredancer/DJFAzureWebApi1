using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DJFAzureWebApi1.Models.DJF
{
	public class Committee
	{
		public int CommitteeId { get; set; }
		public string CommitteeName { get; set; }
		public List<Membership> Memberships { get; set; }

		public Committee()
		{
			Memberships = new List<Membership>();
		}

	}
}