using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day20_MoodAnalyzer
{
    public class MoodAnalyserFactory
    {
        public string ClassName;
        public string Constructor;
        public MoodAnalyserFactory(string className, string constructor)
        {
            this.ClassName = className;
            this.Constructor = constructor;
        }


        public static object FactoryMethod(MoodAnalyserFactory factory)
        {
            if ("HappySad" == factory.Constructor)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type AnaylseType = executing.GetType(factory.ClassName);
                    var MyObj = Activator.CreateInstance(AnaylseType);
                    return MyObj;
                }
                catch
                {
                    throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, ("Class name is Wrong"));
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, ("Constructor name is Wrong"));
            }
        }

        public static object InvokeMethod(MoodAnalyserFactory factory, string v)
        {
            throw new NotImplementedException();
        }
    }
}
