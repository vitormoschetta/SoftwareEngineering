using System.Collections.Generic;

namespace ComValidacaoDeObjetoObservado
{
    public class Editora
    {
        List<Assinante> _assinantes = new List<Assinante>();
        string ultimaEdicao = null;

        public void AddAssinante(Assinante assinante)
        {
            _assinantes.Add(assinante);
        }

        public void PublicarEdicao(string numeroEdicao)
        {
            ultimaEdicao = numeroEdicao;
            NotificarAssinantes(numeroEdicao);
        }

        public void NotificarAssinantes(string numeroEdicao)
        {
            foreach (var assinante in _assinantes)
            {
                assinante.Notificar(this);
            }
        }

        public string GetEdicao()
        {
            return ultimaEdicao;
        }
    }
}