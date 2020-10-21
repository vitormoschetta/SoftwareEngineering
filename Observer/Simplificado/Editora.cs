using System.Collections.Generic;

namespace Simplificado
{
    public class Editora
    {
        List<Assinante> _assinantes = new List<Assinante>();

        public void AddAssinante(Assinante assinante)
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
                assinante.Notificar("Nova edição publicadas: " + numeroEdicao);
            }
        }
    }
}