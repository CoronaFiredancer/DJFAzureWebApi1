using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DJFAzureWebApi1.Models.DJF;

namespace DJFAzureWebApi1.Controllers
{
	public class MembershipsController : ApiController
	{
		private readonly List<Membership> memberships = DB.Memberships;
	}
}
