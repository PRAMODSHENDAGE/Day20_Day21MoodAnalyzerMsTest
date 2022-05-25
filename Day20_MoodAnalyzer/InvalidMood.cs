using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20_MoodAnalyzer
{
    public class InvalidMood
    {
        string Message;

        public InvalidMood(string message)
        {
            this.Message = message;
        }

        public string AnalysingMood()
        {
            try
            {
                if (this.Message.ToUpper().Contains("Happy"))
                {
                    return "HAPPY";
                }
                else if (this.Message.ToUpper().Contains("Sad"))
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
