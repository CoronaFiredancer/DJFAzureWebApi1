using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DJFAzureWebApi1.Models.DJF
{
	public class Member
	{
		public int MemberId { get; set; }
		public string MemberNumber { get; set; }
		public string Name { get; set; }
		public List<Membership> MemberShips { get; set; }
		

		public Member()
		{
			MemberShips = new List<Membership>();
		}
	}
}