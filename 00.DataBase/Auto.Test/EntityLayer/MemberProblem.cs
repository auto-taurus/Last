using System;

namespace OnLineStoreCore.EntityLayer
{
	public partial class MemberProblem : IEntity
	{
		public MemberProblem()
		{
		}

		public MemberProblem(Int32? problemId)
		{
			ProblemId = problemId;
		}

		public Int32? ProblemId { get; set; }

		public String Title { get; set; }

		public String Desc { get; set; }

		public Int32? Type { get; set; }

		public String Urls { get; set; }

		public Int32? IsHot { get; set; }

		public Int32? IsEnable { get; set; }

		public String Remarks { get; set; }

		public Int32? CreateBy { get; set; }

		public DateTime? CreateTime { get; set; }
	}
}
