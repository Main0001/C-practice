using System;
using System.Threading;

class Pogram
{
    static void FirstThgread()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"First thread display: {i}");
        }
    }

    static void SecondThread()
    {

        for (int i = 10; i < 20; i++)
        {
            Console.WriteLine($"Second thread display: {i}");
        }
    }

    static void ThirdThread()
    {
        for (int i = 20; i < 30; i++)
        {
            Console.WriteLine($"Third thread display: {i}");
        }
    }

    static void Main(string[] args)
    {
        Thread fThread = new Thread(FirstThgread);
        Thread sThread = new Thread(SecondThread);
        Thread tThread = new Thread(ThirdThread);
        fThread.Priority = ThreadPriority.Highest;
        sThread.Priority = ThreadPriority.AboveNormal;
        tThread.Priority = ThreadPriority.Lowest;
        fThread.Start();
        Thread.Sleep(500);
        sThread.Start();
        Thread.Sleep(1000);
        tThread.Start();
    }
}