using MoodAnalyzer;

namespace MoodTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const string happymood = "Happy";
            const string sadmood = "Sad";
            MoodAnalser mood = new MoodAnalser(); //Arrange
            string AcutalResult = mood.Mood(sadmood); //Act
            string expected = "Sad";
            Assert.AreEqual(expected, AcutalResult); //Assert
        }
    }
}