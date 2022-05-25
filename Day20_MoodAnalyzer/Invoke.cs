using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day20_MoodAnalyzer
{
    public class Invoke
    {

        public string ClassName;
        public string Constructor;
        public Invoke(string className, string constructor)
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
                    throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, ("Class Name is Wrong"));
                }
            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.CONSTRUCTOR_NOT_FOUND, ("Constructor Name is Wrong"));
            }
        }



        public static object InvokeMethod(MoodAnalyserFactory factory, string message)
        {
            try
            {
                Assembly executing = Assembly.GetExecutingAssembly();
                Type AnaylseType = executing.GetType(factory.ClassName);
                ConstructorInfo ctor = AnaylseType.GetConstructor(new[] { typeof(string) });
                object MyObj = ctor.Invoke(new object[] { message });
                return MyObj;
            }
            catch
            {
                throw new CustomException(CustomException.ExceptionType.CLASS_NOT_FOUND, ("Class Name is Wrong"));
            }
        }

    }
}
