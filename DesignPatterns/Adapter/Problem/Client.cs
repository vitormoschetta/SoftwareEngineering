using System;

namespace Problem
{
    public class Client : IDb
    {
        public void Insert()
        {
            Console.WriteLine("Update...");
        }

        public void Update()
        {
            Console.WriteLine("Delete...");
        }

        public void Delete()
        {
            Console.WriteLine("Insert...");
        }
    }
}