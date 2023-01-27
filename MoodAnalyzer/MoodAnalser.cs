using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalser
    {
        public string message;

        public MoodAnalser()
        {
            Console.WriteLine("Default Constructor");
        }
        public MoodAnalser(string message)//constructor
        {
            this.message = message;
        }
        public string AnalyseMood() //method to analyse mood
        {
            try
            {
                if (this.message.Equals(""))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionalType.EMPTY_MASSAGE, "Mood should not be empty");
                }
                else if (this.message.ToLower().Contains("sad"))
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
                throw new MoodAnalyserCustomException (MoodAnalyserCustomException.ExceptionalType.NULL_MASSEAGE, "Mood should not be null");
            }
        }
    }
}
