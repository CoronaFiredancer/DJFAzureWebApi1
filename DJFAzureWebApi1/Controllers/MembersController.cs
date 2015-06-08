using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DJFAzureWebApi1.Models.DJF;

namespace DJFAzureWebApi1.Controllers
{
	public class MembersController : ApiController
	{
		private readonly List<Member> dbMembers = DB.Members;
		
		public IHttpActionResult GetMember(int id)
		{
			var member = dbMembers.FirstOrDefault(x => x.MemberId == id);

			if (member == null)
			{
				return NotFound();
			}

			return Ok(member);
		}

		public IHttpActionResult GetMembers()
		{
			if (dbMembers.Count > 0)
			{
				return Ok(dbMembers);
			}

			return NotFound();
		}



	}
}
