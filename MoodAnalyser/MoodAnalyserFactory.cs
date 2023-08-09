using System;
using System.Text.RegularExpressions;
using System.Reflection;
namespace MoodAnalyser
{
	public class MoodAnalyserFactory
	{
		// Creating MoodAnalyserObject using Reflection by passing name of class and the default constructor //
		public static object CreateMoodAnalyserObject(string className, string constructorName)
		{
			string pattern = @"." + className + "$";
			// Matching if the className provided same as the name of the constructor
			// If matches -> Success, Else--> False//
			//Match result = Regex.Match(className, pattern);
            Match result = Regex.Match(pattern, className);
			if (result.Success)
			{
				try
				{
					// Extracting info about the class using assembly//
					Assembly fetchInformation = Assembly.GetExecutingAssembly();
					Type moodAnalyseType = fetchInformation.GetType(className);

					// Activator-> Class helps to create instance of objects//
					return Activator.CreateInstance(moodAnalyseType);
				} 
				catch(ArgumentException)
				{
					throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
				}
			}
			else
			{
				throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Constructor Not found");
			}
		}
	}
}

