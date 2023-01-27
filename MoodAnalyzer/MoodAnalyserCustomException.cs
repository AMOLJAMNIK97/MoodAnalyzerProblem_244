using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public class MoodAnalyserCustomException:Exception 
    {
        public enum ExceptionalType
        {
            NULL_MASSEAGE, EMPTY_MASSAGE,
            NO_SUCH_CLASS, OBJECT_CREATION_ISSUE
               
        }
        private readonly ExceptionalType Type;

        public MoodAnalyserCustomException(ExceptionalType type, string message):base (message)
        {
            Type = type;
        }
    }
}
