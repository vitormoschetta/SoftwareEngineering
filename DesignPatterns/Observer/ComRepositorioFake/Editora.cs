using System.Collections.Generic;
using ComRepositorioFake.Contrato;
using ComRepositorioFake.Mock;

namespace ComRepositorioFake
{
    public class Editora
    {
        private IRepositorio _repositorio;
        List<IAssinante> _assinantes = new List<IAssinante>();

        public Editora(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }


        public void AddAssinante(IAssinante assinante)
        {
            _assinantes.Add(assinante);
        }

        public void PublicarEdicao(Edicao edicao)
        {
            _repositorio.Add(edicao);
            NotificarAssinantes(edicao);
        }

        public void NotificarAssinantes(Edicao edicao)
        {
            foreach (var assinante in _assinantes)
            {
                assinante.Notificar(edicao.NumeroEdicao);
            }
        }
    }
}