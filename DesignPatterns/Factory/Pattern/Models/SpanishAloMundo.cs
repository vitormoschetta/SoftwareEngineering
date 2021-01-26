using System;
using Pattern.Interfaces;

namespace Pattern.Models
{
    public class SpanishAloMundo : IAloMundo
    {
        public void FalaAlo()
        {
            Console.WriteLine("Hola Mundo");
        }
    }
}