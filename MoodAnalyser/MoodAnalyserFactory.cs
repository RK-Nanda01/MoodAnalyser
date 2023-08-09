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
		
			Type type = typeof(MoodAnalysis);
			if(type.Name.Equals(className) || type.FullName.Equals(className))
			{
				if(type.Name.Equals(constructorName))
				{
                    Assembly fetchInformation = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = fetchInformation.GetType(className);

                    // Activator-> Class helps to create instance of objects//
                    return Activator.CreateInstance(moodAnalyseType);
                }
				else
				{
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Constructor Not found");
                }
			}

			else
			{
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class Not Found");
            }
		}
	}
}

