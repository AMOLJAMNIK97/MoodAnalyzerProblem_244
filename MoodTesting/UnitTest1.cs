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
            MoodAnalser moodAnalser = new MoodAnalser("Happy");
            string message = moodAnalser.AnalyseMood();
            Assert.AreEqual("HAPPY", message);
        }

        //uc3 
        //<Summary>
        //TC3.2 Given NULL Mood  Should Throw MoodAnalysisException Indicting Exception
        [TestMethod]
        public void Given_Mood_Should_Throw_MoodAnalysisException_Indication_EmptyMood()
        {
            try
            {
                string message = " ";
                MoodAnalser moodAnalser = new MoodAnalser(message);
                string mood = moodAnalser.AnalyseMood();

            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood Should be not Empty", e.Message);
            }
              
        }

        //<Summary>
        //TC3.1 Given Given NULL Mood Should Throw MoodAnalysisException
        [TestMethod]
        public void Given_NULL_Mood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                string message =null;
                MoodAnalser moodAnalser = new MoodAnalser(message);
                string mood = moodAnalser.AnalyseMood();
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood Should be not Null", e.Message);
            }
        }



    }
}   