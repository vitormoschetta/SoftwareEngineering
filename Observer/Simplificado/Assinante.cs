using System;

namespace Simplificado
{
    public class Assinante
    {
        public Assinante(Editora editora)
        {
            editora.AddAssinante(this);
        }

        public void Notificar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}