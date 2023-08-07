namespace MoodAnalyserTesting;
using MoodAnalyser;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow("I am very SAD", "sad")]
    [DataRow("I am very Sad", "sad")]
    [DataRow("I am very sad", "sad")]
    [DataRow("I am very sAd", "sad")]
    public void GivenSadMoodReturnSAD(string input, string expected)
    {
        //Arrange
        MoodAnalysis obj = new MoodAnalysis(input);

        //Act
        string result = obj.AnalyseMood();

        //Assert
        Assert.AreEqual(result, expected);
    }
    [TestMethod]
    [DataRow("I am very HAPPY", "happy")]
    [DataRow("I am very Happy", "happy")]
    [DataRow("I am very happy", "happy")]
    [DataRow("I am very haPPy", "happy")]
    [DataRow("I am feeling good", "happy")]
    public void GivenHappyMoodReturnHAPPY(string input, string expected)
    {
        //Arrange
        MoodAnalysis obj = new MoodAnalysis(input);

        //Act
        string result = obj.AnalyseMood();

        //Assert
        Assert.AreEqual(result, expected);
    }

    [TestMethod]
    [DataRow("", "happy")]
    public void GivenNullMoodReturnHAPPY(string input, string expected)
    {
        //Arrange
        MoodAnalysis obj = new MoodAnalysis(input);

        //Act
        string result = obj.AnalyseMood();

        //Assert
        Assert.AreEqual(result, expected);
    }
}
