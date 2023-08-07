namespace MoodAnalyser;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mood Analyser Problem");

        MoodAnalysis obj = new MoodAnalysis("I am in sad Mood");
        string res = obj.AnalyseMood();
        Console.WriteLine(res);

        Console.ReadLine();
    }
}

