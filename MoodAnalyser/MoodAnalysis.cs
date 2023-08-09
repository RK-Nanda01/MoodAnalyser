using System;
namespace MoodAnalyser
{
	public class MoodAnalysis
	{
		private string message;

        public MoodAnalysis(string msg="")
		{
			this.message = msg;
		}

		public string AnalyseMood()
		{
			string messageLowerCase = this.message.ToLower();

			try
			{
				if(this.message.Equals(string.Empty))
				{
					throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MOOD, "Mood Should Not be Empty");
				}
                if (messageLowerCase.Contains("sad"))
                {
                    return "sad";
                }
                else
                {
                    return "happy";
                }
            }
            catch(NullReferenceException) 
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MOOD, "Mood Should Not be NULL");
            }
           
        }
	}
}

