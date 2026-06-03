// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Thread t = new Thread(WriteY);
t.Start();


for(int  i = 0; i < 100; i++)
{
    Console.Write("x");
}

void WriteY()
{
    for(int i = 0;i < 100;i++) Console.Write("Y");
}