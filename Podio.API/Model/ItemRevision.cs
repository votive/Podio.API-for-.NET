using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Podio.API.Model
{
	[DataContract]
	public class ItemRevision 
	{


		[DataMember(Name = "revision", IsRequired=false)]
		public int? Revision { get; set; }


		[DataMember(Name = "app_revision", IsRequired=false)]
		public int? AppRevision { get; set; }


		[DataMember(Name = "created_on", IsRequired=false)]
		public string CreatedOn { get; set; }


		[DataMember(Name = "created_by", IsRequired=false)]
		public ByLine CreatedBy { get; set; }


		[DataMember(Name = "created_via", IsRequired=false)]
		public Via CreatedVia { get; set; }


	}
}
