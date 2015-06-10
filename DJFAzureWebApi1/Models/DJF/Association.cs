using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DJFAzureWebApi1.Models.DJF
{
	public class Association
	{
		public int AssociationId { get; set; }
		public JKF Jkf { get; set; }
		public string Name { get; set; }
	}
}