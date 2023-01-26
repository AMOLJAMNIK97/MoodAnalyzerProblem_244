using MoodAnalyzer;

namespace MoodTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GiveMoodShouldReturnSadMood()
        {
            const string happymood = "Happy";
            const string sadmood = "Sad";
            MoodAnalser mood = new MoodAnalser();
            string AcutalResult = mood.Mood(sadmood);
            string expected = "Sad";
            Assert.AreEqual(expected, AcutalResult);
        }
        [TestMethod]
        public void GiveMoodShouldReturnHappMood()
        {
            const string happymood = "Happy";
            const string sadmood = "Sad";
            MoodAnalser mood = new MoodAnalser();
            string AcutalResult = mood.Mood(happymood);
            string expected = "Happy";
            Assert.AreEqual(expected, AcutalResult);
        }
    }
}