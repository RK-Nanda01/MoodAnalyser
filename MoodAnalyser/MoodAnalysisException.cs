using System;
namespace MoodAnalyser
{
	public class MoodAnalysisException : Exception
	{
		public enum ExceptionType
		{
			NULL_MOOD, EMPTY_MOOD,NO_SUCH_CLASS, NO_SUCH_METHOD
        }

		private ExceptionType typeOfException;

		public MoodAnalysisException(ExceptionType type, string message) : base(message)
		{
			this.typeOfException = type;

		}

	}
}

