using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DJFAzureWebApi1.Models.DJF;

namespace DJFAzureWebApi1.Controllers
{
	public class MembershipsController : ApiController
	{
		private readonly List<Membership> memberships = DB.Memberships;

		public IHttpActionResult GetMembership(int id)
		{
			var membership = memberships.FirstOrDefault(x => x.MembershipId == id);

			if (membership != null)
			{
				return Ok(membership);
			}

			return NotFound();
		}

		public IHttpActionResult GetMemberships()
		{
			if (memberships.Count > 0)
			{
				return Ok(memberships);
			}

			return NotFound();
		}
	}
}
