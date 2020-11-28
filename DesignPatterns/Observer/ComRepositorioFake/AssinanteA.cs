using System;
using ComRepositorioFake.Contrato;

namespace ComRepositorioFake
{
    public class AssinanteA : IAssinante
    {
        public AssinanteA(Editora editora)
        {
            editora.AddAssinante(this);
        }

        public void Notificar(string numeroNovaEdicao)
        {
            Console.WriteLine("[AssinanteA] - Nova publicação: " + numeroNovaEdicao);
        }
    }
}