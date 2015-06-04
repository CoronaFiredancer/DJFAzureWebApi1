using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DJFAzureWebApi1.Models.DJF
{
	public class Membership
	{
		public int MembershipId { get; set; }
		public Member Member { get; set; }
		public Committee Committee { get; set; }
	}
}