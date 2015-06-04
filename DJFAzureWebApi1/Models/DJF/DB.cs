using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DJFAzureWebApi1.Models.DJF
{
	public static class DB
	{
		public static List<Member> Members { get; set; }
		public static List<Membership> Memberships { get; set; }
		public static List<Committee> Committees { get; set; }

		static DB()
		{
			Members = new List<Member>
			{
				new Member { MemberId = 1, Name = "Steno" },
				new Member { MemberId = 2, Name = "Brahe" }, 
				new Member { MemberId = 3, Name = "Rømer" }
			};

			Committees = new List<Committee>
			{
				new Committee{ CommitteeId = 1, CommitteeName = "Riffelsyndikatet" },
				new Committee{ CommitteeId = 2, CommitteeName = "Kortklubben" }

			};

			Memberships = new List<Membership>
			{
				new Membership {MembershipId = 1, Member = Members.First(x => x.MemberId == 1), Committee = Committees.First(x => x.CommitteeId == 1)},
				new Membership {MembershipId = 2, Member = Members.First(x => x.MemberId == 1), Committee = Committees.First(x => x.CommitteeId == 2)},
				new Membership {MembershipId = 3, Member = Members.First(x => x.MemberId == 2), Committee = Committees.First(x => x.CommitteeId == 2)}
			};
		}
	}
}