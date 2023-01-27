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
            MoodAnalser mood = new MoodAnalser("Happy");
            string AcutalResult = mood.Mood(sadmood);
            string expected = "Sad";
            Assert.AreEqual(expected, AcutalResult);
        }
        [TestMethod]
        public void GiveMoodShouldReturnHappMood()
        {
            const string happymood = "Happy";
            const string sadmood = "Sad";
            MoodAnalser mood = new MoodAnalser("Happy");
            string AcutalResult = mood.Mood(happymood);
            string expected = "Happy";
            Assert.AreEqual(expected, AcutalResult);
        }
        //UC-2
        
        /// TC2.1Given Null Mood Should Return Happy To make this Test Case pass Handle
        /// NULL Scenario using try catch and return Happy
        /// </summary>
        [TestMethod]
        public void GivenMessage_WhenNull_ShouldReturnHappy()
        {
            MoodAnalser moodAnalser  = new MoodAnalser("Happy");
            string message = moodAnalser.AnalyseMood();
            Assert.AreEqual("HAPPY", message);
        }

    }
}