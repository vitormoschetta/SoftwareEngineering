using System;
using Pattern.Interfaces;

namespace Pattern.Models
{
    public class GermanAloMundo : IAloMundo
    {
        public void FalaAlo()
        {
            Console.WriteLine("Hallo Welt");
        }
    }
}