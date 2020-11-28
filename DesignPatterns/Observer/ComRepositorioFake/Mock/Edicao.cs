using System;

namespace ComRepositorioFake.Mock
{
    public class Edicao
    {
        public Edicao(string titulo, string numeroEdicao)
        {
            Id = Guid.NewGuid();
            Titulo = titulo;
            NumeroEdicao = numeroEdicao;
        }


        public Guid Id { get; private set; }
        public string Titulo { get; private set; }
        public string NumeroEdicao { get; private set; }
    }
}