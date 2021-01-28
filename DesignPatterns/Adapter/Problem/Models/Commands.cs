using System;
using System.Collections.Generic;
using Problem.Interfaces;

namespace Problem.Models
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