using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalser
    {
        public const string Happy_Mood = "Happy";
        public const string Sad_Mood = "Sad";
        public string Mood(string mood)
        {
            if (mood.ToLower().Contains("happy"))
            {
                Console.WriteLine(Happy_Mood);
                return mood;
            }
            if (mood.ToLower().Contains("sad"))
            {
                Console.WriteLine(Sad_Mood);
                return mood;
            }
            else
            {
                return null;
            }
        }

        private string message;
        //Parametraiz Constructor
        public MoodAnalser(string message)
        {
            this.message = message;
        }



        //UC-2 Using Try Catch Blocks to Handle Null Exception.
        public string AnalyseMood()
        {
            try
            {
                if (this.message.ToLower().Contains("sad"))
                {
                     
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch (NullReferenceException)
            {
                return "HAPPY";
            }

        }
    }
}
