using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.SingletonPattern
{
    public class Example1
    {
        private static Example1 _Instance;
        private Example1()
        {

        }

        public static Example1 CreateInstance()
        {
            if (_Instance == null) 
            {
                return new Example1(); 
            }
            return _Instance;
        }
    }

    public class CreateInstance
    {
        public void Execute()
        {
            var obj = Example1.CreateInstance();
        }
    }
}

