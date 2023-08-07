using System;
namespace MoodAnalyser
{
	public class MoodAnalysis
	{
		private string message;

        public MoodAnalysis()
        {
            this.message = "";
        }
        public MoodAnalysis(string msg)
		{
			this.message = msg;
		}

		public string AnalyseMood()
		{
			string messageLowerCase = this.message.ToLower();
			try
			{
                if (messageLowerCase.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch
            {
                return "happy";
            }
			
		}
	}
}

