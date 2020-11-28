using System;

namespace ComValidacaoDeObjetoObservado
{
    class Program
    {
        static void Main(string[] args)
        {
            var editora = new Editora();
            var assinante = new Assinante(editora);
            editora.PublicarEdicao("Ed 25");
        }
    }
}
