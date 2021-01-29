using System;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var log01 = FileLogger.GetInstance();
            log01.Text = "Log01";
            Console.WriteLine(log01.Text);

            var log02 = FileLogger.GetInstance();            
            Console.WriteLine(log02.Text); // <-- Era pra ser nulo o log02.Text caso fosse instanciado.
        }
    }
}
