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
    [DataRow("")]
    public void Given_Empty_Mood_Return_MoodAnalysisException_Indicating_EMPTY_MOOD(string input)
    {
        try
        {
            //Arrange
            MoodAnalysis obj = new MoodAnalysis(input);

            //Act
            string result = obj.AnalyseMood();
        }
        catch(MoodAnalysisException e)
        {
            Assert.AreEqual("Mood Should Not be Empty", e.Message);
        }
    }
    [TestMethod]
    [DataRow(null)]
    public void Given_Null_Mood_Return_MoodAnalysisException_Indicating_NULL_MOOD(string input)
    {
        try
        {
            //Arrange
            MoodAnalysis obj = new MoodAnalysis(input);

            //Act
            string result = obj.AnalyseMood();
        }
        catch (MoodAnalysisException e)
        {
            Assert.AreEqual("Mood Should Not be NULL", e.Message);
        }
    }

    [TestMethod]
    public void Given_Proper_Class_Details_Return_MoodAnalyserObject()
    {
        
        MoodAnalysis expectedObj = new MoodAnalysis();
        object resultObject = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyser.MoodAnalysis", "MoodAnsalysis");
        expectedObj.Equals(resultObject);

    }

    [TestMethod]
    public void Given_Proper_Class_Details_Return_MoodAnalyserObjectWith_ParameterizedConstructor()
    {


        MoodAnalysis expectedObj = new MoodAnalysis("happy");
        object resultObject = MoodAnalyserFactory.CreateMoodAnalyserObjectUsingParameterisedConstr("MoodAnalyser.MoodAnalysis", "MoodAnalysis", "happy");
        expectedObj.Equals(resultObject);

    }
    [TestMethod]
    public void Given_ImProper_Class_Details_Return_No_Such_ClassError()
    {

        try
        {
            MoodAnalysis expectedObj = new MoodAnalysis("happy");
            object resultObject = MoodAnalyserFactory.CreateMoodAnalyserObjectUsingParameterisedConstr("MoodAnalyser.MoodAnalysis", "MoodAnalysis", "happy");
            expectedObj.Equals(resultObject);

        }
        catch (MoodAnalysisException e)
        {
            Assert.AreEqual("Class Not Found", e.Message);
        }

    }
    [TestMethod]
    public void Given_ImProper_Constructor_Return_No_Such_MethodError()
    {

        try
        {
            MoodAnalysis expectedObj = new MoodAnalysis("happy");
            object resultObject = MoodAnalyserFactory.CreateMoodAnalyserObjectUsingParameterisedConstr("MoodAnalyser.MoodAnalysis", "MoodAnalyvsis", "happy");
            expectedObj.Equals(resultObject);

        }
        catch (MoodAnalysisException e)
        {
            Assert.AreEqual("Constructor Not found", e.Message);
        }

    }
}
