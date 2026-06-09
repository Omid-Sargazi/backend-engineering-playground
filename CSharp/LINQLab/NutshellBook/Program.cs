// See https://aka.ms/new-console-template for more information
using NutshellBook;

Console.WriteLine("Hello, World!");

Task t1 = Task.Run(() =>
{
    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine(Thread.CurrentThread.Name);
});

Task t2 = Task.Run(() =>
{
    Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
    Console.WriteLine(Thread.CurrentThread.Name);
});
Thread t = new Thread(WriteY);
t.Start();

Thread t3 = new Thread(Go);
t3.Start();
t3.Join();
Console.WriteLine("Thread t has ended.");
 void Go()
{
    for(int i = 0; i < 1000; i++)
    {
        Console.WriteLine("t3"); 
    }
}

for(int  i = 0; i < 100; i++)
{
    Console.Write("x");
}

void WriteY()
{
    for(int i = 0;i < 100;i++) Console.Write("Y");
}

Thread_Yield  ty = new Thread_Yield();
ty.Run();