using System;
namespace MoodAnalyser
{
	public class MoodAnalysis
	{
		private string message;
		public MoodAnalysis(string msg)
		{
			this.message = msg;
		}

		public string AnalyseMood()
		{
			string messageLowerCase = this.message.ToLower();
			if(messageLowerCase.Contains("sad"))
			{
				return "sad";
			}
			else
			{
				return "happy";
			}
		}
	}
}

