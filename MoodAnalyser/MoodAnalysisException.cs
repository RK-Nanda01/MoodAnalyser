using System;
namespace MoodAnalyser
{
	public class MoodAnalysisException : Exception
	{
		public enum ExceptionType
		{
			NULL_MOOD, EMPTY_MOOD
		}

		private ExceptionType typeOfException;

		public MoodAnalysisException(ExceptionType type, string message) : base(message)
		{
			this.typeOfException = type;

		}

	}
}

