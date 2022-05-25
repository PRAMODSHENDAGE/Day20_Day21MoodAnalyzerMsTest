using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_MoodAnalyzer
{
    public class HappyOrSad
    {
        public string Message;

        public HappyOrSad(string message)
        {
            this.Message = message;
        }

        public string AnalysingMood()
        {
            if (Message.ToUpper().Contains("Happy"))
            {
                return "HAPPY";
            }
            if (Message.ToUpper().Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
