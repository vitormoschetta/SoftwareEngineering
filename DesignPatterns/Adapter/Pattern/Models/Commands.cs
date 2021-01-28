using System;
using Pattern.Interfaces;

namespace Pattern.Models
{
    public class Commands : IDbAdapter
    {
        public void Insert()
        {
            Console.WriteLine("Insert Db");
        }

        public void Update()
        {
            Console.WriteLine("Update Db");
        }

        public void Delete()
        {
            Console.WriteLine("Delete Db");
        }
    }
}