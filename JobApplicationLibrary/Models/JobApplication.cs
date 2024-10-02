using System;
namespace JobApplicationLibrary.Models
{
	public class JobApplication
	{
		public Applicant Applicant { get; set; }
		public int YearsOfExperince { get; set; }
		public List<string> TechStackList { get; set; } //bildiği teknolojiler
	}
}



