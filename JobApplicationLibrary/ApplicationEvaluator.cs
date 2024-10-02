using System;
using JobApplicationLibrary.Models;

namespace JobApplicationLibrary
{
	public class ApplicationEvaluator
	{
		public ApplicationResult Evaluate(JobApplication form)
		{
			return ApplicationResult.AutoAccepted;

        }
	}

	public enum ApplicationResult
	{
		AutoRejected,
		TransferredToHR, //İnsan kaynakları gönderildi
		TransferredToLead, //Takım liderine gönderildi
		TransferredToCTO,
        AutoAccepted
    }
} 

