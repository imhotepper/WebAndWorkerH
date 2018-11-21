using System;
using System.Threading;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Worker executed @: " + DateTime.Now.ToString("yyyy-MM-dd hh:mm:sss"));
                Thread.Sleep((1000));
            }
            
        }
    }
}