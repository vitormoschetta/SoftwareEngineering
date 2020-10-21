using System.Collections.Generic;
using ComDoisObservadores.Contrato;

namespace ComDoisObservadores
{
    public class Editora
    {
        List<IAssinante> _assinantes = new List<IAssinante>();

        public void AddAssinante(IAssinante assinante)
        {
            _assinantes.Add(assinante);
        }

        public void PublicarEdicao(string numeroEdicao)
        {
            // Add EdicaoRepository
            NotificarAssinantes(numeroEdicao);
        }

        public void NotificarAssinantes(string numeroEdicao)
        {
            foreach (var assinante in _assinantes)
            {
                assinante.Notificar(numeroEdicao);
            }
        }
    }
}