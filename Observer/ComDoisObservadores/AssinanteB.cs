using System;
using ComDoisObservadores.Contrato;

namespace ComDoisObservadores
{
    public class AssinanteB : IAssinante
    {
        public AssinanteB(Editora editora)
        {
            editora.AddAssinante(this);
        }

        public void Notificar(string numeroNovaEdicao)
        {
            Console.WriteLine("[AssinanteB] - Atenção! Nova Publicação: " + numeroNovaEdicao);
        }
    }
}