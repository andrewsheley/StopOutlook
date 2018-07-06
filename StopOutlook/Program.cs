using System;
using System.Diagnostics;

namespace StopOutlook
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var outLooks = Process.GetProcessesByName("outlook");

                outLooks?[0].Kill();


            }
            catch 
            {

                throw;
            }


            Console.WriteLine("Outlook Stopped");
        }
    }
}
