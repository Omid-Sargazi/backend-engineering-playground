using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutshellBook
{
    public class Thread_Yield
    {
        static void Run()
        {
            new Thread(PrintB).Start();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("A");
                Thread.Yield();
            }
        }

        static void PrintB()

        {
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("B");
            }
        }
    }
}

    
}
