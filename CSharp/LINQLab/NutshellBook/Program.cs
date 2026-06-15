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
Console.Write("Thread t has ended.");
 void Go()
{
    for(int i = 0; i < 1000; i++)
    {
        Console.Write("t3"); 
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

bool blocked = (t3.ThreadState & ThreadState.WaitSleepJoin) != 0;

Thread_Yield  ty = new Thread_Yield();
ty.Run();


Thread dbThread = new Thread(GetBankTransactions);
dbThread.Start();


for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Main thread doing other work... {i}");
    Thread.Sleep(300); // شبیه‌سازی کار دیگر
}

void GetBankTransactions()
{
    Console.WriteLine($"DB thread {Thread.CurrentThread.ManagedThreadId} started");

    Thread.Sleep(30);
    Console.WriteLine($"DB thread {Thread.CurrentThread.ManagedThreadId} - got 1,000,000 transactions");
}

long sum = 0;
for (int i = 0; i < 1000000; i++)
{
    sum += i; // شبیه‌سازی پردازش
}
Console.WriteLine($"Processing complete. Sum: {sum}");