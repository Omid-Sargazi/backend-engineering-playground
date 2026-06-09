using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutshellBook
{
    public  class Thread_Yield
    {
        public void Run()
        {
            new Thread(PrintB).Start();
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                Console.Write("A");
                Thread.Yield();
            }
        }

        static void PrintB()

        {
            for(int i=0;i<5;i++)
            {
                Console.Write("B");
            }
        }
    }
}

    

