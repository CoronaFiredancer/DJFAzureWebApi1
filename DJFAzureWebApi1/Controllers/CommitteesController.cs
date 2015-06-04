using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DJFAzureWebApi1.Models.DJF;

namespace DJFAzureWebApi1.Controllers
{
	public class CommitteesController : ApiController
	{
		private readonly List<Committee> committees = DB.Committees;

		public IHttpActionResult GetCommittee(int id)
		{
			var committee = committees.FirstOrDefault(x => x.CommitteeId == id);

			if (committee != null)
			{
				return Ok(committee);
			}

			return NotFound();
		}

		public IHttpActionResult GetCommittees()
		{
			if (committees.Count > 0)
			{
				return Ok(committees);
			}

			return NotFound();
		}
	}
}
